from sys import argv as consoleData
from argparse import ArgumentParser

class ConsoleWorker:
    def __init__(self) -> None:
        self.parser = ArgumentParser()
        self.parser.add_argument('--read', '-r', default = 'Files/In.txt', required = True)
        self.parser.add_argument('--write', '-w', default = 'Files/Out.txt', required = True)
        self.parser.add_argument('--mode', '-m', default = 'up', choices = ['up', 'down', 'lenUp', 'lenDown', 'rand', 'randStr'], required = True)

    def take_data_from_console(self):
        args = self.parser.parse_args(consoleData[1:])
        print(args)
        return args



