using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzzer();

            for (var i = 1; i < 101; i++)
            {
                Console.WriteLine(fizzBuzzer.Check(i));
            }
        }
    }
}
