using System;

class Program
{
    static void Main()
    {
        Console.Write("Ile ocen wprowadzić? ");
        int n = int.Parse(Console.ReadLine());

        double suma = 0.0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Podaj ocenę {i + 1}: ");
            double ocena = double.Parse(Console.ReadLine());
            suma += ocena;
        }

        double srednia = suma / n;
        Console.WriteLine("Średnia ocen: " + srednia);

        if (srednia >= 3.0)
        {
            Console.WriteLine("Uczeń zaliczył przedmiot.");
        }
        else
        {
            Console.WriteLine("Uczeń nie zaliczył przedmiotu.");
        }
    }
}
