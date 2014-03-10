#include "stdafx.h"
#include <string>
using std::string;


class MyNativeClass
{
public:
	MyNativeClass(const string& name)
		: _name(name)
	{
		// mmmh, nothing here..
	}

	string getName() {
		return _name;
	}

private:
	string _name;
};

extern "C" __declspec(dllexport) HANDLE NativeClass_New(
	const char* name
){
	return new MyNativeClass{ name };
}

extern "C" __declspec(dllexport) void NativeClass_Delete(
	HANDLE hInstance
){
	delete ((MyNativeClass *)hInstance);
}

extern "C" __declspec(dllexport) int NativeClass_GetName(
	HANDLE       hInstance,
	char        *buffer,
	unsigned int bufferSize
){
	string name = ((MyNativeClass *)hInstance)->getName();
	OutputDebugStringA(("\nNativeClass_GetName: " + name).c_str());

	if (bufferSize < name.length()+1) {
		OutputDebugStringA("\n\tNativeClass_GetName: Buffer too small");
		return 0;
	}

	strcpy(buffer, name.c_str());
	return 1;
}
