using Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class MessageBox : Product, ICloneable
    {
        private char decochar;
        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }
        public void use(string s)
        {
            int length = s.Length;
            for(int i = 0; i < length + 4; i++)
            {
                Console.WriteLine(decochar);
            }
            Console.WriteLine("");
            Console.WriteLine("{0} {1} {2}", decochar, s, decochar);
            for(int i = 0; i < length + 4; i++)
            {
                Console.WriteLine(decochar);
            }
            Console.WriteLine("");
        }

        public Product createClone()
        {
            Product p = null;
            try
            {
                p = (Product)Clone();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return p;
        }

        public object Clone()
        {
            return new MessageBox(decochar);
        }
    }
}
