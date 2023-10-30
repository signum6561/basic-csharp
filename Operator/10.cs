using System;

class Program 
{
    static void Main(string[] args) 
    {
        System.Console.Write("Nhập vào h: ");
        int h = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Nhập vào m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Nhập vào s: ");
        int s = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Nhập vào k: ");
        int k = Convert.ToInt32(Console.ReadLine());
        /* change
        Cách 1
        int s1 = (s + k) % 60;
        int m1 = (m + (s + k) / 60) % 60;
        int h1 = (h + (m + (s + k) / 60) / 60) % 24;

        Cách 2
        int t = h * 3600 + m * 60 + s + k;
        int h1 = t / 3600 % 24;
        t %= 3600;
        int s1 = t % 60;
        int m1 = t / 60;
        System.Console.WriteLine($"{h1}:{m1}:{s1}");
        */ 

        //Cách 3
        s += k;
        m += s / 60;
        h += m / 60;

        System.Console.WriteLine($"{h % 24}:{m % 60}:{s % 60}");
    }
}