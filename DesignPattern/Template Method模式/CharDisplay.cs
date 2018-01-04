using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method模式
{
    public class CharDisplay : AbstractClass
    {
        private char ch;
        public CharDisplay(char ch)
        {
            this.ch = ch;
        }
        public override void open()
        {
            Console.WriteLine("<<");
        }
        public override void print()
        {
            Console.WriteLine(ch);
        }
        public override void close()
        {
            Console.WriteLine(">>");
        }
    }
}
