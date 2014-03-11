#include "stdafx.h"
#include <string>

#ifdef _MSC_VER
# define snprintf _snprintf 
#endif

struct MyNativeStruct
{
	int  integer;
	char name[128];
};

extern "C" __declspec(dllexport) BOOL NativeStruct_Serialize1(
	MyNativeStruct  *hInstance,
	char            *buffer,
	unsigned int     bufferSize)
{
	int len = snprintf(buffer, bufferSize, "Integer=%d\r\nName=%s\r\nStruct Size=%ld",
	                   hInstance->integer, hInstance->name, sizeof(*hInstance));

	hInstance->integer *= 10;

	if (len >= bufferSize || len < 0)
	{
		::SetLastError(ERROR_INSUFFICIENT_BUFFER);
		return FALSE;
	}

	return TRUE;
}

extern "C" __declspec(dllexport) BOOL NativeStruct_Serialize2(
	MyNativeStruct  instance,
	char           *buffer,
	unsigned int    bufferSize)
{
	return NativeStruct_Serialize1(&instance, buffer, bufferSize);
}

