using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "A message from (unknown) person !";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("H");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("He");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Hel");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Hell");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Hello");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Hello!");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("B");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("By");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Bye");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
