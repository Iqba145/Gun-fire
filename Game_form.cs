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

        private void Game_form_Load(object sender, EventArgs e)
        {
            btn_Spin.Enabled = false;
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

        private void Btn_PlayAgain_Click(object sender, EventArgs e)
        {
            btn_Load.Enabled = true;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = false;
        }
    }
}
