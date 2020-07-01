#include <stdio.h>
#include <Foundation/Foundation.h>

// Shape Protocol
@protocol Shape

@required
- (void) draw;

@end // Shape

//**** Circle Class
@interface Circle : NSObject <Shape>
{
	// No Attributes
}
// Method Signatures (No Constructor)

@end

@implementation Circle
- (void) draw;
{
	printf("%s\n", "I am drawing a Circle");
}

@end // Circle

//**** Rectangle Class (Rectangle is a reserved word, using Rtangle)
@interface Rtangle : NSObject <Shape>
{
	// No Attributes
}
// Method Signatures (No Constructor)

@end

@implementation Rtangle
- (void) draw;
{
	printf("%s\n", "I am drawing a Rectangle");
}

@end // Rectangle

//**** Star Class
@interface Star : NSObject <Shape>
{
	// No Attributes
}
// Method Signatures (No Constructor)

@end

@implementation Star
- (void) draw;
{
	printf("%s\n", "I am drawing a Star");
}

@end // Star

//**** Triangle Class
@interface Triangle : NSObject <Shape>
{
	// No Attributes
}
// Method Signatures (No Constructor)

@end

@implementation Triangle
- (void) draw;
{
	printf("%s\n", "I am drawing a Triangle");
}

@end // Triangle


// Main Program
int main(void)
{

	Circle *circle = [[Circle new] init];
	[circle draw];

	Rtangle *rectangle = [[Rtangle new] init];
	[rectangle draw];

	Star *star = [[Star new] init];
	[star draw];

	Triangle *triangle = [[Triangle new] init];
	[triangle draw];

	return 0;
}
