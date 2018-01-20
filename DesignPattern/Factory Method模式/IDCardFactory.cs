using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method模式
{
    public class IDCardFactory : Factory
    {
        private Hashtable database = new Hashtable();
        private int serial = 100;
        protected override Product createProduct(string owner)
        {
            return new IDCard(owner, serial++);
        }
        protected override void registerProduct(Product product)
        {
            IDCard card = (IDCard)product;
            database.Add(card.getSerial(), card.getOwner());
        }
        public Hashtable getOwners()
        {
            return database;
        }
    }
}
