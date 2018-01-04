using Adapter模式.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter模式
{
    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string str)
            :base(str)
        {
        }
        public void printWeak()
        {
            showWithParen();
        }
        public void printStrong()
        {
            showWithAster();
        } 
    }
}
