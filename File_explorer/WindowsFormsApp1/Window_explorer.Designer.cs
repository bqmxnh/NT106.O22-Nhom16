namespace WindowsFormsApp1
{
    partial class Window_explorer
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
            this.backbtn = new System.Windows.Forms.Button();
            this.forwardbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathtxt = new System.Windows.Forms.TextBox();
            this.opentbtn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backbtn.Location = new System.Drawing.Point(13, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(47, 23);
            this.backbtn.TabIndex = 0;
            this.backbtn.Text = "<<";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // forwardbtn
            // 
            this.forwardbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.forwardbtn.Location = new System.Drawing.Point(66, 12);
            this.forwardbtn.Name = "forwardbtn";
            this.forwardbtn.Size = new System.Drawing.Size(47, 23);
            this.forwardbtn.TabIndex = 0;
            this.forwardbtn.Text = ">>";
            this.forwardbtn.UseVisualStyleBackColor = true;
            this.forwardbtn.Click += new System.EventHandler(this.forwardbtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // pathtxt
            // 
            this.pathtxt.Location = new System.Drawing.Point(162, 13);
            this.pathtxt.Name = "pathtxt";
            this.pathtxt.ReadOnly = true;
            this.pathtxt.Size = new System.Drawing.Size(704, 22);
            this.pathtxt.TabIndex = 2;
            this.pathtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxkeydown);
            // 
            // opentbtn
            // 
            this.opentbtn.AutoSize = true;
            this.opentbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.opentbtn.Location = new System.Drawing.Point(872, 10);
            this.opentbtn.Name = "opentbtn";
            this.opentbtn.Size = new System.Drawing.Size(50, 26);
            this.opentbtn.TabIndex = 0;
            this.opentbtn.Text = "Open";
            this.opentbtn.UseVisualStyleBackColor = true;
            this.opentbtn.Click += new System.EventHandler(this.opentbtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(13, 41);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(909, 620);
            this.webBrowser1.TabIndex = 3;
            // 
            // Window_explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(934, 673);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pathtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opentbtn);
            this.Controls.Add(this.forwardbtn);
            this.Controls.Add(this.backbtn);
            this.Name = "Window_explorer";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button forwardbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathtxt;
        private System.Windows.Forms.Button opentbtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}