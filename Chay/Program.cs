using System;

namespace MyConsoleApp // Change this to match your console app namespace
{
    public class Class1
    {
        public long Sum(long s0, out long s)
        {
            s = 0L;
            long num = 1L;
            while (s <= s0)
            {
                s += num;
                num++;
            }
            return num;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1(); // Assuming Class1 is the name of your class in the library
            long s0 = 5; // Change this value to test different inputs
            long s;

            long k = class1.Sum(s0, out s); // Call the Sum method

            // Display the results
            Console.WriteLine($"Giá trị s0: {s0}");
            Console.WriteLine($"Giá trị k: {k}");
            Console.WriteLine($"Giá trị s: {s}");

            // Wait for user input before closing
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
