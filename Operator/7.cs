using System;

class Program 
{
    static void Main(string[] args) 
    {
        System.Console.Write("Nhập vào góc: ");
        int angle = Convert.ToInt32(Console.ReadLine());
        // int kq = angle % 360 / 90 + 1;
        int kq = angle / 90 % 4 + 1;
        System.Console.WriteLine("Thuộc góc phần tư thứ " + kq);
    }
}