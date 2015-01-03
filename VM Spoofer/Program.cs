using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VM_Spoofer
{
    static class Program
    {

        List<AbstractRegKey> RegKeyList = new List<AbstractRegKey>()
        {

        };


        static void Main()
        {
            LoadLists();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void LoadLists()
        {

        }
    }
}
