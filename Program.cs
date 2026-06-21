//Bài 1: Toán tử số học và Gán  
//Chuyển đổi Giây → Giờ:Phút:Giây
using System;

class baitap1
{
    static void Main(string[] args)
    {
        Console.Write("Nhập số giây: ");
        int tongGiay = int.Parse(Console.ReadLine());

        int gio   = tongGiay / 3600;
        int phut  = (tongGiay % 3600) / 60;
        int giay  = tongGiay % 60;

        Console.WriteLine(gio + " giờ " + phut + " phút " + giay + " giây");
    }
}

//Bài 2: Tiền tố và Hậu tố


class baitap2
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = a++ + ++a;

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
//Bài 3: Toán tử Logic và So sánh  


class baitap3
{
    static void Main(string[] args)
    {
        Console.Write("Nhập năm: ");
        int nam = int.Parse(Console.ReadLine());

        bool isLeapYear = (nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0);

        Console.WriteLine("Năm " + nam + " là năm nhuận: " + isLeapYear);
    }
}

//Bài 4: Tìm số lớn nhất bằng toán tử 3 ngôi


class baitap4
{
    static void Main(string[] args)
    {
        Console.Write("Nhập x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Nhập y: ");
        int y = int.Parse(Console.ReadLine());

        Console.Write("Nhập z: ");
        int z = int.Parse(Console.ReadLine());

        int max = (x > y) ? (x > z ? x : z) : (y > z ? y : z);

        Console.WriteLine("Số lớn nhất là: " + max);
    }
}