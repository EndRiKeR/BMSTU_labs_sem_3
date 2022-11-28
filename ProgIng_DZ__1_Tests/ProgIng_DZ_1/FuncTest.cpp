#include "BinToSix.h"

#include "stdio.h"
#include "stdlib.h"
#include "string.h"
#include "locale.h"


int Test_ReadFromFile();
int Test_TranslateNumberSystem();
int Test_WriteInFile();

void WriteInFront(FILE* file, const char* str);
void ErrorCathed(int* counter, const char* str);


int main()
{
    setlocale(LC_ALL, "RUS");

    Test_ReadFromFile();
    Test_TranslateNumberSystem();
    Test_WriteInFile();

    return 0;
}

int Test_WriteInFile()
{
    int erCounter = 0;

    FILE* file = nullptr;

    int erFile = fopen_s(&file, "D:/myProgects/repLab/BMSTU_labs_sem_3/ProgIng_DZ__1_Tests/x64/Release/Files/Test3.txt", "w+");

    if (erFile != 0)
        return -1;

    printf("\nStart Test: WriteInFile\n\n");

    printf("Test Class: Only Number\n");
    if (WriteInFile(file, (char*)"2") != 1)
        ErrorCathed(&erCounter, "Func: WriteInFile, Class: Only Number");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Only Letter\n");
    if (WriteInFile(file, (char*)"D") != 1)
        ErrorCathed(&erCounter, "Func: WriteInFile, Class: Only Letter");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Number + Letter\n");
    if (WriteInFile(file, (char*)"1C") != 2)
        ErrorCathed(&erCounter, "Func: WriteInFile, Class: Number + Letter");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Letter + Number\n");
    if (WriteInFile(file, (char*)"F4") != 2)
        ErrorCathed(&erCounter, "Func: WriteInFile, Class: Letter + Number");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Number + Number\n");
    if (WriteInFile(file, (char*)"31") != 2)
        ErrorCathed(&erCounter, "Func: WriteInFile, Class: Number + Number");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Letter + Letter\n");
    if (WriteInFile(file, (char*)"FD") != 2)
        ErrorCathed(&erCounter, "Func: WriteInFile, Class: Letter + Letter");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Just classic translate\n");
    if (WriteInFile(file, (char*)"2E54D") != 5)
        ErrorCathed(&erCounter, "Func: WriteInFile, Class: Just classic translate");
    else
        printf("\tTest passed!\n");



    printf("\nEnd Test: WriteInFile\n\tTotal Errors: %d\n", erCounter);

}

int Test_TranslateNumberSystem()
{
    int erCounter = 0;

    char num16[100];
    num16[99] = '\0';

    printf("\nStart Test: TranslateNumberSystem\n\n");

    printf("Test Class: Only Number\n");
    TranslateNumberSystem((char*)"10", num16);
    if (strcmp(num16, "2") != 0)
        ErrorCathed(&erCounter, "Func: TranslateNumberSystem, Class: Only Number");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Only Letter\n");
    TranslateNumberSystem((char*)"1101", num16);
    if (strcmp(num16, "D") != 0)
        ErrorCathed(&erCounter, "Func: TranslateNumberSystem, Class: Only Letter");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Number + Letter\n");
    TranslateNumberSystem((char*)"11100", num16);
    if (strcmp(num16, "1C") != 0)
        ErrorCathed(&erCounter, "Func: TranslateNumberSystem, Class: Number + Letter");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Letter + Number\n");
    TranslateNumberSystem((char*)"11110100", num16);
    if (strcmp(num16, "F4") != 0)
        ErrorCathed(&erCounter, "Func: TranslateNumberSystem, Class: Letter + Number");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Number + Number\n");
    TranslateNumberSystem((char*)"110001", num16);
    if (strcmp(num16, "31") != 0)
        ErrorCathed(&erCounter, "Func: TranslateNumberSystem, Class: Number + Number");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Letter + Letter\n");
    TranslateNumberSystem((char*)"11111100", num16);
    if (strcmp(num16, "FC") != 0)
        ErrorCathed(&erCounter, "Func: TranslateNumberSystem, Class: Letter + Letter");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Just classic translate\n");
    TranslateNumberSystem((char*)"101110010101001101", num16);
    if (strcmp(num16, "2E54D") != 0)
        ErrorCathed(&erCounter, "Func: TranslateNumberSystem, Class: Just classic translate");
    else
        printf("\tTest passed!\n");



    printf("\nEnd Test: TranslateNumberSystem\n\tTotal Errors: %d\n", erCounter);

}

int Test_ReadFromFile()
{
    int erCounter = 0;
    FILE* file = NULL;

    int erFile = fopen_s(&file, "D:/myProgects/repLab/BMSTU_labs_sem_3/ProgIng_DZ__1_Tests/x64/Release/Files/Test2.txt", "w+");
    char string[100];
    string[99] = '\0';

    if (erFile != 0)
        return -1;
    int rc = 0;

    printf("\nStart Test: ReadFromFile\n\n");


    printf("Test Class: Symbol in binary\n");
    WriteInFront(file, "10а1001р1010");
    if (ReadFromFile(file, string) != -1)
        ErrorCathed(&erCounter, "Func: ReadFromFile, Class: Symbol in binary");
    else
        printf("\tTest passed!\n");


    printf("Test Class: Symbol \',\' in binary\n");
    WriteInFront(file, "1001001101101,1101100");
    if (ReadFromFile(file, string) != -1)
        ErrorCathed(&erCounter, "Func: ReadFromFile, Class: Symbol \',\' in binary");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Not binary in binary\n");
    WriteInFront(file, "5336633456");
    if (ReadFromFile(file, string) != -1)
        ErrorCathed(&erCounter, "Func: ReadFromFile, Class: Not binary in binary");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Space in binary\n");
    WriteInFront(file, "1010011011100  110100100");
    if (ReadFromFile(file, string) != -1)
        ErrorCathed(&erCounter, "Func: ReadFromFile, Class: Space in binary");
    else
        printf("\tTest passed!\n");

    printf("Test Class: Good binary 1\n");
    WriteInFront(file, "110001");
    if (ReadFromFile(file, string) != 0)
        ErrorCathed(&erCounter, "Func: ReadFromFile, Class: Good binary 1");
    else
        printf("\tTest passed!\n");

    printf("\nEnd Test: ReadFromFile\n\tTotal Errors: %d\n", erCounter);

}

void WriteInFront(FILE* file, const char* str)
{
    rewind(file);
    fprintf(file, "%s%c", str, '\n');
    rewind(file);
}

void ErrorCathed(int* counter, const char* str)
{
    printf("ERROR in %s%c", str, '\n');

    *counter += 1;
}
