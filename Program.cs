using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Fizz and some buzz");
            var upto = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 10));
            var list = FizzBuzz(upto).ToList();
            foreach (var item in list)
            {
                Thread.Sleep(1000);
                Console.WriteLine(item);
            }
        }
        static IEnumerable<string> FizzBuzz(int upto)
        {
            for (int i = 1; i <= upto; i++)
            {
                if(i % 15 == 0)
                    yield return "FizzBuzz";
                else if (i % 3 == 0)
                    yield return "Fizz";
                else if (i % 5 == 0)
                    yield return "Buzz";
                else
                    yield return i.ToString();
            }   
        }
    }   

}