using System;

class Program 
{
    static void Main(string[] args) 
    {
        System.Console.Write("Nhập vào thứ: ");
        int t = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Nhập vào k ngày: ");
        int k = Convert.ToInt32(Console.ReadLine());
        int kq = ((t - 2) + k) % 7 + 2;
        System.Console.WriteLine($"Sau {k} ngày sẽ là thứ {k}");
    }
}