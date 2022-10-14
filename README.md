# UnityWebSDKDemo
Unity 調用 webSDK的範例代碼，支持調用iOS、安卓SDK

## SDK 文檔

[iOS文檔](https://github.com/locnavi/locnavi-websdk-ios/blob/master/README.md)

[Android文檔](https://github.com/locnavi/IndoorNavigationAndroidWebSDK/blob/main/README.md)

## 獲取AppKey
appKey、mapId、targetName、targetId等信息請向 richard.chin@locnavi.com 申請

## iOS
在Assets/Plugins/iOS中放入LocNaviWebSDK.framework，通過修改同目錄下的LocNaviWebIOS文件調用SDK代碼。

C#調用framework是通過先調用C/C++代碼（LocNaviWebIOS）再讓LocNaviWebIOS去調用framework的方法。

### iOS 遇到的問題
#### Unity Building for iOS, but the embedded framework was built for iOS + iOS Simulator.
提供的framework是iOS真機和模擬器的集合，可以在Xcode中進行以下設置
<img width="853" alt="image" src="https://user-images.githubusercontent.com/7598645/174705417-34daef5c-4280-4eba-a6ac-c610c5f4c02c.png">


## Android
可參考AndroidManifest.xml、baseProjectTemplate.gradle、launcherTemplate.gradle的配置，編譯時會自動通過Gradle將需要的庫文件下載。
LocNaviWebSDKBridge.cs 中有關於iOS和Android的不同調用方法。
Demo中有在Build Settings -> Palyer Settings 中開啟gradle的使用，這樣每次導出Android項目都可以帶上這些信息。
<img width="1254" alt="image" src="https://user-images.githubusercontent.com/7598645/174724355-f855eed7-1cf2-4812-a4b2-4f050e7e7d0c.png">

### AndroidManifest.xml 權限申明
<img width="1189" alt="image" src="https://user-images.githubusercontent.com/7598645/174725213-f3c96661-5d32-4274-822c-d51110653bde.png">

### baseProjectTemplate 使用jitpack
<img width="1055" alt="image" src="https://user-images.githubusercontent.com/7598645/174725353-c0c19c54-c4bb-480e-9003-f3fc8fd4640a.png">

### launcherTemplate websdk gradle引用及其依賴庫
<img width="1127" alt="image" src="https://user-images.githubusercontent.com/7598645/174725546-a128d5a0-0e79-43e5-8e2b-35d9defb33d6.png">

### Unity 調用安卓aar代碼
<img width="1247" alt="image" src="https://user-images.githubusercontent.com/7598645/174725813-7da1cddc-7531-4282-95f2-5ee5cbf4a715.png">

```C#
        //初始化SDK
        LocNaviWebSDK.CallStatic("init", context, "lzDrdAv0y5");
        
        //设置服务器为海外URL，未设置默认URL为m.locnavi.com
        LocNaviWebSDK.CallStatic("setServerUrl", "https://mo.sailstech.com");

        //打開具體醫院
        LocNaviWebSDK.CallStatic("openMap", context, "m1tTIWHjsq");

        //打開具體醫院並引導至相應的Poi位置
        // LocNaviWebSDK.CallStatic("openMap", context, "m1tTIWHjsq", "poiId");

        //打開醫院列表
        // LocNaviWebSDK.CallStatic("openMapList", context);
```
