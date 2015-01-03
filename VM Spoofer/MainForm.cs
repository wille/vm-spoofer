using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VM_Spoofer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            foreach (AbstractRegKey ark in Program.RegKeyList)
            {
                string[] row = new string[] { ark.Key };
                ListViewItem item = new ListViewItem(row);
                item.Group = listView.Groups[(int) ark.VMType];
                listView.Items.Add(item);
            }
        }
    }
}
