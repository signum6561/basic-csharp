using System;

class Program 
{
    static void Main(string[] args) 
    {
        float diemToan, diemLy, diemHoa;
        float diemTB;
        System.Console.Write("Nhập vào điểm Toán: ");
        diemToan = Convert.ToSingle(Console.ReadLine());
        System.Console.Write("Nhập vào điểm Lý: ");
        diemLy = Convert.ToSingle(Console.ReadLine());        
        System.Console.Write("Nhập vào điểm Hóa: ");
        diemHoa = Convert.ToSingle(Console.ReadLine());
        diemTB = (diemToan + diemLy + diemHoa) / 3;
        System.Console.WriteLine("Điểm trung bình của sinh viên là: " + diemTB);
    }
}