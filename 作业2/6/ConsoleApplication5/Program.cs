using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        void op(int n)
        {
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i + "");
                    n = n / i;
                    i = 1;
                }
            }
            if (n != 1)
            {
                Console.WriteLine(n + "");
            }
        }

        static void Main(string[] args)
        {
            Program p=new Program();
            string s = "";
            int a = 0;
            s = Console.ReadLine();
            a = Int32.Parse(s);
            p.op(a);
            Console.ReadLine();
        }
    }
}
