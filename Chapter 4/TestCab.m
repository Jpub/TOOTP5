#include <stdio.h>
#include <Foundation/Foundation.h>

// Cab Class
@interface Cab : NSObject 
{
	// Attributes
	char * serialNumber;

}
// Method Signatures

- (Cab *) init: (char *) sn;

@end
@implementation Cab
// Method Implementations
- (Cab *) init: (char *) sn;
{
	self = [super init]; 

	if (self) {
		serialNumber = sn;
	}

	return self;
}
@end 

// Cabbie Class
@interface Cabbie : NSObject 
{
	// Attributes
	char * strName;
	Cab * myCab;

}
// Method Signatures

- (Cabbie *) init;
- (Cabbie *) init: (int) a;
//- (Cabbie *) init: (char *) iName :(char *) serialNumber;

@end
@implementation Cabbie
// Method Implementations
- (Cabbie *) init;
{
	self = [super init];

	if (self) {
		strName = NULL;
		myCab = NULL;
	}
	printf("%s\n", "Inside Constructor");
	return self;
}

- (Cabbie *) init: (int) a;
{
	self = [super init];

	if (self) {

	}
	printf("%s\n", "Inside 2nd Constructor");
	return self;
}

@end

// TestCab
int main(void)
{

	Cabbie *joe = [[Cabbie new] init: 5];

	return 0;
}

