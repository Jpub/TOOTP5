#include <stdio.h>
#include <Foundation/Foundation.h>
@interface CustomerList : NSObject 
{
	// Attributes
	char * name;
}
// Method Signatures
- (const char *) findCust;
- (void) addCust: (char *) n;
@end
@implementation Person
// Method Implementations
- (const char *) findCust;
{
	return name;
}
- (void) addCust: (char *) n;
{
	name = n;
}
@end

