using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton模式
{
    public class Singleton
    {
        private static Singleton singleton = new Singleton();
        private Singleton()
        {
            Console.WriteLine("生成了一个实例.");
        }
        public static Singleton getInstance()
        {
            return singleton; 
        }
    }
}
