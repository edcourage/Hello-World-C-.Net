using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dateAndTime = DateTime.Now;
            Console.WriteLine($"The time is {dateAndTime.ToString("t")}\nThe date is {dateAndTime.ToString("d")}");
        }
    }
}
