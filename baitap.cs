using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week6
{
    internal class baitap
    {
        /*static void Main(string[] args)
        {
            //BT01();
            //BT02();
        }
        static void BT01()
        {
            int[][] array1 = new int[4][];
            array1[0] = new int[4] { 1, 1, 1, 1 };
            array1[1] = new int[2] { 2, 2 };
            array1[2] = new int[4] { 3, 3, 3, 3 };
            array1[3] = new int[2] { 4, 4 };
            foreach (int[] row in array1)
            {
                foreach (int i in row)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }*/
        

        static void Print(int[][] a)
        {
            foreach (int[] row in a)
            {
                foreach (int i in row)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
        static void FindMax(int[][] a)
        { 
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length > 0)
                {
                    int max = a[i].Max();
                    Console.WriteLine($"Gia tri lon nhat cua dong thu {i}: {max}");
                }
                else
                {
                    Console.WriteLine($"Dong {i} rong.");
                }
            }
                
        }
        public static void Main(string[] args)
        {
            
                Random rnd = new Random();
                Console.Write("Nhap so dong: "); int rows = Convert.ToInt32(Console.ReadLine());
                int[][] a = new int[rows][];
                for (int i = 0; i < rows; i++)
                {
                    Console.Write($"Nhap so cot cua hang thu {i}: "); int columns = Convert.ToInt32(Console.ReadLine());
                    a[i] = new int[columns];
                    for (int j = 0; j < columns; j++)
                    {
                        a[i][j] = rnd.Next(1, 50);
                    }
                }

            
            Print(a);
            Console.WriteLine();
            FindMax(a);
        }

    }
}
