using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        void op(int[] n)
        {
            int max = n[0];
            int min = n[0];
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= max) max = n[i];
                if (n[i] <= min) min = n[i];
                sum += n[i];
            }
            double avg = sum / n.Length;
            Console.WriteLine("MAX:" + max + "   MIN:" + min + "   SUM:" + sum + "   AVG:" + avg);
        }

        static void Main(string[] args)
        {
            Program p=new Program();
            string s = "";
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                s = Console.ReadLine();
                a[i] = Int32.Parse(s);
            }
            
            p.op(a);
            Console.ReadLine();
        }
    }
}
