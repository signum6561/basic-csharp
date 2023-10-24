using System;

class Program 
{
    static void Main(string[] args) 
    {
        System.Console.Write("Nhập họ và tên: ");
        string? hoTen = Console.ReadLine();
        System.Console.Write("Nhập lớp: ");
        int lop = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Ngày sinh: ");
        int namSinh = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"- Họ tên: {hoTen} - Lớp: {lop} - Năm sinh: {namSinh}");
    }
}