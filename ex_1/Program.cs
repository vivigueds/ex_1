using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 valores : ");
            int a, b, s;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            s = a + b;

            if ( s > 10)
            {
                s = s + 5;
                Console.WriteLine(s);

            }
            else
            {
                s = s - 7;
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
        

    }
}
