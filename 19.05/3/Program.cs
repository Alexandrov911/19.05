using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            while (n != 0)
            {
                int a = n % 10;
                if (a==3)
                {
                    k++;
                }
            }
            if (k==0)
            {
                Console.WriteLine("нет");
            }
            else
            {
                Console.WriteLine("есть");
            }
            Console.ReadKey();
        }
    }
}
