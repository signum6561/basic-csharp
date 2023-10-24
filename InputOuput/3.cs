using System;

class Program 
{
    static void Main(string[] args) 
    {
        System.Console.Write("Nhập năm sinh: ");
        int namSinh = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Số tuổi của người đó: " + (2023 - namSinh));
    }
}