/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
        Console.Write("Podaj pierwszą liczbę");
        double liczba1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Podaj drugą liczbę");
        double liczba2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Podaj operację którą chcesz wykonać (+, -, *, /): ");
        string operacja = Console.ReadLine();
        
        double wynik = 0;
            
        if(operacja == "+")
        {
            wynik = liczba1 + liczba2;
            Console.WriteLine("Wynik: " + wynik);
        }
        
        else if(operacja == "-")
        {
            wynik = liczba1 - liczba2;
            Console.WriteLine("wynik: " + wynik);
        }
        else if(operacja == "*")
        {
            wynik = liczba1 * liczba2;
            Console.WriteLine("wynik:" + wynik);
        }
       else if(operacja == "/")
       {
           wynik = liczba1 % liczba2;
           Console.WriteLine("wynik: " + wynik);
       }
  }
}