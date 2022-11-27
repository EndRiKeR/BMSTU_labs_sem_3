#include "stdio.h"
#include "stdlib.h"
#include "string.h"
#include "locale.h"
#include "assert.h"

#pragma warning(disable : 4996)
//#define NUM2_SIZE 100
//#define NUM16_SIZE 25
#define _NO_CRT_STDIO_INLINE
#define _countof(array) (sizeof(array) / sizeof(array[0]))

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

    //PC path
    //const char* _inFilePath = "D:/myProgects/repLab/BMSTU_labs_sem_3/ProgIng_DZ_1/ProgIng_DZ_1/In2.txt";
    //const char* _outFilePath = "D:/myProgects/repLab/BMSTU_labs_sem_3/ProgIng_DZ_1/ProgIng_DZ_1/Out16.txt";

    //Laptop path
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
                rc = ReadFromFile(filePtr2, num2);
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

int ReadFromFile(FILE* filePtr2, char* num2)
{
    assert(filePtr2);
    assert(num2);

    int rc = 0;
    int i = 0;
    int takenData = fscanf(filePtr2, "%[^\n]%*c", num2);
    int len = strlen(num2);
    num2[len] = '\0';

    if (takenData == -1)
        rc = -1;

    while (i < len && rc == 0)
    {
        if (num2[i] == '0' || num2[i] == '1')
        {
            ++i;
        }
        else
        {
            rc = -1;
            break;
        }
    }
    return rc;
}

//не сходится с псевдокодом
void TranslateNumberSystem(char* num2, char* num16) 
{
    assert(num2);
    assert(num16);

    int mod = strlen(num2) % 4;
    char tmp[101];
    char result[26];

    tmp[100] = '\0';
    result[25] = '\0';
    
    if (mod == 0) //вынести добавление
        mod = 4;

    for (int i = 0; i < (4 - mod); ++i) {
        *(tmp + i) = '0';
    }
    strcpy(tmp + (4 - mod), num2);

    assert(strlen(tmp) % 4 == 0);

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

    assert(filePtr16);
    assert(num16);

    fprintf(filePtr16, "%s %c", num16, '\n');
}

char FromDoubleToSixteen(const char* tetra)
{
    assert(strlen(tetra) >= 4);

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
