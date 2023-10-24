using System;

class Program 
{
    static void Main(string[] args) 
    {
        string? tenSanPham;
        int soLuong, donGia;
        System.Console.Write("Nhập tên sản phẩm: ");
        tenSanPham = Console.ReadLine();
        System.Console.Write("Nhập số lượng: ");
        soLuong = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Nhập đơn giá: ");
        donGia = Convert.ToInt32(Console.ReadLine());
        
        int tien = soLuong * donGia;
        float thueGiaTriGiaTang = 0.1f * tien;

        System.Console.WriteLine($"Giá tiền của {tenSanPham} là {tien}");
        System.Console.WriteLine("Thuế giá trị gia tăng: " + thueGiaTriGiaTang);
    }
}