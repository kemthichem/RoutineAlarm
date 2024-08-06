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
            lbDrinkWater = new Label();
            lbDoExercise = new Label();
            lbDWTime = new Label();
            lbDETime = new Label();
            btnSnoozeDW = new Button();
            btnSnoozeDE = new Button();
            btnReloadCf = new Button();
            btnSaveCf = new Button();
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
            // lbDrinkWater
            // 
            lbDrinkWater.AutoSize = true;
            lbDrinkWater.Location = new Point(39, 42);
            lbDrinkWater.Name = "lbDrinkWater";
            lbDrinkWater.Size = new Size(67, 15);
            lbDrinkWater.TabIndex = 1;
            lbDrinkWater.Text = "Drink water";
            // 
            // lbDoExercise
            // 
            lbDoExercise.AutoSize = true;
            lbDoExercise.Location = new Point(39, 91);
            lbDoExercise.Name = "lbDoExercise";
            lbDoExercise.Size = new Size(67, 15);
            lbDoExercise.TabIndex = 2;
            lbDoExercise.Text = "Do exercise";
            // 
            // lbDWTime
            // 
            lbDWTime.AutoSize = true;
            lbDWTime.Location = new Point(250, 42);
            lbDWTime.Name = "lbDWTime";
            lbDWTime.Size = new Size(34, 15);
            lbDWTime.TabIndex = 3;
            lbDWTime.Text = "10:30";
            // 
            // lbDETime
            // 
            lbDETime.AutoSize = true;
            lbDETime.Location = new Point(250, 91);
            lbDETime.Name = "lbDETime";
            lbDETime.Size = new Size(28, 15);
            lbDETime.TabIndex = 4;
            lbDETime.Text = "9:30";
            // 
            // btnSnoozeDW
            // 
            btnSnoozeDW.Location = new Point(401, 42);
            btnSnoozeDW.Name = "btnSnoozeDW";
            btnSnoozeDW.Size = new Size(75, 23);
            btnSnoozeDW.TabIndex = 5;
            btnSnoozeDW.Text = "Snooze 3h";
            btnSnoozeDW.UseVisualStyleBackColor = true;
            btnSnoozeDW.Click += btnSnoozeDW_Click;
            // 
            // btnSnoozeDE
            // 
            btnSnoozeDE.Location = new Point(401, 91);
            btnSnoozeDE.Name = "btnSnoozeDE";
            btnSnoozeDE.Size = new Size(75, 23);
            btnSnoozeDE.TabIndex = 6;
            btnSnoozeDE.Text = "Snooze 3h";
            btnSnoozeDE.UseVisualStyleBackColor = true;
            btnSnoozeDE.Click += btnSnoozeDE_Click;
            // 
            // btnReloadCf
            // 
            btnReloadCf.Location = new Point(88, 211);
            btnReloadCf.Name = "btnReloadCf";
            btnReloadCf.Size = new Size(119, 23);
            btnReloadCf.TabIndex = 7;
            btnReloadCf.Text = "Reload config file";
            btnReloadCf.UseVisualStyleBackColor = true;
            // 
            // btnSaveCf
            // 
            btnSaveCf.Location = new Point(318, 211);
            btnSaveCf.Name = "btnSaveCf";
            btnSaveCf.Size = new Size(119, 23);
            btnSaveCf.TabIndex = 8;
            btnSaveCf.Text = "Save config file";
            btnSaveCf.UseVisualStyleBackColor = true;
            // 
            // RoutineAlarm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(btnSaveCf);
            Controls.Add(btnReloadCf);
            Controls.Add(btnSnoozeDE);
            Controls.Add(btnSnoozeDW);
            Controls.Add(lbDETime);
            Controls.Add(lbDWTime);
            Controls.Add(lbDoExercise);
            Controls.Add(lbDrinkWater);
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
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip ctxMenuForNotifyIcon;
        private ToolStripMenuItem snoozeAllFor3HoursToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label lbDrinkWater;
        private Label lbDoExercise;
        private Label lbDWTime;
        private Label lbDETime;
        private Button btnSnoozeDW;
        private Button btnSnoozeDE;
        private Button btnReloadCf;
        private Button btnSaveCf;
    }
}
