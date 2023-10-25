using System;

class Program 
{
    static void Main(string[] args) 
    {
        double canhKe, canhDoi;
        double canhHuyen;
        System.Console.Write("Nhập vào cạnh kề: ");  
        canhKe = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Nhập vào cạnh đối: ");  
        canhDoi = Convert.ToDouble(Console.ReadLine());
        
        canhHuyen = Math.Sqrt(Math.Pow(canhKe, 2) + Math.Pow(canhDoi, 2));
        //Math.Pow(a, b): mũ số
        //Math.Sqrt: căn bậc 2
        System.Console.WriteLine("Cạnh huyền là: " + canhHuyen);
    }
}