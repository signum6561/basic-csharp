using System;

class Program 
{
    static void Main(string[] args) 
    {
        float r, chuVi, dienTich;
        System.Console.Write("Nhập vào bán kính r: ");
        r = Convert.ToSingle(Console.ReadLine());
        float pi = 3.14f;
        chuVi = 2 * pi * r;
        dienTich = pi * r * r;
        System.Console.WriteLine($"Chu vi hình tròn: {chuVi}");
        System.Console.WriteLine("Diện tích hình tròn: " + dienTich);
    }
}