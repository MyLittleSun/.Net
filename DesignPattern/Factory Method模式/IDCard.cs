using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method模式
{
    public class IDCard : Product
    {
        private string owner;
        private int serial;
        internal IDCard(string owner, int serial)
        {
            Console.WriteLine(" 制作 {0}({1}) 的ID卡。", owner, serial);
            this.owner = owner;
            this.serial = serial;
        }
        public override void use()
        {
            Console.WriteLine(" 使用 {0}({1}) 的ID卡。", owner, serial);
        }
        public string getOwner()
        {
            return owner;
        }
        public int getSerial()
        {
            return serial;
        }

    }
}
