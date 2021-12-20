namespace ProcInfo
{
    partial class ViewLog
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
            this.richTextBoxView = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxView
            // 
            this.richTextBoxView.Location = new System.Drawing.Point(4, 12);
            this.richTextBoxView.Name = "richTextBoxView";
            this.richTextBoxView.Size = new System.Drawing.Size(961, 360);
            this.richTextBoxView.TabIndex = 0;
            this.richTextBoxView.Text = "";
            // 
            // ViewLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 384);
            this.Controls.Add(this.richTextBoxView);
            this.MaximumSize = new System.Drawing.Size(999, 440);
            this.Name = "ViewLog";
            this.Text = "ViewLog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxView;
    }
}