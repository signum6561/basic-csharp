using System;

class Program 
{
    static void Main(string[] args) 
    {
        // n là số thực
        // n [0, 0.5) => 0
        // n [0.5, 1) => 1
        // 0.5
        // 1.2
        // 1
        // 1.7 => 2

        System.Console.Write("Nhập vào n: ");
        double n = Convert.ToDouble(Console.ReadLine());

        // n += 0.5;
        // double kq = n - (n % 1);

        // int kq = (int)(n + 0.5);

        double kq = Math.Round(n);
        System.Console.Write("Kết quả: " + kq);
    }
}