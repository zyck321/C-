using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int a = 0;
            int b = 0;
            s = Console.ReadLine();
            a = Int32.Parse(s);
            s = Console.ReadLine();
            b = Int32.Parse(s);
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
    }
}
