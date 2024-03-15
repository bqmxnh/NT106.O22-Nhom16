namespace WindowsFormsApp1
{
    partial class FileExplorer
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
            this.backbtn.Location = new System.Drawing.Point(15, 15);
            this.backbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(53, 29);
            this.backbtn.TabIndex = 0;
            this.backbtn.Text = "<<";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // forwardbtn
            // 
            this.forwardbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.forwardbtn.Location = new System.Drawing.Point(74, 15);
            this.forwardbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.forwardbtn.Name = "forwardbtn";
            this.forwardbtn.Size = new System.Drawing.Size(53, 29);
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
            this.label1.Location = new System.Drawing.Point(134, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // pathtxt
            // 
            this.pathtxt.Location = new System.Drawing.Point(182, 16);
            this.pathtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathtxt.Name = "pathtxt";
            this.pathtxt.ReadOnly = true;
            this.pathtxt.Size = new System.Drawing.Size(792, 26);
            this.pathtxt.TabIndex = 2;
            this.pathtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxkeydown);
            // 
            // opentbtn
            // 
            this.opentbtn.AutoSize = true;
            this.opentbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.opentbtn.Location = new System.Drawing.Point(981, 12);
            this.opentbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opentbtn.Name = "opentbtn";
            this.opentbtn.Size = new System.Drawing.Size(58, 30);
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
            this.webBrowser1.Location = new System.Drawing.Point(15, 51);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(22, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1023, 775);
            this.webBrowser1.TabIndex = 3;
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1051, 841);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pathtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opentbtn);
            this.Controls.Add(this.forwardbtn);
            this.Controls.Add(this.backbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FileExplorer";
            this.Text = "File Explorer";
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