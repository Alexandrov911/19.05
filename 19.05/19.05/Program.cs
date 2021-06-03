using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._05
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6.9
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            while(k*k<n)
            {
                k++;
            }
            Console.WriteLine(k * k);
            Console.ReadKey();
        }
    }
}
