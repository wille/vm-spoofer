using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM_Spoofer
{
    class AbstractItem
    {
        public string Path { get; set; }

        public virtual void create()
        {

        }

        public virtual void delete()
        {

        }
    }
}
