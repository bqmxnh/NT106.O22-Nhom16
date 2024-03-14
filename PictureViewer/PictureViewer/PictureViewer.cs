using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class PictureViewer : Form
    {
        private List<string> imageFiles; // Danh sach cac tep hinh anh
        private int currentImageIndex = 0; // Chi so cua cac hinh anh hien tai

        public PictureViewer()
        {
            InitializeComponent();
        }

        // Khi nguoi dung nhan nut Choose File to Open
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;// Cho phep chon nhieu tep
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";// Dinh dang cac tep hinh anh
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageFiles = ofd.FileNames.ToList();// Hien thi danh sach hinh anh
                DisplayThumbnails();// Hien thi cac hinh anh da chon
                DisplayCurrentImage();// Hien thi hinh anh hien tai
            }
        }
        // Khu vuc hien thi danh sach hinh anh
        private void DisplayThumbnails()
        {
            flowLayoutPanelThumbnails.Controls.Clear();// Xoa cac hinh anh cu

            foreach (string imagePath in imageFiles)
            {
                PictureBox pictureBox = new PictureBox();// Tao cac PictureBox moi
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;// Che do hien thi: StrechImage
                pictureBox.Width = 100; // Rong PictureBox
                pictureBox.Height = 100; // Cao PictureBox
                pictureBox.Margin = new Padding(5); // Khoang cach giua cac hinh anh
                pictureBox.Image = Image.FromFile(imagePath); // Dat hinh anh cho PictureBox
                pictureBox.Click += Thumbnail_Click;// Them su kien Click cho PictureBox 
                flowLayoutPanelThumbnails.Controls.Add(pictureBox); // Them hinh anh
            }
        }

        private void DisplayCurrentImage()
        {
            if (imageFiles != null && imageFiles.Count > 0)
            {
                if (currentImageIndex < 0)
                    currentImageIndex = 0;// Gioi han duoi
                else if (currentImageIndex >= imageFiles.Count)
                    currentImageIndex = imageFiles.Count - 1; // Gioi han tren

                string currentImagePath = imageFiles[currentImageIndex];// Lay duong dan hinh anh
                pictureBoxMain.Image = Image.FromFile(currentImagePath);// Dat hinh anh vao trong PictureBoxMain
            }
        }
        // Khi nguoi dung nhan vao mot hinh anh thi nho
        private void Thumbnail_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox; // Lay hinh anh da duoc click ra
            int index = flowLayoutPanelThumbnails.Controls.IndexOf(clickedPictureBox);// Xac dinh chi so hinh anh
            currentImageIndex = index;// Xac dinh chi so hinh anh hien tai
            DisplayCurrentImage(); // Hien thi hinh anh
        }
        // Khi nguoi dung nhan left-right arrows 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                currentImageIndex--;// Chuyen ve hinh anh truoc do
                DisplayCurrentImage();// Hien thi hinh anh
                return true;
            }
            else if (keyData == Keys.Right)
            {
                currentImageIndex++;// Chuyen den hinh anh tiep theo
                DisplayCurrentImage();// Hien thi hinh anh
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
