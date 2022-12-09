import sys
import random

class Sorter:
    def __init__(self) -> None:
        pass

    #'up', 'down', 'lenUp', 'lenDown', 'rand'

    def sort(self, data : list[str], sortMode : str) -> list[str]:
        match sortMode:
            case['up']:
                self.sortByCompare(data)
            case['down']:
                self.sortByCompare(data, True)
            case['lenUp']:
                self.sortByLen(data)
            case['lenDown']:
                self.sortByLen(data, True)
            case['rand']:
                self.sortByRandom(data)

    def sortByCompare(self, data : list[str], reverse = False) -> list[str]:
        for i in range(0, len(data)):
            for j in range(i + 1, len(data)):
                if (data[i] > data[j]):
                    data = replaceObjects(data, i, j)
                elif (data[i] < data [j] and reverse):
                    data = replaceObjects(data, i, j)
                    

    def sortByLen(self, data : list[str], reverse = False) -> list[str]:
        lenData = [len(row) for row in data]

        for i in range(0, len(data)):
            for j in range(i + 1, len(data)):
                if (lenData[i] > lenData[j]):
                    lenData = replaceObjects(lenData, i, j)
                    data = replaceObjects(data, i, j)
                elif (lenData[i] < lenData [j] and reverse):
                    lenData = replaceObjects(lenData, i, j)
                    data = replaceObjects(data, i, j)


    def sortByRandom(self, data : list[str]) -> list[str]:
        pass

def replaceObjects(data : list[str], indexI : int, indexJ : int) -> list[str]:
    tmp = data[indexI]
    data[indexI] = data[indexJ]
    data[indexJ] = tmp

    return data

    



