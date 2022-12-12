using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class LocNaviWebSDKBridge
{
    #if UNITY_IPHONE
    // iOS
    [DllImport ("__Internal")]
    private static extern void _test ();
    public static void test() {
        _test();
    }

    #else

    //Android
    public static void test() {
        var LocNaviWebSDK = new AndroidJavaObject("com.locnavi.websdk.LocNaviWebSDK");
        if (LocNaviWebSDK == null){
            Debug.Log("LocNaviWebSDK 没有加载成功");
        return;
        }

        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        if (jc == null)
            return;
        AndroidJavaObject joactivety = jc.GetStatic<AndroidJavaObject>("currentActivity");
        if (joactivety == null)
            return;
        AndroidJavaObject context = joactivety.Call<AndroidJavaObject>("getApplicationContext");

        //初始化SDK
        LocNaviWebSDK.CallStatic("init", context, "lzDrdAv0y5");

        //设置服务器地址
        // LocNaviWebSDK.CallStatic("setServerUrl", "https://www.test.com");

        //设置ibeacon 扫描的uuids
        LocNaviWebSDK.CallStatic("setUUIDs", new string[1] {"FDA50693-A4E2-4FB1-AFCF-C6EB07647825"});

        //获取唯一id
        string device_id = LocNaviWebSDKBridge.GetDeviceID();
        LocNaviWebSDK.CallStatic("setUserId", device_id);

        //设置定时上传url，需要先设置userId
        LocNaviWebSDK.CallStatic("setUploadLocationApi", "http://20.205.107.64:82/api/receive/LoraPosition", 3000);

        //打开具体医院
        LocNaviWebSDK.CallStatic("openMap", context, "m1tTIWHjsq");

        //打开具体医院并引导至相应的Poi位置
        // LocNaviWebSDK.CallStatic("openMap", context, "m1tTIWHjsq", "poiId");

        //打开医院列表
        // LocNaviWebSDK.CallStatic("openMapList", context);
    }

    // Get Android DeviceID
    public static string GetDeviceID()
    {
        // Get Android ID
        AndroidJavaClass clsUnity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject objActivity = clsUnity.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject objResolver = objActivity.Call<AndroidJavaObject>("getContentResolver");
        AndroidJavaClass clsSecure = new AndroidJavaClass("android.provider.Settings$Secure");
 
        string android_id = clsSecure.CallStatic<string>("getString", objResolver, "android_id");
 
        // Get bytes of Android ID
        System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
        byte[] bytes = ue.GetBytes(android_id);
 
        // Encrypt bytes with md5
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashBytes = md5.ComputeHash(bytes);
 
        // Convert the encrypted bytes back to a string (base 16)
        string hashString = "";
 
        for (int i = 0; i < hashBytes.Length; i++)
        {
            hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
        }
 
        string device_id = hashString.PadLeft(32, '0');
 
        return device_id;
    }

    #endif

} 
