class Player:
    def __init__(self, name, mark):
        self.name = name
        self.mark = mark  


class Board:
    def __init__(self):
        self.cells = [" "] * 9 

    def display(self):
        print(f"{self.cells[0]}|{self.cells[1]}|{self.cells[2]}")
        print("-+-+-")
        print(f"{self.cells[3]}|{self.cells[4]}|{self.cells[5]}")
        print("-+-+-")
        print(f"{self.cells[6]}|{self.cells[7]}|{self.cells[8]}")

    def make_move(self, position, mark):
        if self.cells[position] == " ":
            self.cells[position] = mark
            return True
        return False

    def winner(self):
        wins = [
            (0, 1, 2), (3, 4, 5), (6, 7, 8),
            (0, 3, 6), (1, 4, 7), (2, 5, 8),
            (0, 4, 8), (2, 4, 6),
        ]
        for a, b, c in wins:
            if self.cells[a] != " " and self.cells[a] == self.cells[b] == self.cells[c]:
                return self.cells[a]
        return None

    def is_full(self):
        return " " not in self.cells


class Game:
    def __init__(self, player1, player2):
        self.board = Board()
        self.current = player1
        self.other = player2

    def switch_players(self):
        self.current, self.other = self.other, self.current

    def play(self):
        while True:
            self.board.display()
            move = int(input(f"{self.current.name} ({self.current.mark}), wybierz pole 0–8: "))
            if not 0 <= move <= 8:
                print("Nieprawidłowy numer pola.")
                continue
            if not self.board.make_move(move, self.current.mark):
                print("Pole zajęte.")
                continue

            winner = self.board.winner()
            if winner:
                self.board.display()
                print(f"Wygrał {self.current.name}!")
                break
            if self.board.is_full():
                self.board.display()
                print("Remis.")
                break
            self.switch_players()


if __name__ == "__main__":
    p1 = Player("Gracz 1", "X")
    p2 = Player("Gracz 2", "O")
    game = Game(p1, p2)
    game.play()
