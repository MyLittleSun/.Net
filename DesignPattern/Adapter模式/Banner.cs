using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter模式
{
    public class Banner
    {
        private string mString;
        public Banner(string str)
        {
            mString = str;
        }
        public void showWithParen()
        {
            Console.WriteLine("(" + mString + ")");
        }
        public void showWithAster()
        {
            Console.WriteLine("*" + mString + "*");
        }
    }
}
