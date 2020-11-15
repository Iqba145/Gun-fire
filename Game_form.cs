using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunShoot_game
{
    public partial class Game_form : Form
    {
        public Game_form()
        {
            InitializeComponent();
        }
        //Game form Load function will disable all the buttons except load button
        private void Game_form_Load(object sender, EventArgs e)
        {
            btn_Spin.Enabled = false; //disabling the Spin button
            btn_Shoot.Enabled = false;
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            btn_Spin.Enabled = true;
            btn_Load.Enabled = false;

        }

        private void btn_Spin_Click(object sender, EventArgs e)
        {
            btn_Shoot.Enabled = true;
            btn_Spin.Enabled = false;
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            btn_Load.Enabled = true;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Shoot_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(GunShoot_game.Properties.Resources.Shoot.);
            Sound_Object.Play();
        }
    }
}
