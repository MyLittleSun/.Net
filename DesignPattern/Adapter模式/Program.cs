using Adapter模式.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrint p = new PrintBanner("Hello");
            p.printWeak();
            p.printStrong();
            Console.ReadKey();
        }
    }
}
