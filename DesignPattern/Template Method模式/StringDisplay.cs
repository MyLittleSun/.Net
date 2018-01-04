using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method模式
{
    public class StringDisplay : AbstractClass
    {
        private string str;
        private int width;
        public StringDisplay(string str)
        {
            this.str = str;
            this.width = str.Length;
        }
        public override void open()
        {
            printLine();
        }
        public override void print()
        {
            Console.WriteLine("|" + str + "|");
        }
        public override void close()
        {
            printLine();
        }
        private void printLine()
        {
            Console.WriteLine("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
