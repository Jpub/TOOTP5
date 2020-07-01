#include <stdio.h>
#include <Foundation/Foundation.h>
@interface Number : NSObject 
{
	// Attributes
	int count;

}
// Method Signatures

- (void) method1;

@end

@implementation Number
// Method Implementations
- (void) method1;
{
	count = 1;
}
@end
int main(void)
{
	Number *number1 = [Number new];	
	Number *number2 = [Number new];
	Number *number3 = [Number new];

	return 0;
}
