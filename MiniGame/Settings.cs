using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace MiniGame
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        string p1_name = "Игрок 1";
        string p2_name = "Игрок 2";
        string pictureDir_1 = Convert.ToString(Properties.Resources.X);
        string pictureDir_2 = Convert.ToString(Properties.Resources._0);

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pb_picture_p1.Image = new Bitmap(openFile.FileName);
                    pictureDir_1 = openFile.FileName;
                    l_pictureName_p1.Text = openFile.SafeFileName;
                }
                catch
                {
                    MessageBox.Show("Неверный файл!");
                }
            }
        }

        private void b_getPicture2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pb_picture_p2.Image = new Bitmap(openFile.FileName);
                    pictureDir_2 = openFile.FileName;
                    l_pictureName_p2.Text = openFile.SafeFileName;
                }
                catch
                {
                    MessageBox.Show("Неверный файл!");
                }
            }
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            Form1 f_main = new Form1();

            this.Hide();
            f_main.Show();
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            pb_picture_p1.Image = Properties.Resources.X;
            pb_picture_p2.Image = Properties.Resources._0;

            tb_name_p1.Text = p1_name;
            l_pictureName_p1.Text = "Standart";

            tb_name_p2.Text = p2_name;
            l_pictureName_p2.Text = "Standart";
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey miniGame = currentUserKey.OpenSubKey("MiniGame", true);

            miniGame.SetValue("Player_1", tb_name_p1.Text);
            miniGame.SetValue("Image_1", pictureDir_1);

            miniGame.SetValue("Player_2", tb_name_p2.Text);
            miniGame.SetValue("Image_2", pictureDir_2);

            tb_name_p1.Text = miniGame.GetValue("Player_1").ToString();
            try
            {
                pb_picture_p1.Image = new Bitmap(pictureDir_1);
            }
            catch { }
            tb_name_p2.Text = miniGame.GetValue("Player_2").ToString();
            try
            {
                pb_picture_p2.Image = new Bitmap(pictureDir_2);
            }
            catch { }

            miniGame.Close();
        }
    }
}
