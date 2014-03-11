#include "stdafx.h"

//Άλφα Álpha

extern "C" __declspec(dllexport) unsigned int GetStringLengthW(const wchar_t* str) {
	/*unsigned int ret = 0;
	while (*str++)
		++ret;
	return ret;*/
	return wcslen(str);
}

extern "C" __declspec(dllexport) unsigned int GetStringLengthA(const char* str) {
	return strlen(str);
}

