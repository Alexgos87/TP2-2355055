using System;
namespace FizzBuzzDemo
{
    public class example
    {
        // This is where the program will start
        static void Main(string[] args)
        {
            Console.Write("Entrez un nombre");
            int max = int.Parse(Console.ReadLine());
            // This is the beginning of the program 
            for (int i = 1; i <= max; i++)
            {
                

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}