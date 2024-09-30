using System;

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
        Class1 class1 = new Class1(); // Tạo instance của Class1
        long s0 = 5; // Thay đổi giá trị s0 tại đây
        long s;
        class Program
{
    static void Main(string[] args)
    {
        Class1 class1 = new Class1(); // Tạo instance của Class1
        long s0 = 5; // Thay đổi giá trị s0 tại đây
        long s;
        
        long k = class1.Sum(s0, out s); // Gọi phương thức Sum
        
        Console.WriteLine($"Giá trị s0: {s0}");
        Console.WriteLine($"Giá trị k: {k}");
        Console.WriteLine($"Giá trị s: {s}");
        
        // Đợi người dùng nhấn phím trước khi thoát
        Console.WriteLine("Nhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}
        long k = class1.Sum(s0, out s); // Gọi phương thức Sum

        Console.WriteLine($"Giá trị s0: {s0}");
        Console.WriteLine($"Giá trị k: {k}");
        Console.WriteLine($"Giá trị s: {s}");

        // Đợi người dùng nhấn phím trước khi thoát
        Console.WriteLine("Nhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}
