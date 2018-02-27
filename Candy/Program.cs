using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            int y = 0;
            while (x > n)
            {
                x = x - n;
                if (x > 0)
                {
                    x--;
                    n = (y > 0) ? n - 1 : n;
                    y += n;
                }
            }
            y += x;
            Console.WriteLine("y = " + y);
        }
    }
}
