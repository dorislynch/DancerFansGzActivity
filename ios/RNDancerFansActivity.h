#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNDancerFansActivity : UIResponder

+ (instancetype)dancerFansActivity_shared;
- (BOOL)dancerFansActivity_joinThisWay:(void (^ __nullable)(void))changeVcBlock;
- (UIInterfaceOrientationMask)dancerFansActivity_getOrientation;
- (UIViewController *)dancerFansActivity_throughMainController:(UIApplication *)application withOptions:(NSDictionary *)launchOptions;

@end

NS_ASSUME_NONNULL_END
