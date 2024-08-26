using System;
internal class Program
{
    static void Main(string[] args)
    {
        //Nguoi choi co 1000$
        //Sau do choi voi may cho den khi chon N -> exit
        //Thong ke:
        //1. So lan da choi
        //2. So lan thang/thua
        //3. Con bao nhieu tien

        int money = 1000;
        Console.Write("Hien tai ban dang co {0} $", money);
        Console.WriteLine(" ");

        Random rnd = new Random();
        int comp_num = rnd.Next(1,100);
        int man_num = 0;
        do
        {
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("Nhap so ban doan: ");
                man_num = int.Parse("0" + Console.ReadLine());
                if (man_num == comp_num)
                {
                    Console.WriteLine("Ban da doan dung! Xin chuc mung!");
                    break;
                }
                else
                    if (man_num < comp_num)
                    Console.WriteLine("So ban doan nho hon so cua may tinh.");
                else Console.WriteLine("So ban doan lon hon so cua may tinh.");
            }
            if (man_num != comp_num) Console.WriteLine("So cua may tinh la {0}. Ban da doan sai.", comp_num);
            else Console.WriteLine();
            Console.Write("Ban co muon choi tiep khong? <Y/n>")

        } while (true);
        
    }

}