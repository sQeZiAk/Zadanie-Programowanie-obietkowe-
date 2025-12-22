using System;

public class Player
{
    public string Name { get; }
    public char Mark { get; }   

    public Player(string name, char mark)
    {
        Name = name;
        Mark = mark;
    }
}

public class Board
{
    private readonly char[] _cells = new char[9];

    public Board()
    {
        for (int i = 0; i < _cells.Length; i++)
            _cells[i] = ' ';
    }

    public void Display()
    {
        Console.WriteLine($"{_cells[0]}|{_cells[1]}|{_cells[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{_cells[3]}|{_cells[4]}|{_cells[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{_cells[6]}|{_cells[7]}|{_cells[8]}");
    }

    public bool MakeMove(int position, char mark)
    {
        if (position < 0 || position > 8) return false;
        if (_cells[position] != ' ') return false;

        _cells[position] = mark;
        return true;
    }

    public char? Winner()
    {
        int[,] wins =
        {
            {0,1,2}, {3,4,5}, {6,7,8},
            {0,3,6}, {1,4,7}, {2,5,8},
            {0,4,8}, {2,4,6}
        };

        for (int i = 0; i < wins.GetLength(0); i++)
        {
            int a = wins[i, 0], b = wins[i, 1], c = wins[i, 2];
            if (_cells[a] != ' ' &&
                _cells[a] == _cells[b] &&
                _cells[b] == _cells[c])
            {
                return _cells[a];
            }
        }

        return null;
    }

    public bool IsFull()
    {
        foreach (char c in _cells)
            if (c == ' ') return false;
        return true;
    }
}

public class Game
{
    private readonly Board _board;
    private Player _current;
    private Player _other;

    public Game(Player player1, Player player2)
    {
        _board = new Board();
        _current = player1;
        _other = player2;
    }

    private void SwitchPlayers()
    {
        var temp = _current;
        _current = _other;
        _other = temp;
    }

    public void Play()
    {
        Console.WriteLine("=== Gra: Kółko i krzyżyk ===");

        while (true)
        {
            Console.Clear();
            _board.Display();
            Console.Write($"{_current.Name} ({_current.Mark}), wybierz pole 0–8: ");

            if (!int.TryParse(Console.ReadLine(), out int move))
            {
                Console.WriteLine("Nieprawidłowy numer.");
                Console.ReadKey();
                continue;
            }

            if (!_board.MakeMove(move, _current.Mark))
            {
                Console.WriteLine("Ruch nieprawidłowy (poza zakresem lub pole zajęte).");
                Console.ReadKey();
                continue;
            }

            var winner = _board.Winner();
            if (winner.HasValue)
            {
                Console.Clear();
                _board.Display();
                Console.WriteLine($"Wygrał {_current.Name}!");
                break;
            }

            if (_board.IsFull())
            {
                Console.Clear();
                _board.Display();
                Console.WriteLine("Remis.");
                break;
            }

            SwitchPlayers();
        }

        Console.WriteLine("Koniec gry, naciśnij klawisz...");
        Console.ReadKey();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var p1 = new Player("Gracz 1", 'X');
        var p2 = new Player("Gracz 2", 'O');

        var game = new Game(p1, p2);
        game.Play();
    }
}
