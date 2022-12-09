import sys
import random
from riker_moduls import reader
from riker_moduls import consoleWorker

#PC: & "C:/Program Files (x86)/Microsoft Visual Studio/Shared/Python39_64/python.exe" d:/myProgects/repLab/BMSTU_labs_sem_3/Lab7_First_Py/main.py -r Lab7_First_Py/Files/In.txt -w Lab7_First_Py/Files/Out.txt -s up
#Lap: & C:/Users/solom/AppData/Local/Programs/Python/Python311/python.exe d:/ForBMSTU/BMSTU_labs_sem_3/Lab7_First_Py/main.py

def test_reader_work() -> None:
    worker = reader.Reader()
    filePath = worker.create_empty_file("test")
    worker.write_in_file(filePath, ["File for test", "Yes, sure", "Created"])
    dataFromFile = worker.read_from_file(filePath)

    for line in dataFromFile:
        print(line)

def main() -> None:
    console = consoleWorker.ConsoleWorker()
    data = console.take_data_from_console()

    worker = reader.Reader()
    dataFromFile = worker.read_from_file(data.read)
    worker.write_in_file(data.write, dataFromFile)

if __name__ == '__main__':
    main()



