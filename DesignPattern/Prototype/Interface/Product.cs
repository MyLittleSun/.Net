using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Interface
{
    public interface Product
    {
        void use(string s);
        Product createClone();
    }
}
