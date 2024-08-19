using System;
namespace Section02
{
    internal class BT03
    {
        static void Main(string[] args)

        {
        Console.Write("Nhap so thu nhat: "); 
        string num_1 = Console.ReadLine();
        int num1 = Convert.ToInt16(num_1);

        Console.Write("Nhap so thu hai: ");
        string num_2 = Console.ReadLine();
        int num2 = Convert.ToInt16(num_2);
            int tong = num1 + num2;
            Console.WriteLine($"Tong hai so la: {tong} ");
        Console.ReadKey();
        }
    }
}
