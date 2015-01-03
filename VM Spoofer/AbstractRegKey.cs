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
        public string Key { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public RegistryKey BaseKey { get; set; }
        public Program.vms VMType { get; set; }


        public void create()
        {
            RegistryKey key = BaseKey.CreateSubKey(Key);
            key.SetValue(Name, Value);
            key.Close();
        }

        public void delete()
        {
            RegistryKey key = BaseKey.CreateSubKey(Key);
            key.DeleteValue(Name);
            key.Close();
        }
    }

}
