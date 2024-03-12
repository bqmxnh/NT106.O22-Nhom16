
namespace PictureViewer
{
    partial class PictureViewer
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
            this.nutChoose = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nutChoose
            // 
            this.nutChoose.Location = new System.Drawing.Point(12, 12);
            this.nutChoose.Name = "nutChoose";
            this.nutChoose.Size = new System.Drawing.Size(116, 53);
            this.nutChoose.TabIndex = 0;
            this.nutChoose.Text = "Choose File to Open";
            this.nutChoose.UseVisualStyleBackColor = true;
            this.nutChoose.Click += new System.EventHandler(this.button1_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(128, 71);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(651, 361);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // PictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.nutChoose);
            this.Name = "PictureViewer";
            this.Text = "Picture Viewer";
            this.Load += new System.EventHandler(this.PictureViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nutChoose;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}

