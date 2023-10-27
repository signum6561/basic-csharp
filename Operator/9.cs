using System;

class Program 
{
    static void Main(string[] args) 
    {
        /*
        Dữ kiện hữu hình:
        m: số nguyên
        50, 20, 10, 5, 2, 1
        Output 6 số => 6 biến
        197
        50 + 50 + 50
        197 - 150 = 47
        197 % 50 = 47
        20 + 20
        47 - 40 = 7
        5
        7 - 5 = 2
        2
        2 - 2 = 0
        47
        3 2 0 1 1 0
        */
        System.Console.Write("Nhập vào số tiền cần qui đổi: ");
        int m = Convert.ToInt32(Console.ReadLine());
        //197 / 50 = 3
        int t50 = m / 50;
        //197 - 3 * 50 = 47
        m %= 50;
        //47 / 20 = 2
        int t20 = m / 20;
        //47 - 2 * 20 = 7
        m %= 20;
        int t10 = m / 10;
        m %= 10;
        int t5 = m / 5;
        m %= 5;
        int t2 = m / 2;
        m %= 2;
        int t1 = m / 1;
        m %= 1;
        System.Console.Write($"{t50} {t20} {t10} {t5} {t2} {t1}");
    }
}