using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_TUAN_4
{
    internal class baitap
    {
        private static void Main(string[] args)
        {
            //BT01();
            //BT02();
            //BT03();
            //BT04();
            //BT05();
            //BT06();
            //BT07();
            //BT08();
            //BT09();
            BT10();
        }
        static void BT01()
        {
            Console.Write("Nhap mot so bat ky: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Day la so chan nha!");
            }
            else Console.WriteLine("Day la so le nha!");
        }
        static void BT02()
        {
            Console.Write("Nhap vao so 1 bat ky: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao so 2 bat ky: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao so 3 bat ky:");
            double a3 = Convert.ToDouble(Console.ReadLine());
            double max = a1;
            double max1 = Math.Max(Math.Max(a1, a2), a3);
            Console.WriteLine($"So lon nhat trong 3 so la: {max1} ");
        }
        static void BT03()
        {
            Console.Write("Nhap toa do X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap toa do Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Toa do ({x},{y}) o Goc phan tu thu 1");
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.WriteLine($"Toa do ({x},{y}) o Goc phan tu thu 2");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine($"Toa do ({x},{y}) o Goc phan tu thu 3");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine($"Toa do ({x},{y}) o Goc phan tu thu 4");
                }
                else if (x != 0 && y == 0)
                {
                    Console.WriteLine($"Toa do ({x},{y}) o tren truc X");
                }
                else if (y != 0 && x == 0)
                {
                    Console.WriteLine($"Toa do ({x},{y}) o tren truc Y");
                }
                else
                {
                    Console.WriteLine($"Toa do ({x},{y}) o tren O");
                }
            }

        }
        static void BT04()
        {
            Console.Write("Nhap vao canh a: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap vao canh b: ");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap vao canh c: ");
            float c = Convert.ToSingle(Console.ReadLine());
            if (a + b >= c && a + c >= b && b + c >= a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Day la tam giac deu ~");
                }

                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Day la tam giac can ~");
                }
                else if
                    (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                {
                    Console.WriteLine("Day la tam giac vuong ~");
                }
            }
            else Console.WriteLine("Day khong phai là tam giac");
        }
        static void BT05()
        {
            double sum = 0.0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhap vao so {i} ");
                double a = Convert.ToDouble(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine($"Tong cua cac so la: {sum}");
            Console.WriteLine($"Trung binh cua cac so la: {sum / 10}");
        }
        static void BT06()
        {
            Console.Write("Chon bang cuu chuong: ");
            int bang = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{bang} x {i} = {bang * i}");
            }
            Console.WriteLine();
        }
        static void BT07()
        {
            Console.Write("Nhap vao so hang: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        static void BT08()
        {
            Console.Write("Nhap vao so n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
                Console.Write($"1/{i}; ");
            }

            Console.WriteLine($"Tong la: {sum}");
        }
        static void BT09()
        {
            Console.Write("Nhap vao so: ");
            double g = Convert.ToDouble(Console.ReadLine());
            double sum = 0.0;
            for (int i = 1; i < g; i++)
            {
                if (g % i == 0)
                {
                    sum += i;
                }
            }
            if (g == sum)
            {
                Console.WriteLine("Day là so hoan hao");
            }
            else Console.WriteLine("Day khong la so hoan hao");
        }
        static void BT10()
        {
            Console.Write("Nhap vao so bat ky: ");
            int nt = Convert.ToInt32(Console.ReadLine());
            int so = 0;
            if (nt < 2)
            {
                Console.WriteLine("Khong phai so nguyen to");
                return;
            }
            else
            {
                for (int i = 2; i <= nt; i++)
                {
                    if ((i % i) == 0)
                        so++;
                }
                if (so == 0)
                {
                    Console.WriteLine("So nguyen to day roi");
                }
                else Console.WriteLine("Khong phai so nguyen to");
            }
        }
    }

}
