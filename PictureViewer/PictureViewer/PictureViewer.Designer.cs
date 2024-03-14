
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureViewer));
            this.nutChoose = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelThumbnails = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.flowLayoutPanelThumbnails.SuspendLayout();
            this.SuspendLayout();
            // 
            // nutChoose
            // 
            this.nutChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutChoose.Location = new System.Drawing.Point(12, 63);
            this.nutChoose.Name = "nutChoose";
            this.nutChoose.Size = new System.Drawing.Size(116, 186);
            this.nutChoose.TabIndex = 0;
            this.nutChoose.Text = "Choose File to Open";
            this.nutChoose.UseVisualStyleBackColor = true;
            this.nutChoose.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMain.Location = new System.Drawing.Point(12, 326);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(746, 333);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // flowLayoutPanelThumbnails
            // 
            this.flowLayoutPanelThumbnails.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelThumbnails.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanelThumbnails.Location = new System.Drawing.Point(134, 12);
            this.flowLayoutPanelThumbnails.Name = "flowLayoutPanelThumbnails";
            this.flowLayoutPanelThumbnails.Size = new System.Drawing.Size(624, 308);
            this.flowLayoutPanelThumbnails.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(36, 12);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // PictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(770, 671);
            this.Controls.Add(this.flowLayoutPanelThumbnails);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.nutChoose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PictureViewer";
            this.Text = "Picture Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.flowLayoutPanelThumbnails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nutChoose;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelThumbnails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

