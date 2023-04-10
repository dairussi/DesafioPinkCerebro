using System;

class minhaClasse
{

    static void Main(string[] args)
    {

        Console.WriteLine("Quantos números você quer testar?");
        int teste = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite os números:");
        string[] quantidade = Console.ReadLine().Split(" ");

        int multiplo2 = 0;
        int multiplo3 = 0;
        int multiplo4 = 0;
        int multiplo5 = 0;

        for (int i = 0; i < teste; i++)
        {
            int n = int.Parse(quantidade[i]);
            if (n % 2 == 0)
            {
                multiplo2 += 1;
            }
            if (n % 3 == 0)
            {
                multiplo3 += 1;
            }
            if (n % 4 == 0)
            {
                multiplo4 += 1;
            }
            if (n % 5 == 0)
            {
                multiplo5 += 1;
            }
        }

        Console.WriteLine($"{multiplo2} Multiplo(s) de 2");
        Console.WriteLine($"{multiplo3} Multiplo(s) de 3");
        Console.WriteLine($"{multiplo4} Multiplo(s) de 4");
        Console.WriteLine($"{multiplo5} Multiplo(s) de 5");
    }
}