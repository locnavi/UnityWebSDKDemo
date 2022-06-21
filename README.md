# UnityWebSDKDemo
Unity 調用 webSDK的範例代碼，支持調用iOS、安卓SDK

## SDK 文檔

[iOS文檔](https://github.com/locnavi/locnavi-websdk-ios/blob/master/README.md)

[Android文檔](https://github.com/locnavi/IndoorNavigationAndroidWebSDK/blob/main/README.md)

## 獲取AppKey
appKey、mapId、targetName、targetId等信息請向 richard.chin@locnavi.com 申請

## iOS
在Assets/Plugins/iOS中放入LocNaviWebSDK.framework，通過修改同目錄下的LocNaviWebIOS文件調用SDK代碼。

### iOS 遇到的問題
#### Unity Building for iOS, but the embedded framework was built for iOS + iOS Simulator.
提供的framework是iOS真機和模擬器的集合，可以在Xcode中進行以下設置
<img width="853" alt="image" src="https://user-images.githubusercontent.com/7598645/174705417-34daef5c-4280-4eba-a6ac-c610c5f4c02c.png">


## Android
可參考AndroidManifest.xml、baseProjectTemplate.gradle、launcherTemplate.gradle的配置，編譯時會自動通過Gradle將需要的庫文件下載。
LocNaviWebSDKBridge.cs 中有關於iOS和Android的不同調用方法。
