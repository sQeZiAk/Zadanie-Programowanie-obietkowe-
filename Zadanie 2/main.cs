using System;

class Program
{
    static void Main()
    {
        Console.Write("Wybierz kierunek konwersji (C -> F wpisz 'C', F -> C wpisz 'F'): ");
        string kierunek = Console.ReadLine();

        if (kierunek == "C")
        {
            Console.Write("Podaj temperaturę w °C: ");
            double c = double.Parse(Console.ReadLine());
            double f = c * 1.8 + 32;
            Console.WriteLine("Temperatura w °F: " + f);
        }
        else if (kierunek == "F")
        {
            Console.Write("Podaj temperaturę w °F: ");
            double f = double.Parse(Console.ReadLine());
            double c = (f - 32) / 1.8;
            Console.WriteLine("Temperatura w °C: " + c);
        }
        else
        {
            Console.WriteLine("Nieznany kierunek konwersji.");
        }
    }
}
