using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {1.1, 2.0, 3.0, 4.0};
            var sum = 0.0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            System.Console.WriteLine(sum);

            if (args.Length > 0) 
            {
                Console.WriteLine($"Hello {args[0]}!");
            } else {
                Console.WriteLine("Hello!");
            }
        }
    }
}
