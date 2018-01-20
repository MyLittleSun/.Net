using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new IDCardFactory();
            Product card1 = factory.create("小明");
            Product card2 = factory.create("小红");
            Product card3 = factory.create("小刚");
            card1.use();
            card2.use();
            card3.use();
            Console.ReadKey();
        }
    }
}
