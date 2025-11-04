using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pacman_Click(object sender, EventArgs e)
        {

        }
        bool goup, godown, goleft, goright = false;
        int score = 0;
        PictureBox[] pictureBoxes = new PictureBox[22];
        Panel[] panel = new Panel[22];




        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goup == true)
            {
                pacman.Top -= pacmanspeed;
                pacman.Image = Properties.Resources.pacmanup;
            }
            if (godown == true)
            {
                pacman.Top += pacmanspeed;
                pacman.Image = Properties.Resources.pacmandown;
            }
            if (goleft == true)
            {
                pacman.Left -= pacmanspeed;
                pacman.Image = Properties.Resources.pacmanleft;
            }
            if (goright == true)
            {
                pacman.Left += pacmanspeed;
                pacman.Image = Properties.Resources.pacman;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                if (pictureBox1.Visible)
                {
                    score += 1;
                }
                pictureBox11.Visible = false;
            }
            for (int i = 0; i < 22; i++)
            { 
                if (pacman.Bounds.IntersectsWith(pictureBoxes[i].Bounds))
                {
                    pictureBoxes[i].Visible = false;
                    score += 1;
                }
             }
            for (int a = 0; a < 11; a++)
            {
                if (pacman.Bounds.IntersectsWith(panel[a].Bounds))
                {
                    goup = godown = goleft = goright = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            timer1.Enabled = Enabled;
            pictureBoxes = new PictureBox[22]
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9,
                pictureBox10,
                pictureBox11,
                pictureBox12,
                pictureBox13,
                pictureBox14,
                pictureBox15,
                pictureBox16,
                pictureBox17,
                pictureBox18,
                pictureBox19,
                pictureBox20,
                pictureBox21,
                pictureBox22,
            };
            panel = new Panel[11]
            {
                panel1,
                panel2,
                panel3,
                panel4,
                panel5,
                panel6,
                panel7,
                panel8,

                panel9,
                panel10,
                panel11,
            };
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up)
            //{
            //    goup = false;
            //}
            //if (e.KeyCode == Keys.Down)
            //{
            //    godown = false;
            //}
            //if (e.KeyCode == Keys.Left)
            //{
            //    goleft = false;
            //}
            //if (e.KeyCode == Keys.Right)
            //{
            //    goright = false;
            //}
        }

        int pacmanspeed = 2;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            goup = godown = goleft = goright = false;
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            
        }
    }
}
