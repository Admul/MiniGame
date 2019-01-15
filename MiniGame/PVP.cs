using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MiniGame
{
    public partial class PVP : Form
    {
        string p1_name;
        string p1_image;

        string p2_name;
        string p2_image;

        public PVP()
        {
            InitializeComponent();

            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey miniGame = currentUserKey.CreateSubKey("MiniGame");

            // Проверка на присутсвие ключа Player_1 в реестре
            if(miniGame.GetValue("Player_1") == null)
            {
                miniGame.SetValue("Player_1", "Игрок 1");
                p1_name = miniGame.GetValue("Player_1").ToString();
            }
            else
            {
                p1_name = miniGame.GetValue("Player_1").ToString();
            }
            // Проверка на присутсвие ключа Player_2 в реестре
            if (miniGame.GetValue("Player_2") == null)
            {
                miniGame.SetValue("Player_2", "Игрок 2");
                p2_name = miniGame.GetValue("Player_2").ToString();
            }
            else
            {
                p2_name = miniGame.GetValue("Player_2").ToString();
            }
            // Проверка на присутсвие ключа Image_1 в реестре
            if (miniGame.GetValue("Image_1") == null)
            {
                Image pictureDir_1 = Properties.Resources.X;
                miniGame.SetValue("Image_1", pictureDir_1);
                p1_image = miniGame.GetValue("Image_1").ToString();
            }
            else
            {
                p1_image = miniGame.GetValue("Image_1").ToString();
            }
            // Проверка на присутсвие ключа Image_2 в реестре
            if (miniGame.GetValue("Image_2") == null)
            {
                Image pictureDir_2 = Properties.Resources._0;
                miniGame.SetValue("Image_2", pictureDir_2);
                p2_image = miniGame.GetValue("Image_2").ToString();
            }
            else
            {
                p2_image = miniGame.GetValue("Image_2").ToString();
            }

            miniGame.Close();
            tb_move.Text = $"Ходит: {p1_name}";
        }

        Form1 f_main = new Form1();
        Settings f_settings = new Settings();

        bool move = true;
        int[] cells = 
            {0, 0, 0,
            0, 0, 0,
            0, 0, 0};

        private void pb_cell_1_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                Image_set_1(0);
                cells[0] = 1;
                tb_move.Text = $"Ходит: {p2_name}";
            }
            else
            {
                move = true;

                pb_cell_1.Image = new Bitmap(p2_image);
                cells[0] = 10;
                tb_move.Text = $"Ходит: {p1_name}";
            }

            tb_move.Refresh();
            pb_cell_1.Enabled = false;

            f_test();

        }

        private void pb_cell_2_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                Image_set_1(1);
                cells[1] = 1;
                tb_move.Text = $"Ходит: {p2_name}";
            }
            else
            {
                move = true;

                Image_set_2(1);
                cells[1] = 10;
                tb_move.Text = $"Ходит: {p1_name}";
            }

            tb_move.Refresh();
            pb_cell_2.Enabled = false;

            f_test();
        }

        private void pb_cell_3_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                Image_set_1(2);
                cells[2] = 1;
                tb_move.Text = $"Ходит: {p2_name}";
            }
            else
            {
                move = true;

                Image_set_2(2);
                cells[2] = 10;
                tb_move.Text = $"Ходит: {p1_name}";
            }

            tb_move.Refresh();
            pb_cell_3.Enabled = false;

            f_test();
        }

        private void pb_cell_4_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                Image_set_1(3);
                cells[3] = 1;
                tb_move.Text = $"Ходит: {p2_name}";
            }
            else
            {
                move = true;

                Image_set_2(3);
                cells[3] = 10;
                tb_move.Text = $"Ходит: {p1_name}";
            }

            tb_move.Refresh();
            pb_cell_4.Enabled = false;

            f_test();
        }

        private void pb_cell_5_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                Image_set_1(4);
                cells[4] = 1;
                tb_move.Text = $"Ходит: {p2_name}";
            }
            else
            {
                move = true;

                Image_set_2(4);
                cells[4] = 10;
                tb_move.Text = $"Ходит: {p1_name}";
            }

            tb_move.Refresh();
            pb_cell_5.Enabled = false;

            f_test();
        }

        private void pb_cell_6_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                Image_set_1(5);
                cells[5] = 1;
                tb_move.Text = $"Ходит: {p2_name}";
            }
            else
            {
                move = true;

                Image_set_2(5);
                cells[5] = 10;
                tb_move.Text = $"Ходит: {p1_name}";
            }

            tb_move.Refresh();
            pb_cell_6.Enabled = false;

            f_test();
        }

        private void pb_cell_7_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                Image_set_1(6); ;
                cells[6] = 1;
                tb_move.Text = $"Ходит: {p2_name}";
            }
            else
            {
                move = true;

                Image_set_2(6);
                cells[6] = 10;
                tb_move.Text = $"Ходит: {p1_name}";
            }

            tb_move.Refresh();
            pb_cell_7.Enabled = false;

            f_test();
        }

        private void pb_cell_8_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                Image_set_1(7);
                cells[7] = 1;
                tb_move.Text = $"Ходит: {p2_name}";
            }
            else
            {
                move = true;

                Image_set_2(7);
                cells[7] = 10;
                tb_move.Text = $"Ходит: {p1_name}";
            }

            tb_move.Refresh();
            pb_cell_8.Enabled = false;

            f_test();
        }

        private void pb_cell_9_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                Image_set_1(8);
                cells[8] = 1;
                tb_move.Text = $"Ходит: {p2_name}";
            }
            else
            {
                move = true;

                Image_set_2(8);
                cells[8] = 10;
                tb_move.Text = $"Ходит: {p1_name}";
            }

            tb_move.Refresh();
            pb_cell_9.Enabled = false;

            f_test();
        }

        public void f_test()
        {
            if (cells[0] + cells[1] + cells[2] == 3)
            {
                MessageBox.Show($"Выйграл: {p1_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[0] + cells[4] + cells[8] == 3)
            {
                MessageBox.Show($"Выйграл: {p1_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[0] + cells[3] + cells[6] == 3)
            {
                MessageBox.Show($"Выйграл: {p1_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[2] + cells[4] + cells[6] == 3)
            {
                MessageBox.Show($"Выйграл: {p1_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[2] + cells[5] + cells[8] == 3)
            {
                MessageBox.Show($"Выйграл: {p1_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[3] + cells[4] + cells[5] == 3)
            {
                MessageBox.Show($"Выйграл: {p1_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[1] + cells[4] + cells[7] == 3)
            {
                MessageBox.Show($"Выйграл: {p1_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[6] + cells[7] + cells[8] == 3)
            {
                MessageBox.Show($"Выйграл: {p1_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[0] + cells[1] + cells[2] == 30)
            {
                MessageBox.Show($"Выйграл: {p2_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[0] + cells[4] + cells[8] == 30)
            {
                MessageBox.Show($"Выйграл: {p2_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[0] + cells[3] + cells[6] == 30)
            {
                MessageBox.Show($"Выйграл: {p2_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[2] + cells[4] + cells[6] == 30)
            {
                MessageBox.Show($"Выйграл: {p2_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[2] + cells[5] + cells[8] == 30)
            {
                MessageBox.Show($"Выйграл: {p2_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[3] + cells[4] + cells[5] == 30)
            {
                MessageBox.Show($"Выйграл: {p2_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[1] + cells[4] + cells[7] == 30)
            {
                MessageBox.Show($"Выйграл: {p2_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[6] + cells[7] + cells[8] == 30)
            {
                MessageBox.Show($"Выйграл: {p2_name}");

                this.Close();
                f_main.Show();
            }
            else if (cells[0] + cells[1] + cells[2] +
                cells[3] + cells[4] + cells[5] +
                cells[6] + cells[7] + cells[8] == 45)
            {
                MessageBox.Show("Ничья");

                this.Close();
                f_main.Show();
            }
        }

        public void Image_set_1(int x)
        {
            List<PictureBox> cells = new List<PictureBox>
            {
                pb_cell_1,
                pb_cell_2,
                pb_cell_3,
                pb_cell_4,
                pb_cell_5,
                pb_cell_6,
                pb_cell_7,
                pb_cell_8,
                pb_cell_9,
            };

            if(p1_image == Properties.Resources.X.ToString())
            {
                cells[x].Image = Properties.Resources.X;
            }
            else
            {
                cells[x].Image = new Bitmap(p1_image);
            }
        }

        public void Image_set_2(int x)
        {
            List<PictureBox> cells = new List<PictureBox>
            {
                pb_cell_1,
                pb_cell_2,
                pb_cell_3,
                pb_cell_4,
                pb_cell_5,
                pb_cell_6,
                pb_cell_7,
                pb_cell_8,
                pb_cell_9,
            };

            if (p2_image == Properties.Resources.X.ToString())
            {
                cells[x].Image = Properties.Resources._0;
            }
            else
            {
                cells[x].Image = new Bitmap(p2_image);
            }
        }

        private void PVP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f_main.Show();
        }
    }
}
