from sys import argv as consoleData
from argparse import ArgumentParser

class ConsoleWorker:
    def __init__(self) -> None:
        self.parser = ArgumentParser()
        self.parser.add_argument('--read', '-r', required = True)
        self.parser.add_argument('--write', '-w', required = True)
        self.parser.add_argument('--mode', '-m', choices = ['up', 'down', 'lenUp', 'lenDown', 'rand'], required = True)

    def take_data_from_console(self) -> list[str]:
        args = self.parser.parse_args(consoleData[1:])
        print(args)
        return args



