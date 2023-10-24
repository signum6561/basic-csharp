using System;

class Program 
{
    static void Main(string[] args) 
    {
        System.Console.Write("Nhập vào a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Nhập vào b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine($"a + b = {a + b}");
        System.Console.WriteLine($"a - b = {a - b}");
        System.Console.WriteLine($"a * b = {a * b}");
        System.Console.WriteLine($"a / b = {a / b}");
        System.Console.WriteLine($"a % b = {a % b}");
    }
}