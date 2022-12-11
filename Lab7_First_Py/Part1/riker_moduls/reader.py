class Reader:
    def __init__(self) -> None:
        self.dataFromFile = []

    def read_from_file(self, filePath : str) -> list[str]: #Вот тут я пытаюсь в строгую типизацию =)
        try:
            file = open(filePath, 'r')
            self.dataFromFile = [line.strip() for line in file]
            file.close()
        except Exception:
            return []
        return self.dataFromFile

    def write_in_file(self, filePath : str, data : list[str]) -> None:
        file = open(filePath, 'w')
        for line in data:
            file.write(line + '\n')
        file.close()

    def create_empty_file(self, fileName : str) -> str:
        filePath = f'Lab7_First_Py/Part1/Files/{fileName}.txt'
        file = open (filePath, 'w')
        file.close()
        return filePath









