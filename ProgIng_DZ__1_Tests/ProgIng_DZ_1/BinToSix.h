#pragma once

#include "stdio.h"
#include "stdlib.h"
#include "string.h"
#include "locale.h"
#define NDEBUG
#include "assert.h"

#pragma warning(disable : 4996)
//#define NUM2_SIZE 100;
//#define NUM16_SIZE 25;
#define _NO_CRT_STDIO_INLINE
#define _countof(array) (sizeof(array) / sizeof(array[0]))

int ReadFromFile(FILE*, char* num2);
void TranslateNumberSystem(char* num2, char* num16);
void WriteInFile(FILE* filePtr16, char* num16);
char FromDoubleToSixteen(const char* tetra);

int mainProgram(const char* inPtr, const char* outPtr);
