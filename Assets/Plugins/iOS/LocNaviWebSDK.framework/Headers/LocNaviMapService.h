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

+ (nonnull instancetype)sharedInstance;

+ (void)setAppKey:(nonnull NSString *)appKey;

+ (void)setUserId:(nonnull NSString *)userId;

@end

NS_ASSUME_NONNULL_END
