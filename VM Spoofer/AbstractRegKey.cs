using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace VM_Spoofer
{

    class AbstractRegKey : AbstractItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public RegistryKey BaseKey { get; set; }
        public Program.vms VMType { get; set; }


        public override void create()
        {
            RegistryKey key = BaseKey.CreateSubKey(Path);
            key.SetValue(Name, Value);
            key.Close();
        }

        public override void delete()
        {
            RegistryKey key = BaseKey.CreateSubKey(Path);
            key.DeleteValue(Name);
            key.Close();
        }

        public override bool exists()
        {
            object value = BaseKey.GetValue(Path, null, RegistryValueOptions.None);

            return value != null;
        }
    }

}
