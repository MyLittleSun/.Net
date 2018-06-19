using Prototype.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Manager
    {
        private Hashtable showcase = new Hashtable();
        public void register(string name, Product proto)
        {
            showcase.Add(name, proto);
        }
        public Product create(string protoname)
        {
            Product p = (Product)showcase[protoname];
            return p.createClone();
        }
    }
}
