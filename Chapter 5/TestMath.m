#include <stdio.h>
#include <Foundation/Foundation.h>
@interface Math : NSObject 
{
	// Attributes

}
// Method Signatures


- (int) swap: (int) a: (int) b;

@end

@implementation Math
// Method Implementations
- (int) swap: (int) a: (int) b;
{

	int temp=0;

	temp=a;
	a=b;
	b=temp;

	return temp;

}
@end
int main(void)
{

	int val=0;

	Math *myMath = [Math new];

	val =[myMath swap: 2 : 3];

	printf("The value is %d\n", val);

	return 0;
}
