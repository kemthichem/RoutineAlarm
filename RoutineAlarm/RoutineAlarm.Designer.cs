namespace RoutineAlarm
{
    partial class RoutineAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutineAlarm));
            notifyIcon1 = new NotifyIcon(components);
            ctxMenuForNotifyIcon = new ContextMenuStrip(components);
            snoozeAllFor3HoursToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            btnReloadCf = new Button();
            btnSaveCf = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ctxMenuForNotifyIcon.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = ctxMenuForNotifyIcon;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Routine Alarm";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            // 
            // ctxMenuForNotifyIcon
            // 
            ctxMenuForNotifyIcon.Items.AddRange(new ToolStripItem[] { snoozeAllFor3HoursToolStripMenuItem, exitToolStripMenuItem });
            ctxMenuForNotifyIcon.Name = "contextMenuStrip1";
            ctxMenuForNotifyIcon.Size = new Size(190, 48);
            // 
            // snoozeAllFor3HoursToolStripMenuItem
            // 
            snoozeAllFor3HoursToolStripMenuItem.Name = "snoozeAllFor3HoursToolStripMenuItem";
            snoozeAllFor3HoursToolStripMenuItem.Size = new Size(189, 22);
            snoozeAllFor3HoursToolStripMenuItem.Text = "Snooze All for 3 hours";
            snoozeAllFor3HoursToolStripMenuItem.Click += snoozeAllFor3HoursToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(189, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // btnReloadCf
            // 
            btnReloadCf.Location = new Point(124, 258);
            btnReloadCf.Name = "btnReloadCf";
            btnReloadCf.Size = new Size(119, 23);
            btnReloadCf.TabIndex = 7;
            btnReloadCf.Text = "Reload config file";
            btnReloadCf.UseVisualStyleBackColor = true;
            btnReloadCf.Click += btnReloadCf_Click;
            // 
            // btnSaveCf
            // 
            btnSaveCf.Location = new Point(331, 258);
            btnSaveCf.Name = "btnSaveCf";
            btnSaveCf.Size = new Size(119, 23);
            btnSaveCf.TabIndex = 8;
            btnSaveCf.Text = "Save config file";
            btnSaveCf.UseVisualStyleBackColor = true;
            btnSaveCf.Click += btnSaveCf_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.InactiveBorder;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(29, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(543, 227);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Tag = "";
            columnHeader1.Text = "Task";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Remind time";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "";
            columnHeader4.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 70;
            // 
            // RoutineAlarm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(listView1);
            Controls.Add(btnSaveCf);
            Controls.Add(btnReloadCf);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RoutineAlarm";
            Text = "Routine Alarm";
            MinimumSizeChanged += Form1_MinimumSizeChanged;
            Load += Form1_Load;
            Resize += Form1_Resize;
            ctxMenuForNotifyIcon.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip ctxMenuForNotifyIcon;
        private ToolStripMenuItem snoozeAllFor3HoursToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnReloadCf;
        private Button btnSaveCf;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
