//#import <Foundation/Foundation.h>
//
//@interface LocNaviWebIOS : NSObject {
//
//}
//
//@end

extern "C" {
void _test();
void setAppKey(const char* appKey);
void setUserId(const char* userId);
void setServerUrl(const char* url);
void showMapView(const char* mapId);
void setUploadLocationApi(const char* api, int timeInterval);
}
