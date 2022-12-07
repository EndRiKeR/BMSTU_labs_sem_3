// ConsoleApplication1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <stdlib.h>
#include <string.h>

int getArray(int* arr, int arrSize);

int main()
{
    int arr[10];
    int arrSize = 10;

    getArray(arr, arrSize);
}

int getArray(int* arr, int arrSize)
{
    int rc = 0;
    char inBuff[50];
    int buff;
    arr = (int*)malloc(sizeof(int) * arrSize);
    for (int i = 0; i < arrSize; i++) {
        printf("Введите %d символ", i);
        scanf_s("%s", inBuff, 49);
        printf("%s", inBuff);
        if (inBuff == "0") {
            arr[i] = 0;
        }
        else {
            buff = atoi(inBuff);
            if (!buff) {
                rc = 1;
                break;
            }
            else {
                arr[i] = buff;
            }
        }
    }
    return rc;
}

