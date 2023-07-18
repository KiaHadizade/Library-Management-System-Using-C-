using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    abstract class Abstract
    {
        public abstract void Filing();
        public abstract void Insert(string data);
        public abstract void Update(int id, string data);
        public abstract void Delete(int id);
    }
}
