#include "BinToSix.h"

int main2()
{
    setlocale(LC_ALL, "RUS");

    char inPtr[100];
    char outPtr[100];
    printf("In: ");
    scanf("%s", inPtr);
    printf("Out: ");
    scanf("%s", outPtr);

    mainProgram(inPtr, outPtr);

    return 0;
}

int mainProgram(const char* _inFilePath, const char* _outFilePath)
{
    printf("Start program.\n");
    const int NUM2SIZE = 101;
    const int NUM16SIZE = 26;

    char num2[NUM2SIZE];
    char num16[NUM16SIZE];

    int i = 0;
    int rc = 0;
    int addRc = 0;

    FILE* filePtr2 = NULL;
    FILE* filePtr16 = NULL;

    num2[100] = '\0';
    num16[25] = '\0';

    printf("Open files\n");
    rc = fopen_s(&filePtr2, _inFilePath, "r");
    addRc = fopen_s(&filePtr16, _outFilePath, "w");
    if (rc != 0 || addRc != 0)
    {
        printf("Error! Can't open file.\n");
    }
    else
    {
        char ch = fgetc(filePtr2);

        if (feof(filePtr2)) {
            rc = -1;
            printf("Error! Empty file.\n");
        }
        else
        {
            rewind(filePtr2);
        }

        printf("Start reading.\n");
        while (!feof(filePtr2))
        {
            if (i > 10) {
                rc = -1;
                printf("Error! File has more then 10 rows.\n");
                break;
            }
            else
            {
                i += 1;
                rc = ReadFromFile(filePtr2, num2);
                //printf("Debug Log: Read String = %s;\n", num2);

                if (rc != 0) {
                    rc = -1;
                    printf("Error! Uncorrect data!\n");
                    break;
                }

                TranslateNumberSystem(num2, num16);

                //printf("Debug Log: Translate String = %s;\n", num16);
                WriteInFile(filePtr16, num16);
            }
        }

        printf("Close files.\n");
        fclose(filePtr2);
        fclose(filePtr16);

        if (rc == 0)
            printf("Program end correct!\n");
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

    if (mod == 0)
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

int WriteInFile(FILE* filePtr16, char* num16)
{

    assert(filePtr16);
    assert(num16);

    return fprintf(filePtr16, "%s %c", num16, '\n') - 2;
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
