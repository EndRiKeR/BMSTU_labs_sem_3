﻿#include "stdio.h"
#include "stdlib.h"
#include "string.h"
#include "locale.h"
#pragma warning(disable : 4996)
//#define NUM2_SIZE 100;
//#define NUM16_SIZE 25;

int ReadFromFile(FILE*, char* num2);
void TranslateNumberSystem(char* num2, char* num16);
void WriteInFile(FILE* filePtr16, char* num16);
char FromDoubleToSixteen(const char* tetra);

int ReadFromFileTmp(FILE* filePtr2, char* num2);

int main()
{
    setlocale(LC_ALL, "RUS");

    printf("Программа запущена.\n");
    const int NUM2SIZE = 101;
    const int NUM16SIZE = 26;

    char num2[NUM2SIZE];
    char num16[NUM16SIZE];
    int i = 0;
    int rc = 0;
    int addRc = 0;

    const char* _inFilePath = "D:/ForBMSTU/BMSTU_labs_sem_3/ProgIng_DZ_1/ProgIng_DZ_1/In2.txt";
    const char* _outFilePath = "D:/ForBMSTU/BMSTU_labs_sem_3/ProgIng_DZ_1/ProgIng_DZ_1/Out16.txt";

    FILE* filePtr2 = NULL;
    FILE* filePtr16 = NULL;

    num2[100] = '\0';
    num16[25] = '\0';

    printf("Открытие файлов\n");
    rc = fopen_s(&filePtr2, _inFilePath, "r");
    addRc = fopen_s(&filePtr16, _outFilePath, "w");
    if (rc != 0 || addRc != 0)
    {
        if (addRc != 0)
            fclose(filePtr16);

        printf("Ошибка! Не удалось открыть файл.\n");
    }
    else
    {
        char ch = fgetc(filePtr2);

        if (feof(filePtr2)) {
            rc = -1;
            printf("Ошибка! Подан пустой файл.\n");
        }
        else
        {
            rewind(filePtr2);
        }

        printf("Началось чтение.\n");
        while (!feof(filePtr2))
        {
            if (i > 10) {
                rc = -1;
                printf("Ошибка! Размер файла превышает 10 строк.\n");
                break;
            }
            else
            {
                i += 1;
                rc = ReadFromFileTmp(filePtr2, num2);
                printf("Debug Log: Read String = %s;\n", num2);

                if (rc != 0) {
                    rc = -1;
                    printf("Ошибка! Некорректный формат данных\n");
                    break;
                }

                TranslateNumberSystem(num2, num16);

                printf("Debug Log: Translate String = %s;\n", num16);
                WriteInFile(filePtr16, num16);
            }
        }

        printf("Закрытие файлов.\n");
        fclose(filePtr2);
        fclose(filePtr16);

        if (rc == 0)
            printf("Программа успешно завершила работу!\n");
    }
}
//"%[^\n]"

int ReadFromFileTmp(FILE* filePtr2, char* num2)
{

    //TODO:: Сделать построчно
    int rc = 0;
    int i = 0;
    rc = fscanf_s(filePtr2, "%s[^\n]", num2);

    printf("%s", num2);
    return rc;
}

int ReadFromFile(FILE* filePtr2, char* num2)
{
    char ch = fgetc(filePtr2);
    int index = 0;
    int rc = 0;

    while (ch != '\n')
    {
        if (ch != '1' && ch != '0')
        {
            rc = -1;
            break;
        }

        *(num2 + index) = ch;

        if (index >= 100)
        {
            rc = -1;
            break;
        }

        index += 1;
        ch = fgetc(filePtr2);

        if (feof(filePtr2))
        {
            break;
        }
    }

    if (index == 0)
    {
        rc = -1;
    }

    if (index <= 100)
    {
        *(num2 + index) = '\0';
    }

    return rc;
}

void TranslateNumberSystem(char* num2, char* num16)
{
    int mod = strlen(num2) % 4;
    char tmp[101];
    char result[26];

    tmp[100] = '\0';
    result[25] = '\0';
      
    for (int i = 0; i < mod; ++i) {
        *(tmp + i) = '0';
    }
    strcpy(tmp + mod, num2);

    int div = strlen(tmp) / 4;

    for (int i = 0; i < div; ++i) {
        *(result + i) = FromDoubleToSixteen(tmp);
        strcpy(tmp, tmp + 4);

        if (i == (div - 1))
            *(result + i + 1) = '\0';
    }

    strcpy(num16, result);
}

void WriteInFile(FILE* filePtr16, char* num16)
{
    fprintf(filePtr16, "%s %c", num16, '\n');
}

char FromDoubleToSixteen(const char* tetra)
{
    char res = ' ';

    if (tetra[0] == '0')
    {
        if (tetra[1] == '0')
        {
            if (tetra[2] == '0')
            {
                if (tetra[3] == '0')
                {
                    res = '0';
                }
                else
                {
                    res = '1';
                }
            }
            else
            {
                if (tetra[3] == '0')
                {
                    res = '2';
                }
                else
                {
                    res = '3';
                }
            }
        }
        else
        {
            if (tetra[2] == '0')
            {
                if (tetra[3] == '0')
                {
                    res = '4';
                }
                else
                {
                    res = '5';
                }
            }
            else
            {
                if (tetra[3] == '0')
                {
                    res = '6';
                }
                else
                {
                    res = '7';
                }
            }
        }
    }
    else
    {
        if (tetra[1] == '0')
        {
            if (tetra[2] == '0')
            {
                if (tetra[3] == '0')
                {
                    res = '8';
                }
                else
                {
                    res = '9';
                }
            }
            else
            {
                if (tetra[3] == '0')
                {
                    res = 'A';
                }
                else
                {
                    res = 'B';
                }
            }
        }
        else
        {
            if (tetra[2] == '0')
            {
                if (tetra[3] == '0')
                {
                    res = 'C';
                }
                else
                {
                    res = 'D';
                }
            }
            else
            {
                if (tetra[3] == '0')
                {
                    res = 'E';
                }
                else
                {
                    res = 'F';
                }
            }
        }
    }

    return res;
}
