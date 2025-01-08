namespace WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolStripContainer1 = new ToolStripContainer();
            splitContainer1 = new SplitContainer();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            tContent = new TextBox();
            detailsPanel = new Panel();
            lCreated = new Label();
            lName = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            miOpen = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            reloadTimer = new System.Windows.Forms.Timer(components);
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            detailsPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            toolStripContainer1.ContentPanel.Size = new Size(937, 555);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(937, 583);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tContent);
            splitContainer1.Panel2.Controls.Add(detailsPanel);
            splitContainer1.Size = new Size(937, 555);
            splitContainer1.SplitterDistance = 311;
            splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(311, 555);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Size";
            columnHeader2.Width = 141;
            // 
            // tContent
            // 
            tContent.Dock = DockStyle.Fill;
            tContent.Location = new Point(0, 83);
            tContent.Multiline = true;
            tContent.Name = "tContent";
            tContent.Size = new Size(622, 472);
            tContent.TabIndex = 1;
            // 
            // detailsPanel
            // 
            detailsPanel.Controls.Add(lCreated);
            detailsPanel.Controls.Add(lName);
            detailsPanel.Controls.Add(label2);
            detailsPanel.Controls.Add(label1);
            detailsPanel.Dock = DockStyle.Top;
            detailsPanel.Location = new Point(0, 0);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(622, 83);
            detailsPanel.TabIndex = 0;
            detailsPanel.Paint += detailsPanel_Paint;
            // 
            // lCreated
            // 
            lCreated.AutoSize = true;
            lCreated.Location = new Point(154, 47);
            lCreated.Name = "lCreated";
            lCreated.Size = new Size(0, 20);
            lCreated.TabIndex = 3;
            // 
            // lName
            // 
            lName.AutoSize = true;
            lName.Location = new Point(154, 14);
            lName.Name = "lName";
            lName.Size = new Size(0, 20);
            lName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(11, 43);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 1;
            label2.Text = "Created:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(937, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miOpen, miExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // miOpen
            // 
            miOpen.Name = "miOpen";
            miOpen.Size = new Size(128, 26);
            miOpen.Text = "Open";
            miOpen.Click += miOpen_Click;
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new Size(128, 26);
            miExit.Text = "Exit";
            miExit.Click += miExit_Click;
            // 
            // reloadTimer
            // 
            reloadTimer.Tick += reloadTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 583);
            Controls.Add(toolStripContainer1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MiniExplorer - ALDU8G";
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem miOpen;
        private ToolStripMenuItem miExit;
        private SplitContainer splitContainer1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox tContent;
        private Panel detailsPanel;
        private Label label1;
        private Label label2;
        private Label lCreated;
        private Label lName;
        private System.Windows.Forms.Timer reloadTimer;
    }
}