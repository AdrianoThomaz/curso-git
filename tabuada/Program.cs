using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sinal;

            Console.WriteLine("Qual a tabuada? ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("(1= Multiplicação)");
            Console.WriteLine("(2= Divisão)");
            Console.WriteLine("(3= Soma)");
            Console.WriteLine("(4= Subtração)");
            Console.WriteLine();
            Console.WriteLine("Qual a operação? ");
            sinal = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada de {x}");
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                switch (sinal)
                {
                    case 1:
                        Console.WriteLine(x + $" * {i} = " + (x * i));
                        break;
                    case 2:
                        Console.WriteLine((x * i) + $" / {x} = " + i);
                        break;
                    case 3:
                        Console.WriteLine(x + $" + {i} = " + (x + i));
                        break;
                    case 4:
                        Console.WriteLine(x + $" - {i} = " + (x - i));
                        break;

                }
            }
            Console.ReadLine();
        }
    }
}
