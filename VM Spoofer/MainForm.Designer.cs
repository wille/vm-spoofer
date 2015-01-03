namespace VM_Spoofer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("VirtualBox", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("VMWare", System.Windows.Forms.HorizontalAlignment.Left);
            this.listView = new System.Windows.Forms.ListView();
            this.headerFileKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerExists = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerFileKey,
            this.headerExists});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "VirtualBox";
            listViewGroup1.Name = "groupVirtualBox";
            listViewGroup2.Header = "VMWare";
            listViewGroup2.Name = "groupVMWare";
            this.listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(725, 366);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // headerFileKey
            // 
            this.headerFileKey.Text = "Registry Key/File";
            this.headerFileKey.Width = 213;
            // 
            // headerExists
            // 
            this.headerExists.Text = "Exists";
            this.headerExists.Width = 252;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 366);
            this.Controls.Add(this.listView);
            this.Name = "MainForm";
            this.Text = "VM Spoofer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListViewGroup listViewGroup1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader headerFileKey;
        private System.Windows.Forms.ColumnHeader headerExists;
    }
}

