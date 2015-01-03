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

        public enum vms : int { VIRTUALBOX = 0, VMWARE = 1, QEMU = 2 };

        public static List<AbstractRegKey> RegKeyList = new List<AbstractRegKey>()
        {
            new AbstractRegKey() { Key = "HARDWARE\\Description\\System", Name = "SystemBiosVersion", Value = "", BaseKey = Registry.LocalMachine, VMType = vms.VIRTUALBOX },
            new AbstractRegKey() { Key = "HARDWARE\\SOFTWARE\\Oracle\\VirtualBox Guest Additions", Name = "", Value = "", BaseKey = Registry.LocalMachine, VMType = vms.VIRTUALBOX },
            new AbstractRegKey() { Key = "HARDWARE\\Description\\System", Name = "VideoBiosVersion", Value = "", BaseKey = Registry.LocalMachine, VMType = vms.VIRTUALBOX },
            new AbstractRegKey() { Key = "HARDWARE\\SYSTEM\\ControlSet001\\Services", Name = "VBox", Value = "", BaseKey = Registry.LocalMachine, VMType = vms.VIRTUALBOX },

            new AbstractRegKey() { Key = "SOFTWARE\\VMware, Inc.\\VMware Tools", Name = "VideoBiosVersion", Value = "", BaseKey = Registry.LocalMachine, VMType = vms.VMWARE },

            new AbstractRegKey() { Key = "HARDWARE\\Description\\System", Name = "SystemBiosVersion", Value = "", BaseKey = Registry.LocalMachine, VMType = vms.QEMU },
        };


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());         
        }

    }
}
