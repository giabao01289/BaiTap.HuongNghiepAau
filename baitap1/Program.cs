// Bài tập 1: Kiểm tra số chẵn hay số lẻ
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập vào một số nguyên: ");
        int so = int.Parse(Console.ReadLine());

        if (so % 2 == 0)
        {
            Console.WriteLine(so + " là số chẵn.");
        }
        else
        {
            Console.WriteLine(so + " là số lẻ.");
        }
    }
}

// Bài tập 2: Xếp loại học lực dựa trên điểm trung bình
    class Baitap2
{
        public static void Main(string[] args)
    {
        
        // Bài tập 2: điểm trung bình
             Console.Write("Nhập điểm trung bình (0 - 10): ");
             double diem = double.Parse(Console.ReadLine());
                if (diem < 0 || diem > 10)
             Console.WriteLine("Điểm không hợp lệ!");
                else if (diem < 5.0)
             Console.WriteLine("Xếp loại: Yếu");
                else if (diem < 6.5)
             Console.WriteLine("Xếp loại: Trung bình");
                else if (diem < 8.0)
             Console.WriteLine("Xếp loại: Khá");
                else if (diem <= 10.0)
             Console.WriteLine("Xếp loại: Giỏi");
         
    }
    
}


// Bài tập 3: Giải phương trình bậc nhất ax + b = 0
class Baitap3
{
    static void Main(string[] args)
    {
        Console.Write("Nhập hệ số a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập hệ số b: ");
        double b = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phương trình vô số nghiệm.");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Phương trình có nghiệm duy nhất: x = " + x);
        }
    }
}


// Bài tập 4: In ra tên ngày trong tuần dựa trên số từ 1 đến 7
class Baitap4
{
    static void Main(string[] args)
    {
        Console.Write("Nhập một số từ 1 đến 7: ");
        int so = int.Parse(Console.ReadLine());

        switch (so)
        {
            case 1:
                Console.WriteLine("Thứ Hai");
                break;
            case 2:
                Console.WriteLine("Thứ Ba");
                break;
            case 3:
                Console.WriteLine("Thứ Tư");
                break;
            case 4:
                Console.WriteLine("Thứ Năm");
                break;
            case 5:
                Console.WriteLine("Thứ Sáu");
                break;
            case 6:
                Console.WriteLine("Thứ Bảy");
                break;
            case 7:
                Console.WriteLine("Chủ Nhật");
                break;
            default:
                Console.WriteLine("Số không hợp lệ");
                break;
        }
    }
}

// Bài tập 5: Xác định số ngày trong tháng dựa trên tháng và năm
class Baitap5
{
    static void Main(string[] args)
    {
        Console.Write("Nhập tháng (1-12): ");
        int thang = int.Parse(Console.ReadLine());

        Console.Write("Nhập năm: ");
        int nam = int.Parse(Console.ReadLine());

        switch (thang)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Tháng " + thang + " năm " + nam + " có 31 ngày.");
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Tháng " + thang + " năm " + nam + " có 30 ngày.");
                break;

            case 2:
                if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                {
                    Console.WriteLine("Tháng 2 năm " + nam + " có 29 ngày (năm nhuận).");
                }
                else
                {
                    Console.WriteLine("Tháng 2 năm " + nam + " có 28 ngày (không nhuận).");
                }
                break;

            default:
                Console.WriteLine("Tháng không hợp lệ.");
                break;
        }
    }
}

// Bài tập 6: In ra bảng cửu chương của một số từ 1 đến 10
class Baitap6
{
    static void Main(string[] args)
    {
        Console.Write("Nhập một số từ 1 đến 10: ");
        int so = int.Parse(Console.ReadLine());

        if (so < 1 || so > 10)
        {
            Console.WriteLine("Số không hợp lệ!");
        }
        else
        {
            Console.WriteLine("=== Bảng cửu chương " + so + " ===");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(so + " x " + i + " = " + (so * i));
            }
        }
    }
}

// Bài tập 7: In ra hình tam giác vuông bằng dấu sao

class Baitap7
{
    static void Main(string[] args)
    {
        Console.Write("Nhập chiều cao h: ");
        int h = int.Parse(Console.ReadLine());

        for (int i = 1; i <= h; i++)       // vòng ngoài: dòng 1 → h
        {
            for (int j = 1; j <= i; j++)   // vòng trong: in i dấu sao
            {
                Console.Write("*");
            }
            Console.WriteLine();           // xuống dòng sau mỗi hàng
        }
    }
}