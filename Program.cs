
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            TestMethod t = new TestMethod();
            t.startBrowser();

            Console.ReadKey();
        }
    }
}
