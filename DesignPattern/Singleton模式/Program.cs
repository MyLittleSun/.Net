using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start.");
            Singleton obj1 = Singleton.getInstance();
            Singleton obj2 = Singleton.getInstance();
            if(obj1 == obj2)
            {
                Console.WriteLine("obj1与obj2是相同实例.");
            }
            else
            {
                Console.WriteLine("obj1与obje2是不同的实例.");
            }
            Console.WriteLine("End.");
            Console.ReadKey();
        }
    }
}
