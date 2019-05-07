using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Skybox
{
    public partial class MainForm : Form
    {
        private string folderPath;
        private string filePath;
        private Image orgImage = null;

        public MainForm()
        {
            InitializeComponent();

            folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).ToString();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (orgImage != null)
            {
                try
                { 
                    Bitmap bmSkyLeft = new Bitmap(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3);
                    Bitmap bmSkyRight = new Bitmap(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3);
                    Bitmap bmSkyTop = new Bitmap(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3);
                    Bitmap bmSkyBottom = new Bitmap(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3);
                    Bitmap bmSkyFront = new Bitmap(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3);
                    Bitmap bmSkyBack = new Bitmap(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3);
                    Rectangle dstRect = new Rectangle(new Point(0, 0), new Size(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3));

                    using (Graphics gr = Graphics.FromImage(bmSkyLeft))
                    {
                        Rectangle srcRect = new Rectangle(new Point(0, pictureBox.Image.Height / 3), new Size(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3));
                        gr.DrawImage(orgImage, dstRect, srcRect, GraphicsUnit.Pixel);

                        bmSkyLeft.Save(folderPath + "/skyleft.bmp", ImageFormat.Bmp);
                    }

                    using (Graphics gr = Graphics.FromImage(bmSkyRight))
                    {
                        Rectangle srcRect = new Rectangle(new Point(2 * pictureBox.Image.Width / 4, pictureBox.Image.Height / 3), new Size(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3));
                        gr.DrawImage(orgImage, dstRect, srcRect, GraphicsUnit.Pixel);

                        bmSkyRight.Save(folderPath + "/skyright.bmp", ImageFormat.Bmp);
                    }

                    using (Graphics gr = Graphics.FromImage(bmSkyTop))
                    {
                        Rectangle srcRect = new Rectangle(new Point(pictureBox.Image.Width / 4, 0), new Size(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3));
                        gr.DrawImage(orgImage, dstRect, srcRect, GraphicsUnit.Pixel);

                        bmSkyTop.Save(folderPath + "/skytop.bmp", ImageFormat.Bmp);
                    }

                    using (Graphics gr = Graphics.FromImage(bmSkyBottom))
                    {
                        Rectangle srcRect = new Rectangle(new Point(pictureBox.Image.Width / 4, 2 * pictureBox.Image.Height / 3), new Size(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3));
                        gr.DrawImage(orgImage, dstRect, srcRect, GraphicsUnit.Pixel);

                        bmSkyBottom.Save(folderPath + "/skybottom.bmp", ImageFormat.Bmp);
                    }

                    using (Graphics gr = Graphics.FromImage(bmSkyFront))
                    {
                        Rectangle srcRect = new Rectangle(new Point(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3), new Size(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3));
                        gr.DrawImage(orgImage, dstRect, srcRect, GraphicsUnit.Pixel);

                        bmSkyFront.Save(folderPath + "/skyfront.bmp", ImageFormat.Bmp);
                    }

                    using (Graphics gr = Graphics.FromImage(bmSkyBack))
                    {
                        Rectangle srcRect = new Rectangle(new Point(3 * pictureBox.Image.Width / 4, pictureBox.Image.Height / 3), new Size(pictureBox.Image.Width / 4, pictureBox.Image.Height / 3));
                        gr.DrawImage(orgImage, dstRect, srcRect, GraphicsUnit.Pixel);

                        bmSkyBack.Save(folderPath + "/skyback.bmp", ImageFormat.Bmp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Can't save images: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(this, "Images saved in: " + folderPath, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = folderPath; 
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)| *.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                folderPath = Path.GetDirectoryName(filePath);

                try
                {
                    Image image = new Bitmap(filePath);
                    orgImage = new Bitmap(image);
                    pictureBox.Image = image;
                } catch (Exception ex)
                {
                    MessageBox.Show(this, "This file is not a (readable) image: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                numericUpDownOffsetX.Value = 0;
                numericUpDownOffsetY.Value = 0;

                DrawLines();
            }
        }

        private void NumericUpDownOffsetX_ValueChanged(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(filePath);

            int offsetX = Convert.ToInt32(numericUpDownOffsetX.Value);
            int offsetY = Convert.ToInt32(numericUpDownOffsetY.Value);

            Rectangle rect;
            if (offsetX >= 0)
            {
                if (offsetY >= 0)
                {
                    rect = new Rectangle(offsetX, offsetY, bitmap.Width - offsetX, bitmap.Height - offsetY);
                } else
                {
                    rect = new Rectangle(offsetX, 0, bitmap.Width - offsetX, bitmap.Height + offsetY);
                }
            }
            else
            {
                if (offsetY >= 0)
                {
                    rect = new Rectangle(0, offsetY, bitmap.Width + offsetX, bitmap.Height - offsetY);
                }
                {
                    rect = new Rectangle(0, 0, bitmap.Width + offsetX, bitmap.Height + offsetY);
                }
            }

            orgImage = bitmap.Clone(rect, 0);

            Image image = new Bitmap(orgImage);
            pictureBox.Image = image;

            DrawLines();
        }

        private void NumericUpDownOffsetY_ValueChanged(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(filePath);

            int offsetX = Convert.ToInt32(numericUpDownOffsetX.Value);
            int offsetY = Convert.ToInt32(numericUpDownOffsetY.Value);

            Rectangle rect;
            if (offsetX >= 0)
            {
                if (offsetY >= 0)
                {
                    rect = new Rectangle(offsetX, offsetY, bitmap.Width - offsetX, bitmap.Height - offsetY);
                }
                else
                {
                    rect = new Rectangle(offsetX, 0, bitmap.Width - offsetX, bitmap.Height + offsetY);
                }
            }
            else
            {
                if (offsetY >= 0)
                {
                    rect = new Rectangle(0, offsetY, bitmap.Width + offsetX, bitmap.Height - offsetY);
                }
                {
                    rect = new Rectangle(0, 0, bitmap.Width + offsetX, bitmap.Height + offsetY);
                }
            }

            orgImage = bitmap.Clone(rect, 0);

            Image image = new Bitmap(orgImage);
            pictureBox.Image = image;

            DrawLines();
        }

        void DrawLines()
        {
            int offsetX = Convert.ToInt32(numericUpDownOffsetX.Value);
            int offsetY = Convert.ToInt32(numericUpDownOffsetY.Value);

            int width = pictureBox.Image.Width;
            int height = pictureBox.Image.Height;

            Graphics g = Graphics.FromImage(pictureBox.Image);
            Pen pen = new Pen(Color.Red);
            g.DrawLine(pen, 0, height / 3, width, height / 3);
            g.DrawLine(pen, 0, 2 * height / 3, width, 2 * height / 3);

            g.DrawLine(pen, width / 4, 0, width / 4, height);
            g.DrawLine(pen, 2 * width / 4, 0, 2 * width / 4, height);
            g.DrawLine(pen, 3 * width / 4, height / 3, 3 * width / 4, 2 * height / 3);

            g.Dispose();
        }
    }
}
