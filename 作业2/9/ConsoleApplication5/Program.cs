using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        void op()
        {
            for (int n = 2; n <= 100; n++) 
            {
                if (n % 2 != 0 && n % 3 != 0 && n % 4 !=0)
                {
                    Console.WriteLine(n + "");
                }
            }
        }

        static void Main(string[] args)
        {
            Program p=new Program(); 
            p.op();
            Console.ReadLine();
        }
    }
}
