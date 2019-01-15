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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Settings f_settings = new Settings();

            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey miniGame = currentUserKey.CreateSubKey("MiniGame");

            miniGame.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PVP f_pvp = new PVP();

            this.Hide();
            f_pvp.ShowDialog();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey miniGame = currentUserKey.OpenSubKey("MiniGame", true);
            if (miniGame.GetValue("Player_1") == null)
            {
                miniGame.SetValue("Player_1", "Игрок 1");
            }

            if (miniGame.GetValue("Player_2") == null)
            {
                miniGame.SetValue("Player_2", "Игрок 2");
            }
            if (miniGame.GetValue("Image_1") == null)
            {
                miniGame.SetValue("Image_1", "Игрок 1");
            }

            if (miniGame.GetValue("Image_2") == null)
            {
                miniGame.SetValue("Image_2", "Игрок 2");
            }

            miniGame.DeleteValue("Player_1");
            miniGame.DeleteValue("Player_2");
            miniGame.Close();
            currentUserKey.DeleteSubKey("MiniGame");

            Application.Exit();
        }

        private void b_PVA_Click(object sender, EventArgs e)
        {
            PVA f_pva = new PVA();

            this.Hide();
            f_pva.ShowDialog();
        }

        private void b_settings_Click(object sender, EventArgs e)
        {
            Settings f_settings = new Settings();

            this.Hide();
            f_settings.ShowDialog();
        }
    }
}
