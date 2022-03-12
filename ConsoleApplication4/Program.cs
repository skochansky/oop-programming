using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleApplication4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Jaka Figura");
            Console.WriteLine("Prostokat - 1");
            Console.WriteLine("Kwadrat - 2");
            Console.WriteLine("Trojkat - 3");
            String choose = Console.ReadLine();
            
            if (choose == "1")
            {
                Console.WriteLine("Podaj dlugosc boku");
                float x = float.Parse(Console.ReadLine());
                Console.WriteLine("Pole - 1, Obwod - 2");
                choose = Console.ReadLine();
                if (choose == "1")
                {
                    float pole = x * x;
                    Console.WriteLine(pole);
                }
                else if (choose == "2")
                {
                    float obwod = 4 * x;
                    Console.WriteLine(obwod);                }
            }
            else if (choose == "2")
            {
                Console.WriteLine("Podaj dlugosc bokow x , y");
                float x = float.Parse(Console.ReadLine());
                float y = float.Parse(Console.ReadLine());
                float pole = x * y;
                Console.WriteLine(pole);

            }
            else
            {
                Console.WriteLine("Wybrales zla opcje");
            }
        }
    }
}