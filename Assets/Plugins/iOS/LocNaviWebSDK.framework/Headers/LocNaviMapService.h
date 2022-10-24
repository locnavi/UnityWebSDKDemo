//
//  LocNaviMapService.h
//  LocNaviWebSDK
//
//  Created by zhangty on 2020/7/3.
//  Copyright © 2020 locnavi. All rights reserved.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface LocNaviMapService : NSObject

@property (nonatomic, readonly)NSString * _Nullable appKey;
@property (nonatomic, readonly)NSString * _Nullable userId;
@property (nonatomic, readonly)NSString * _Nullable serverUrl;
@property (nonatomic, readonly)NSString * _Nullable uploadApi;
@property (nonatomic, readonly)int uploadTimeInterval;

+ (nonnull instancetype)sharedInstance;

+ (void)setAppKey:(nonnull NSString *)appKey;

+ (void)setUserId:(nonnull NSString *)userId;

+ (void)setServerUrl:(nonnull NSString *)url;

//设置自动上传定位, 间隔最短1000毫秒一次。需要设置userId才能生效
+ (void)setUploadLocationApi:(nonnull NSString *)api timeInterval:(int)time;

@end

NS_ASSUME_NONNULL_END
