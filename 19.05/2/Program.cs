using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            // сумма чисел от 3 6 9 до 33
            int sum = 0;
            int k = 3;
            while(k<=33)
            {
                sum = sum + k;
                k = k + 3;
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
