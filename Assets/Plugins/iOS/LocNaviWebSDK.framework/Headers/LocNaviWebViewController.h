//
//  LocNaviWebViewController.h
//  LocNaviWebSDK
//
//  Created by zhangty on 2020/7/3.
//  Copyright © 2020 locnavi. All rights reserved.
//

#import <UIKit/UIKit.h>
#import <WebKit/WebKit.h>
#import "LocNaviLocation.h"

NS_ASSUME_NONNULL_BEGIN

typedef void (^LNLocationBlcok)(LocNaviLocation * _Nullable location, NSError * _Nullable error);

@interface LocNaviWebViewController : UIViewController

@property (nonatomic, strong) WKWebView *webView;

- (nonnull instancetype)initWithMapId:(nullable NSString *)mapId;

- (nonnull instancetype)initWithMapId:(nonnull NSString *)mapId poi:(nonnull NSString*)poiId;

//获取当前定位数据
- (void)getLocation:(_Nullable LNLocationBlcok)handler;
//持续获取当前定位数据
- (void)startListenLocation:(_Nullable LNLocationBlcok)handler;
//停止获取获取当前定位数据
- (void)stopListenLocation;

@end

NS_ASSUME_NONNULL_END
