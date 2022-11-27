#include "BinToSix.h"

#include "stdio.h"
#include "stdlib.h"
#include "string.h"
#include "locale.h"


int Test_ReadFromFile();
void WriteInFront(FILE* file, const char* str);
void ErrorCathed(int* counter, const char* str);


int main()
{
    setlocale(LC_ALL, "RUS");

    Test_ReadFromFile();

    return 0;
}

//int ReadFromFile(FILE*, char* num2);
//void TranslateNumberSystem(char* num2, char* num16);
//void WriteInFile(FILE* filePtr16, char* num16);

int Test_ReadFromFile()
{
    int erCounter = 0;
    FILE* file = NULL;

    int erFile = fopen_s(&file, "D:/ForBMSTU/BMSTU_labs_sem_3/ProgIng_DZ__1_Tests/x64/Release/Files/Test.txt", "w+");
    char string[100];
    string[99] = '\0';

    if (erFile != 0)
        return -1;

    WriteInFront(file, "10а1001р1010");
    if (ReadFromFile(file, string) != -1)
        ErrorCathed(&erCounter, "Func: ReadFromFile, Class: Symbol in binary");

    WriteInFront(file, "1001001101101,1101100");
    if (ReadFromFile(file, string) != -1)
        ErrorCathed(&erCounter, "Func: ReadFromFile, Class: Symbol \',\' in binary");

    WriteInFront(file, "5336633456");
    if (ReadFromFile(file, string) != -1)
        ErrorCathed(&erCounter, "Func: ReadFromFile, Class: Not binary in binary");

    WriteInFront(file, "1010011011100  110100100");
    if (ReadFromFile(file, string) != -1)
        ErrorCathed(&erCounter, "Func: ReadFromFile, Class: Space in binary");

    WriteInFront(file, "110001");
    if (ReadFromFile(file, string) != 0)
        ErrorCathed(&erCounter, "Func: ReadFromFile, Class: Good binary 1");


    
}

void WriteInFront(FILE* file, const char* str)
{
    rewind(file);
    fprintf(file, "%s %c", str, '\n');
}

void ErrorCathed(int* counter, const char* str)
{
    printf("%s %c", str, '\n');

    *counter += 1;
}
