namespace ProcInfo
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxHandles = new System.Windows.Forms.TextBox();
            this.textBoxPrivateBytes = new System.Windows.Forms.TextBox();
            this.textBoxWset = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.textBoxProcess = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxBeep = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            //this.FormBorderStyle = FormBorderStyle.
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLogFileToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // viewLogFileToolStripMenuItem
            // 
            this.viewLogFileToolStripMenuItem.Name = "viewLogFileToolStripMenuItem";
            this.viewLogFileToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.viewLogFileToolStripMenuItem.Text = "View log file";
            this.viewLogFileToolStripMenuItem.Click += new System.EventHandler(this.viewLogFileToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(622, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxHandles);
            this.panel1.Controls.Add(this.textBoxPrivateBytes);
            this.panel1.Controls.Add(this.textBoxWset);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(190, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 251);
            this.panel1.TabIndex = 2;
            // 
            // textBoxHandles
            // 
            this.textBoxHandles.Location = new System.Drawing.Point(180, 188);
            this.textBoxHandles.Name = "textBoxHandles";
            this.textBoxHandles.Size = new System.Drawing.Size(100, 26);
            this.textBoxHandles.TabIndex = 7;
            // 
            // textBoxPrivateBytes
            // 
            this.textBoxPrivateBytes.Location = new System.Drawing.Point(180, 134);
            this.textBoxPrivateBytes.Name = "textBoxPrivateBytes";
            this.textBoxPrivateBytes.Size = new System.Drawing.Size(100, 26);
            this.textBoxPrivateBytes.TabIndex = 6;
            // 
            // textBoxWset
            // 
            this.textBoxWset.Location = new System.Drawing.Point(180, 83);
            this.textBoxWset.Name = "textBoxWset";
            this.textBoxWset.Size = new System.Drawing.Size(100, 26);
            this.textBoxWset.TabIndex = 5;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(180, 37);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 26);
            this.textBoxID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Handles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Private Bytes ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Working Set ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Load %";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(35, 313);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 31);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numericUpDownSeconds
            // 
            this.numericUpDownSeconds.Location = new System.Drawing.Point(35, 259);
            this.numericUpDownSeconds.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownSeconds.TabIndex = 4;
            this.numericUpDownSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeconds.ValueChanged += new System.EventHandler(this.numericUpDownSeconds_ValueChanged);
            // 
            // textBoxProcess
            // 
            this.textBoxProcess.Location = new System.Drawing.Point(190, 53);
            this.textBoxProcess.Name = "textBoxProcess";
            this.textBoxProcess.Size = new System.Drawing.Size(323, 26);
            this.textBoxProcess.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Interval, Sec.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Process name:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(529, 36);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 43);
            this.buttonBrowse.TabIndex = 8;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxBeep
            // 
            this.checkBoxBeep.AutoSize = true;
            this.checkBoxBeep.Checked = true;
            this.checkBoxBeep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBeep.Location = new System.Drawing.Point(31, 126);
            this.checkBoxBeep.Name = "checkBoxBeep";
            this.checkBoxBeep.Size = new System.Drawing.Size(73, 24);
            this.checkBoxBeep.TabIndex = 9;
            this.checkBoxBeep.Text = "Beep";
            this.checkBoxBeep.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 387);
            this.Controls.Add(this.checkBoxBeep);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxProcess);
            this.Controls.Add(this.numericUpDownSeconds);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Process Info";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownSeconds;
        private System.Windows.Forms.TextBox textBoxHandles;
        private System.Windows.Forms.TextBox textBoxPrivateBytes;
        private System.Windows.Forms.TextBox textBoxWset;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxBeep;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem viewLogFileToolStripMenuItem;
    }
}

