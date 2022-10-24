#import "LocNaviWebIOS.h"
#import <UIKit/UIKit.h>
#import <LocNaviWebSDK/LocNaviWebSDK.h>

//@implementation LocNaviWebIOS
//
//- (void)_test {
//  NSLog(@"--------test");
//}
//
//@end

extern "C" {
void _test() {
    [LocNaviMapService setAppKey:@"nqB6HPIU2C"];
    //设置服务器地址
    // [LocNaviMapService setServerUrl:@"https://www.test.com"];

    LocNaviWebViewController *vc = [[LocNaviWebViewController alloc] initWithMapId:@"HHrzBwF5dY"];
    vc.modalPresentationStyle = UIModalPresentationFullScreen;
    UIViewController *rootVC = [[UIApplication sharedApplication].keyWindow rootViewController];
    [rootVC presentViewController:vc animated:YES completion:nil];
}
    void setAppKey(const char* appKey) {
        if (!appKey) {
            NSLog(@"appKey 不能为空");
            return;
        }
        //初始化SDK
        NSString *str = [[NSString alloc] initWithCString:appKey encoding:NSUTF8StringEncoding];
        [LocNaviMapService setAppKey:str];
    }
    void setUserId(const char* userId) {

        
    }

    void setServerUrl(const char* url) {
        if (!url) {
            NSLog(@"url 不能为空");
            return;
        }
        //初始化SDK
        NSString *str = [[NSString alloc] initWithCString:url encoding:NSUTF8StringEncoding];
        [LocNaviMapService setServerUrl:str];
    }
    void showMapView(const char* mapId) {
        if (!mapId) {
            NSLog(@"mapId 不能为空");
            return;
        }
        //初始化SDK
        NSString *str = [[NSString alloc] initWithCString:mapId encoding:NSUTF8StringEncoding];
        LocNaviWebViewController *vc = [[LocNaviWebViewController alloc] initWithMapId:str];
        vc.modalPresentationStyle = UIModalPresentationFullScreen;
        UIViewController *rootVC = [[UIApplication sharedApplication].keyWindow rootViewController];
        [rootVC presentViewController:vc animated:YES completion:nil];
}

    
}
