//
//  LocNaviWebViewController.h
//  LocNaviWebSDK
//
//  Created by zhangty on 2020/7/3.
//  Copyright © 2020 locnavi. All rights reserved.
//

#import <UIKit/UIKit.h>
#import <WebKit/WebKit.h>

NS_ASSUME_NONNULL_BEGIN

@interface LocNaviWebViewController : UIViewController

@property (nonatomic, strong) WKWebView *webView;

- (nonnull instancetype)initWithMapId:(nullable NSString *)mapId;

@end

NS_ASSUME_NONNULL_END
