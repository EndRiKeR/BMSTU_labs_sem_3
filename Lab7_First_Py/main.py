import sys
import random
from riker_moduls import reader
from riker_moduls import consoleWorker
from riker_moduls import sorter

#PC: & "C:/Program Files (x86)/Microsoft Visual Studio/Shared/Python39_64/python.exe" d:/myProgects/repLab/BMSTU_labs_sem_3/Lab7_First_Py/main.py -r Lab7_First_Py/Files/In.txt -w Lab7_First_Py/Files/Out.txt -s up
#Lap: & C:/Users/solom/AppData/Local/Programs/Python/Python311/python.exe d:/ForBMSTU/BMSTU_labs_sem_3/Lab7_First_Py/main.py

def test_reader_work() -> None:
    worker = reader.Reader()
    sortStr = sorter.Sorter()
    #filePath = worker.create_empty_file("test")
    #worker.write_in_file('Files/In.txt', ["File for test", "Yes, sure", "Created"])
    dataFromFile = worker.read_from_file('Files/In.txt')
    for line in dataFromFile:
        print(line)

    print('\n')

    sortStr.startSort(dataFromFile, 'lenDown')
    for line in dataFromFile:
        print(line)

def main() -> None:
    console = consoleWorker.ConsoleWorker()
    worker = reader.Reader()
    sortStr = sorter.Sorter()

    data = console.take_data_from_console()
    dataFromFile = worker.read_from_file(data.read)
    dataFromFile = sortStr.startSort(dataFromFile, data.mode)
    worker.write_in_file(data.write, dataFromFile)

if __name__ == '__main__':
    #main()
    test_reader_work()



