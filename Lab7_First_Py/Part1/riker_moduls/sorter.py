import sys
import random

class Sorter:
    def __init__(self) -> None:
        pass

    def startSort(self, data : list[str], sortMode : str) -> list[str]:
        if sortMode == 'up':
            data = self.sortByCompare(data)
        elif sortMode == 'down':
            data = self.sortByCompare(data, True)
        elif sortMode == 'lenUp':
            data = self.sortByLen(data)
        elif sortMode == 'lenDown':
            data = self.sortByLen(data, True)
        elif sortMode == 'rand':
            data = self.sortByRandom(data)
        
        return data

    def sortByCompare(self, data : list[str], reverse = False) -> list[str]:
        for i in range(0, len(data)):
            for j in range(i + 1, len(data)):
                if (data[i] > data[j]):
                    data = replaceObjects(data, i, j)
                elif (data[i] < data [j] and reverse):
                    data = replaceObjects(data, i, j)

        return data
                    

    def sortByLen(self, data : list[str], reverse = False) -> list[str]:
        lenData = [len(row) for row in data]

        for i in range(0, len(lenData)):
            for j in range(i + 1, len(lenData)):
                if (lenData[i] > lenData[j] and not reverse):
                    lenData = replaceObjects(lenData, i, j)
                    data = replaceObjects(data, i, j)
                elif (lenData[i] < lenData [j] and reverse):
                    lenData = replaceObjects(lenData, i, j)
                    data = replaceObjects(data, i, j)

        return data


    def sortByRandom(self, data : list[str]) -> list[str]:
        rand = random.Random()
        rand.shuffle(data)

        return data



def replaceObjects(data : list[str], indexI : int, indexJ : int) -> list[str]:
    tmp = data[indexI]
    data[indexI] = data[indexJ]
    data[indexJ] = tmp

    return data

    



