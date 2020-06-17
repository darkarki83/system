#ifndef __CONSOLELIB_H__
#define __CONSOLELIB_H__

#ifdef DLL_EXPORTS
#define CONSOLELIB_DLL_API extern "C" __declspec(dllexport)
#else // DLL_EXPORTS
#define CONSOLELIB_DLL_API extern "C" __declspec(dllimport)
#endif
// Хендлы консоли
CONSOLELIB_DLL_API extern HANDLE g_hStdOut;
CONSOLELIB_DLL_API extern HANDLE g_hStdIn;

// Цвета
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

// Показываем/прячем текстовый курсор

// Устанавливает цвет символов и фона
//CONSOLELIB_DLL_API void __stdcall SetColor(ConsoleColor text, ConsoleColor background);

// Перемещает курсор в заданную позицию
CONSOLELIB_DLL_API void __stdcall GotoXY(int X, int Y);

// Выводит заданную строку в заданную позицию
CONSOLELIB_DLL_API void __stdcall WriteStr(int X, int Y, const char* Str);

// Выводит заданный символ начиная с заданной позиции
CONSOLELIB_DLL_API void __stdcall WriteChar(int X, int Y, char Ch);

// Выводит указанное количество заданных символов начиная с заданной позиции
CONSOLELIB_DLL_API void __stdcall WriteChars(int X, int Y, char Ch, unsigned Len);

// Меняет текстовые атрибуты, начиная с заданной позиции
//CONSOLELIB_DLL_API void __stdcall ChangeTextAttr(int X, int Y, ConsoleColor text, ConsoleColor background, unsigned Len);

#endif // __CONSOLELIB_H__

