#include <stdio.h>
#include <Foundation/Foundation.h>

// Shape Protocol
@protocol Shape

@required
double area;
- (double) getArea;

@end // Shape

// Circle Class
@interface Circle : NSObject <Shape>
{
	double radius;

}
// Method Signatures
- (Circle *) init: (double) n;

@end

@implementation Circle
- (Circle *) init: (double) n;
{
	self = [super init];

	if (self) {
		radius = n;
	}

	return self;
}

- (double) getArea;
{
	area = 3.14*(radius*radius);
	return area;
}

@end // Circle

// Rectangle Class
@interface Rtangle : NSObject <Shape>
{
	double length;
	double width;

}
// Method Signatures
//-(MyClass*) set:(int) a andb:(int) b;

- (Rtangle *) init: (double) l init: (double) w;

@end

@implementation Rtangle
- (Rtangle *) init: (double) l init: (double) w;
{
	self = [super init];

	if (self) {
		length = l;
		width = w;
	}

	return self;
}

- (double) getArea;
{
	area = length*width;
	return area;
}

@end // Rectangle

// Main Program
int main(void)
{

	Circle *circle = [[Circle new] init: 5];

	printf("%f\n", [circle getArea]);

	Rtangle *rtangle = [[Rtangle new] init: 2 init: 3];

	printf("%f\n", [rtangle getArea]);

	return 0;
}
