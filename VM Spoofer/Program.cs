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
            new AbstractRegKey() { Key = "HARDWARE\\SOFTWARE\\Oracle\\VirtualBox Guest Additions", Name = "", Value = "", BaseKey = Registry.LocalMachine, VMType = vms.VIRTUALBOX },
            new AbstractRegKey() { Key = "HARDWARE\\SYSTEM\\ControlSet001\\Services\\VBox", Name = "", Value = "", BaseKey = Registry.LocalMachine, VMType = vms.VIRTUALBOX },

            new AbstractRegKey() { Key = "SOFTWARE\\VMware, Inc.\\VMware Tools", Name = "", Value = "", BaseKey = Registry.LocalMachine, VMType = vms.VMWARE },
        };

        public static List<AbstractFile> FileList = new List<AbstractFile>()
        {
            new AbstractFile() { Path = "C:\\WINDOWS\\system32\\drivers\\vmhgfs.sys", VMType = vms.VIRTUALBOX },
        };


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());         
        }

    }
}
