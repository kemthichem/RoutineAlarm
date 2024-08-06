namespace RoutineAlarm
{
    partial class AlarmDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmDetails));
            richTextBox1 = new RichTextBox();
            btnOK = new Button();
            btnSnooze = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(72, 30);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(246, 120);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(72, 173);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnSnooze
            // 
            btnSnooze.Location = new Point(206, 173);
            btnSnooze.Name = "btnSnooze";
            btnSnooze.Size = new Size(112, 23);
            btnSnooze.TabIndex = 2;
            btnSnooze.Text = "Snooze 3 hours";
            btnSnooze.UseVisualStyleBackColor = true;
            // 
            // AlarmDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(btnSnooze);
            Controls.Add(btnOK);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AlarmDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AlarmDetail";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnOK;
        private Button btnSnooze;
    }
}