#define DLL_EXPORTS
#include <iostream>
#include <Windows.h>
#include "ConcoleLib.h"
using namespace std;

HANDLE g_hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
HANDLE g_hStdIn = GetStdHandle(STD_INPUT_HANDLE);


// ����������/������ ��������� ������
void __stdcall ShowCursor(bool visible)
{
	CONSOLE_CURSOR_INFO cci = { sizeof(cci), visible };
	SetConsoleCursorInfo(g_hStdOut, &cci);
}

// ������������� ���� �������� � ����
/*void __stdcall SetColor(ConsoleColor text, ConsoleColor background)
{
	SetConsoleTextAttribute(g_hStdOut, (WORD)((background << 4) | text));
}*/

// ���������� ������ � �������� �������
void __stdcall GotoXY(int X, int Y)
{
	COORD coord = { (SHORT)X, (SHORT)Y };
	SetConsoleCursorPosition(g_hStdOut, coord);
}

// ������� �������� ������ � �������� �������
void __stdcall WriteStr(int X, int Y, const char* Str)
{
	GotoXY(X, Y);
	cout << Str << flush;
}

// ������� �������� ������ ������� � �������� �������
void __stdcall WriteChar(int X, int Y, char Ch)
{
	GotoXY(X, Y);
	cout << Ch;
}

// ������� ��������� ���������� �������� �������� ������� � �������� �������
void __stdcall WriteChars(int X, int Y, char Ch, unsigned Len)
{
	GotoXY(X, Y);
	for (unsigned i = 0; i < Len; i++)
		cout << Ch;
}

// ������ ��������� ��������, ������� � �������� �������
/*void __stdcall ChangeTextAttr(int X, int Y, ConsoleColor text, ConsoleColor background, unsigned Len)
{
	COORD coord = { (SHORT)X, (SHORT)Y };
	DWORD dwDummy;
	FillConsoleOutputAttribute(g_hStdOut, (WORD)((background << 4) | text), Len, coord, &dwDummy);
}*/