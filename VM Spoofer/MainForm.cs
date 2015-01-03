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

            UpdateListView();
        }

        public void UpdateListView()
        {
            listView.Items.Clear();
            foreach (AbstractRegKey ark in Program.RegKeyList)
            {
                string[] row = new string[] { ark.Key, ark.exists() ? "Yes" : "No" };
                ListViewItem item = new ListViewItem(row);
                item.Group = listView.Groups[(int)ark.VMType];
                listView.Items.Add(item);
            }

            foreach (AbstractFile af in Program.FileList)
            {
                string[] row = new string[] { af.Path, af.exists() ? "Yes" : "No" };
                ListViewItem item = new ListViewItem(row);
                item.Group = listView.Groups[(int)af.VMType];
                listView.Items.Add(item);
            }
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip.Show(Cursor.Position);
                }
            } 
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView.SelectedItems.Count; i++) {
                ListViewItem selected = listView.SelectedItems[i];
                Console.WriteLine(selected.Text);
            }
        }
    }
}
