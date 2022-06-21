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
        //初始化SDK
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

        //打开具体医院
        LocNaviWebSDK.CallStatic("init", context, "lzDrdAv0y5");

        //打开医院列表
        // LocNaviWebSDK.CallStatic("openMapList", context);
    }

    #endif

} 
