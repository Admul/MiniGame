using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class PVA : Form
    {
        public PVA()
        {
            InitializeComponent();
        }

        bool move = true;
        bool move_set = true;
        bool end_c = true;
        int[] cells =
            {0, 0, 0,
            0, 0, 0,
            0, 0, 0};

        Form1 f_main = new Form1();



        private void pb_cell_1_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                cells[0] = 1;
                pb_cell_1.Image = Properties.Resources.X;
                pb_cell_1.Enabled = false;
            }

            f_test();
            if(move_set == true) bot();
        }

        private void pb_cell_2_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                cells[1] = 1;
                pb_cell_2.Image = Properties.Resources.X;
                pb_cell_2.Enabled = false;
            }

            f_test();
            if (move_set == true) bot();
        }

        private void pb_cell_3_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                cells[2] = 1;
                pb_cell_3.Image = Properties.Resources.X;
                pb_cell_3.Enabled = false;
            }

            f_test();
            if (move_set == true) bot();
        }

        private void pb_cell_4_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                cells[3] = 1;
                pb_cell_4.Image = Properties.Resources.X;
                pb_cell_4.Enabled = false;
            }

            f_test();
            if (move_set == true) bot();
        }

        private void pb_cell_5_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                cells[4] = 1;
                pb_cell_5.Image = Properties.Resources.X;
                pb_cell_5.Enabled = false;
            }

            f_test();
            if (move_set == true) bot();
        }

        private void pb_cell_6_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                cells[5] = 1;
                pb_cell_6.Image = Properties.Resources.X;
                pb_cell_6.Enabled = false;
            }

            f_test();
            if (move_set == true) bot();
        }

        private void pb_cell_7_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                cells[6] = 1;
                pb_cell_7.Image = Properties.Resources.X;
                pb_cell_7.Enabled = false;
            }

            f_test();
            if (move_set == true) bot();
        }

        private void pb_cell_8_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                cells[7] = 1;
                pb_cell_8.Image = Properties.Resources.X;
                pb_cell_8.Enabled = false;
            }

            f_test();
            if (move_set == true) bot();
        }

        private void pb_cell_9_Click(object sender, EventArgs e)
        {
            if (move)
            {
                move = false;

                cells[8] = 1;
                pb_cell_9.Image = Properties.Resources.X;
                pb_cell_9.Enabled = false;
            }

            f_test();
            if (move_set == true) bot();
        }

        public void bot()
        {
            bool[] cells_test =
            {
                cells[0] == 0 && cells[1] == 1 && cells[2] == 1 ||
                cells[0] == 0 && cells[1] == 10 && cells[2] == 10,
                cells[0] == 1 && cells[1] == 0 && cells[2] == 1 ||
                cells[0] == 10 && cells[1] == 0 && cells[2] == 10,
                cells[0] == 1 && cells[1] == 1 && cells[2] == 0 ||
                cells[0] == 10 && cells[1] == 10 && cells[2] == 0,
                //------------------------------------------------
                cells[0] == 0 && cells[3] == 1 && cells[6] == 1 ||
                cells[0] == 0 && cells[3] == 10 && cells[6] == 10,
                cells[0] == 1 && cells[3] == 0 && cells[6] == 1 ||
                cells[0] == 10 && cells[3] == 0 && cells[6] == 10,
                cells[0] == 1 && cells[3] == 1 && cells[6] == 0 ||
                cells[0] == 10 && cells[3] == 10 && cells[6] == 0,
                //------------------------------------------------
                cells[0] == 0 && cells[4] == 1 && cells[8] == 1 ||
                cells[0] == 0 && cells[4] == 10 && cells[8] == 10,
                cells[0] == 1 && cells[4] == 0 && cells[8] == 1 ||
                cells[0] == 10 && cells[4] == 0 && cells[8] == 10,
                cells[0] == 1 && cells[4] == 1 && cells[8] == 0 ||
                cells[0] == 10 && cells[4] == 10 && cells[8] == 0,
                //------------------------------------------------
                cells[1] == 0 && cells[4] == 1 && cells[7] == 1 ||
                cells[1] == 0 && cells[4] == 10 && cells[7] == 10,
                cells[1] == 1 && cells[4] == 0 && cells[7] == 1 ||
                cells[1] == 10 && cells[4] == 0 && cells[7] == 10,
                cells[1] == 1 && cells[4] == 1 && cells[7] == 0 ||
                cells[1] == 10 && cells[4] == 10 && cells[7] == 0,
                //------------------------------------------------
                cells[2] == 0 && cells[4] == 1 && cells[6] == 1 ||
                cells[2] == 0 && cells[4] == 10 && cells[6] == 10,
                cells[2] == 1 && cells[4] == 0 && cells[6] == 1 ||
                cells[2] == 10 && cells[4] == 0 && cells[6] == 10,
                cells[2] == 1 && cells[4] == 1 && cells[6] == 0 ||
                cells[2] == 10 && cells[4] == 10 && cells[6] == 0,
                //------------------------------------------------
                cells[2] == 0 && cells[5] == 1 && cells[8] == 1 ||
                cells[2] == 0 && cells[5] == 10 && cells[8] == 10,
                cells[2] == 1 && cells[5] == 0 && cells[8] == 1 ||
                cells[2] == 10 && cells[5] == 0 && cells[8] == 10,
                cells[2] == 1 && cells[5] == 1 && cells[8] == 0 ||
                cells[2] == 10 && cells[5] == 10 && cells[8] == 0,
                //------------------------------------------------
                cells[3] == 0 && cells[4] == 1 && cells[5] == 1 ||
                cells[3] == 0 && cells[4] == 10 && cells[5] == 10,
                cells[3] == 1 && cells[4] == 0 && cells[5] == 1 ||
                cells[3] == 10 && cells[4] == 0 && cells[5] == 10,
                cells[3] == 1 && cells[4] == 1 && cells[5] == 0 ||
                cells[3] == 10 && cells[4] == 10 && cells[5] == 0,
                //------------------------------------------------
                cells[6] == 0 && cells[7] == 1 && cells[8] == 1 ||
                cells[6] == 0 && cells[7] == 10 && cells[8] == 10,
                cells[6] == 1 && cells[7] == 0 && cells[8] == 1 ||
                cells[6] == 10 && cells[7] == 0 && cells[8] == 10,
                cells[6] == 1 && cells[7] == 1 && cells[8] == 0 ||
                cells[6] == 10 && cells[7] == 10 && cells[8] == 0
            };

            List<PictureBox> picBox = new List<PictureBox>
            {
                pb_cell_1,
                pb_cell_2,
                pb_cell_3,
                pb_cell_4,
                pb_cell_5,
                pb_cell_6,
                pb_cell_7,
                pb_cell_8,
                pb_cell_9
            };

            if(cells_test[0])
            {
                if (move == false)
                {
                    move = true;

                    cells[0] = 10;
                    picBox[0].Image = Properties.Resources._0;
                    picBox[0].Enabled = false;
                }

                f_test();
            }
            else if(cells_test[1])
            {
                if (move == false)
                {
                    move = true;

                    cells[1] = 10;
                    picBox[1].Image = Properties.Resources._0;
                    picBox[1].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[2])
            {
                if (move == false)
                {
                    move = true;

                    cells[2] = 10;
                    picBox[2].Image = Properties.Resources._0;
                    picBox[2].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[3])
            {
                if (move == false)
                {
                    move = true;

                    cells[0] = 10;
                    picBox[0].Image = Properties.Resources._0;
                    picBox[0].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[4])
            {
                if (move == false)
                {
                    move = true;

                    cells[3] = 10;
                    picBox[3].Image = Properties.Resources._0;
                    picBox[3].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[5])
            {
                if (move == false)
                {
                    move = true;

                    cells[6] = 10;
                    picBox[6].Image = Properties.Resources._0;
                    picBox[6].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[6])
            {
                if (move == false)
                {
                    move = true;

                    cells[0] = 10;
                    picBox[0].Image = Properties.Resources._0;
                    picBox[0].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[7])
            {
                if (move == false)
                {
                    move = true;

                    cells[4] = 10;
                    picBox[4].Image = Properties.Resources._0;
                    picBox[4].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[8])
            {
                if (move == false)
                {
                    move = true;

                    cells[8] = 10;
                    picBox[8].Image = Properties.Resources._0;
                    picBox[8].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[9])
            {
                if (move == false)
                {
                    move = true;

                    cells[1] = 10;
                    picBox[1].Image = Properties.Resources._0;
                    picBox[1].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[10])
            {
                if (move == false)
                {
                    move = true;

                    cells[4] = 10;
                    picBox[4].Image = Properties.Resources._0;
                    picBox[4].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[11])
            {
                if (move == false)
                {
                    move = true;

                    cells[7] = 10;
                    picBox[7].Image = Properties.Resources._0;
                    picBox[7].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[12])
            {
                if (move == false)
                {
                    move = true;

                    cells[2] = 10;
                    picBox[2].Image = Properties.Resources._0;
                    picBox[2].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[13])
            {
                if (move == false)
                {
                    move = true;

                    cells[4] = 10;
                    picBox[4].Image = Properties.Resources._0;
                    picBox[4].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[14])
            {
                if (move == false)
                {
                    move = true;

                    cells[6] = 10;
                    picBox[6].Image = Properties.Resources._0;
                    picBox[6].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[15])
            {
                if (move == false)
                {
                    move = true;

                    cells[2] = 10;
                    picBox[2].Image = Properties.Resources._0;
                    picBox[2].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[16])
            {
                if (move == false)
                {
                    move = true;

                    cells[5] = 10;
                    picBox[5].Image = Properties.Resources._0;
                    picBox[5].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[17])
            {
                if (move == false)
                {
                    move = true;

                    cells[8] = 10;
                    picBox[8].Image = Properties.Resources._0;
                    picBox[8].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[18])
            {
                if (move == false)
                {
                    move = true;

                    cells[3] = 10;
                    picBox[3].Image = Properties.Resources._0;
                    picBox[3].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[19])
            {
                if (move == false)
                {
                    move = true;

                    cells[4] = 10;
                    picBox[4].Image = Properties.Resources._0;
                    picBox[4].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[20])
            {
                if (move == false)
                {
                    move = true;

                    cells[5] = 10;
                    picBox[5].Image = Properties.Resources._0;
                    picBox[5].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[21])
            {
                if (move == false)
                {
                    move = true;

                    cells[6] = 10;
                    picBox[6].Image = Properties.Resources._0;
                    picBox[6].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[22])
            {
                if (move == false)
                {
                    move = true;

                    cells[7] = 10;
                    picBox[7].Image = Properties.Resources._0;
                    picBox[7].Enabled = false;
                }

                f_test();
            }
            else if (cells_test[23])
            {
                if (move == false)
                {
                    move = true;

                    cells[8] = 10;
                    picBox[8].Image = Properties.Resources._0;
                    picBox[8].Enabled = false;
                }

                f_test();
            }
            else if (cells[4] == 0)
            {
                if (move == false)
                {
                    move = true;

                    cells[4] = 10;
                    picBox[4].Image = Properties.Resources._0;
                    picBox[4].Enabled = false;
                }

                f_test();
            }
            else
            {
                Random cell_random = new Random();
                int cellRandomSet = cell_random.Next(cells.Length);

                if (end_c)
                {
                    while (move == false)
                    {
                        if (cells[cellRandomSet] == 0)
                        {
                            if (move == false)
                            {
                                move = true;

                                cells[cellRandomSet] = 10;
                                picBox[cellRandomSet].Image = Properties.Resources._0;
                                picBox[cellRandomSet].Enabled = false;
                            }

                            f_test();
                        }
                        else
                        {

                            cellRandomSet = cell_random.Next(cells.Length);
                        }
                    }
                }
            }
        }

        public void f_test()
        {
            if (cells[0] + cells[1] + cells[2] == 3)
            {
                MessageBox.Show("Выйграл: игрок");
                move_set = false;

                this.Close();
                f_main.Show();
            }
            else if (cells[0] + cells[4] + cells[8] == 3)
            {
                MessageBox.Show("Выйграл: игрок");
                move_set = false;

                this.Close();
                f_main.Show();
            }
            else if (cells[0] + cells[3] + cells[6] == 3)
            {
                MessageBox.Show("Выйграл: игрок");
                move_set = false;

                this.Close();
                f_main.Show();
            }
            else if (cells[2] + cells[4] + cells[6] == 3)
            {
                MessageBox.Show("Выйграл: игрок");
                move_set = false;

                this.Close();
                f_main.Show();
            }
            else if (cells[2] + cells[5] + cells[8] == 3)
            {
                MessageBox.Show("Выйграл: игрок");
                move_set = false;

                this.Close();
                f_main.Show();
            }
            else if (cells[3] + cells[4] + cells[5] == 3)
            {
                MessageBox.Show("Выйграл: игрок");
                move_set = false;

                this.Close();
                f_main.Show();
            }
            else if (cells[1] + cells[4] + cells[7] == 3)
            {
                MessageBox.Show("Выйграл: игрок");
                move_set = false;

                this.Close();
                f_main.Show();
            }
            else if (cells[6] + cells[7] + cells[8] == 3)
            {
                MessageBox.Show("Выйграл: игрок");
                move_set = false;

                this.Close();
                f_main.Show();
            }
            else if (cells[0] + cells[1] + cells[2] == 30)
            {
                MessageBox.Show("Выйграл: компьютер");

                this.Close();
                f_main.Show();
            }
            else if (cells[0] + cells[4] + cells[8] == 30)
            {
                MessageBox.Show("Выйграл: компьютер");

                this.Close();
                f_main.Show();
            }
            else if (cells[0] + cells[3] + cells[6] == 30)
            {
                MessageBox.Show("Выйграл: компьютер");

                this.Close();
                f_main.Show();
            }
            else if (cells[2] + cells[4] + cells[6] == 30)
            {
                MessageBox.Show("Выйграл: компьютер");

                this.Close();
                f_main.Show();
            }
            else if (cells[2] + cells[5] + cells[8] == 30)
            {
                MessageBox.Show("Выйграл: компьютер");

                this.Close();
                f_main.Show();
            }
            else if (cells[3] + cells[4] + cells[5] == 30)
            {
                MessageBox.Show("Выйграл: компьютер");

                this.Close();
                f_main.Show();
            }
            else if (cells[1] + cells[4] + cells[7] == 30)
            {
                MessageBox.Show("Выйграл: компьютер");

                this.Close();
                f_main.Show();
            }
            else if (cells[6] + cells[7] + cells[8] == 30)
            {
                MessageBox.Show("Выйграл: компьютер");

                this.Close();
                f_main.Show();
            }
            else if (cells[0] + cells[1] + cells[2] +
                cells[3] + cells[4] + cells[5] +
                cells[6] + cells[7] + cells[8] == 45)
            {
                end_c = false;
                MessageBox.Show("Ничья");

                this.Close();
                f_main.Show();
            }
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            Form1 f_main = new Form1();

            this.Close();
            f_main.Show();
        }
    }
}
