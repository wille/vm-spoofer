using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VM_Spoofer
{
    static class Program
    {

        public enum vms : int { VIRTUALBOX = 0, VMWARE = 1, };

        public static List<AbstractRegKey> RegKeyList = new List<AbstractRegKey>()
        {
            new AbstractRegKey() { Path = "SOFTWARE\\Oracle\\VirtualBox Guest Additions", Name = "", Value = "", BaseKey = Registry.LocalMachine, VMType = vms.VIRTUALBOX },
            new AbstractRegKey() { Path = "HARDWARE\\SYSTEM\\ControlSet001\\Services\\VBox", Name = "", Value = "", BaseKey = Registry.LocalMachine, VMType = vms.VIRTUALBOX },

            new AbstractRegKey() { Path = "SOFTWARE\\VMware, Inc.\\VMware Tools", Name = "", Value = "", BaseKey = Registry.LocalMachine, VMType = vms.VMWARE },
        };

        public static List<AbstractFile> FileList = new List<AbstractFile>()
        {
            new AbstractFile() { Path = "C:\\WINDOWS\\system32\\drivers\\vmhgfs.sys", VMType = vms.VMWARE },
            new AbstractFile() { Path = "C:\\WINDOWS\\system32\\drivers\\vmmouse.sys", VMType = vms.VMWARE },

        };


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());         
        }

        public static AbstractItem GetItem(string Path)
        {
            foreach (AbstractRegKey ark in Program.RegKeyList)
            {
                if (ark.Path == Path)
                {
                    return ark;
                }
            }

            foreach (AbstractFile af in Program.FileList)
            {
                if (af.Path == Path)
                {
                    return af;
                }
            }

            return null;
        }

    }
}
