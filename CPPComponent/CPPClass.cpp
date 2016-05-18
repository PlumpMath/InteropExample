#include "pch.h"
#include "CPPClass.h"
#include <stdlib.h>     /* rand */
#include <time.h>       /* time */

using namespace CPPComponent;
using namespace Platform;

CPPClass::CPPClass()
{
}

int CPPClass::GetRandomNumber() 
{
	return rand() % 100 + 1;
}

int CPPClass::GetTime() 
{
	time_t timer;	
	return time(&timer); 
}
