using System;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.sayi: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("2.sayi: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(x+y);            
        }
    }
}
