using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method模式
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass d1 = new CharDisplay('H');
            AbstractClass d2 = new StringDisplay("Hello World");
            AbstractClass d3 = new StringDisplay("你好，世界");
            d1.display();
            d2.display();
            d3.display();
            Console.ReadKey();
        }
    }
}
