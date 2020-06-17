#ifndef __CONSOLELIB_H__
#define __CONSOLELIB_H__

#ifdef DLL_EXPORTS
#define CONSOLELIB_DLL_API extern "C" __declspec(dllexport)
#else // DLL_EXPORTS
#define CONSOLELIB_DLL_API extern "C" __declspec(dllimport)
#endif
// ������ �������
CONSOLELIB_DLL_API extern HANDLE g_hStdOut;
CONSOLELIB_DLL_API extern HANDLE g_hStdIn;

// �����
/*enum ConsoleColor
{
	Black = 0,
	Blue = 1,
	Green = 2,
	Cyan = 3,
	Red = 4,
	Magenta = 5,
	Brown = 6,
	LightGray = 7,
	DarkGray = 8,
	LightBlue = 9,
	LightGreen = 10,
	LightCyan = 11,
	LightRed = 12,
	LightMagenta = 13,
	Yellow = 14,
	White = 15
};*/

// ����������/������ ��������� ������

// ������������� ���� �������� � ����
//CONSOLELIB_DLL_API void __stdcall SetColor(ConsoleColor text, ConsoleColor background);

// ���������� ������ � �������� �������
CONSOLELIB_DLL_API void __stdcall GotoXY(int X, int Y);

// ������� �������� ������ � �������� �������
CONSOLELIB_DLL_API void __stdcall WriteStr(int X, int Y, const char* Str);

// ������� �������� ������ ������� � �������� �������
CONSOLELIB_DLL_API void __stdcall WriteChar(int X, int Y, char Ch);

// ������� ��������� ���������� �������� �������� ������� � �������� �������
CONSOLELIB_DLL_API void __stdcall WriteChars(int X, int Y, char Ch, unsigned Len);

// ������ ��������� ��������, ������� � �������� �������
//CONSOLELIB_DLL_API void __stdcall ChangeTextAttr(int X, int Y, ConsoleColor text, ConsoleColor background, unsigned Len);

#endif // __CONSOLELIB_H__

