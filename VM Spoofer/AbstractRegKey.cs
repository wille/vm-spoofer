using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace VM_Spoofer
{ 

    class AbstractRegKey
    {
        private string Key { get; set; }
        private string Name { get; set; }
        private string Value { get; set; }
        private RegistryKey BaseKey { get; set; }


        public void create()
        {
            RegistryKey key = BaseKey.CreateSubKey(Key);
            key.SetValue(Name, Value);
            key.Close();
        }

        public void delete()
        {

        }
    }

}
