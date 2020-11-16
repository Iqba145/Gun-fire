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
        private void btn_Shoot_Click(object sender, EventArgs e)
        {
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = true;
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(GunShoot_game.Properties.Resources.Sound);

            Sound_Object.Play();
        }

        private void btn_Load_Click_1(object sender, EventArgs e)
        {
                btn_Spin.Enabled = true;
                btn_Load.Enabled = false;
                //code to display image in picture box on button click  
                System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream myStream = myAssembly.GetManifestResourceStream("GunShoot_game.Resources.Load.jpg");
                Bitmap bmp_Object = new Bitmap(myStream);
                picture.Image = bmp_Object;
            }

        private void btn_Spin_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream myStream = myAssembly.GetManifestResourceStream("GunShoot_game.Resources.tenor.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            picture.Image = bmp_Object;
        }

        private void btn_Shootaway_Click(object sender, EventArgs e)
        {

        }

        private void btn_Playagain_Click_1(object sender, EventArgs e)
        {
            btn_Load.Enabled = true;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }
    }
    }

