using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section3
{
    internal class baitap1
    {
        static void Main(string[] args)
        {
            
            Console.Write
                ("Nhap nhiet do theo do C: ");
            float celcius = Convert.ToSingle(Console.ReadLine());
            float kelvin = celcius + 273;
            float fahrenheit = celcius * 18 / 10 + 32;
            Console.Write("{0} trong do K va {1} trong do F", kelvin, fahrenheit);
        }
    }
}
