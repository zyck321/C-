using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("BIBIBIBIBIBIBIBI!!!!!!!!!");
        }

        static void Main(string[] args)
        {
            Program p=new Program();
            int a=Convert.ToInt32(Console.ReadLine());
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Thread childth = new Thread(childref);
            Thread.Sleep(a);
            childth.Start();

            Console.ReadLine();
        }
    }
}
