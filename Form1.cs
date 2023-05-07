using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_ovladam_klavesnicou
{
    public partial class Form_AutoKlaves : Form
    {
        public Form_AutoKlaves()
        {
            InitializeComponent(); 
            label_prehra.Hide();
            label_restart.Hide();
            label_koniec.Hide();
        }

        private void Prehra()
        {
            if(pictureBox_auto1.Bounds.IntersectsWith(pictureBox_kuzel1.Bounds))
            {
                casovac.Stop();
                label_prehra.Show();
                label_restart.Show();
                label_koniec.Show();
            }
            if (pictureBox_auto1.Bounds.IntersectsWith(pictureBox_kuzel2.Bounds))
            {
                casovac.Stop();
                label_prehra.Show();
                label_restart.Show();
                label_koniec.Show();
            }
        }

        public void ciaryPohyb()
        {
            if (pictureBox_ciara1.Left <= 0)
            {
                pictureBox_ciara1.Left = 550;
            }
            else if (pictureBox_ciara2.Left <= 0)
            {
                pictureBox_ciara2.Left = 550;
            }
            else if (pictureBox_ciara3.Left <= 0)
            {
                pictureBox_ciara3.Left = 550;
            }
            else if (pictureBox_ciara4.Left <= 0)
            {
                pictureBox_ciara4.Left = 550;
            }
            else if (pictureBox_ciara5.Left <= 0)
            {
                pictureBox_ciara5.Left = 550;
            }
            else if (pictureBox_ciara6.Left <= 0)
            {
                pictureBox_ciara6.Left = 550;
            }
            else if (pictureBox_ciara7.Left <= 0)
            {
                pictureBox_ciara7.Left = 550;
            }

            else
            {
                pictureBox_ciara1.Left -= 5;
                pictureBox_ciara2.Left -= 5;
                pictureBox_ciara3.Left -= 5;
                pictureBox_ciara4.Left -= 5;
                pictureBox_ciara5.Left -= 5;
                pictureBox_ciara6.Left -= 5;
                pictureBox_ciara7.Left -= 5;
            }
            Random nahoda = new Random();
            int x, y;
            if(pictureBox_kuzel1.Left<=0)
            {
                x = nahoda.Next(0, 220);
                pictureBox_kuzel1.Location = new Point(480, x);
            }
            else if (pictureBox_kuzel2.Left <= 0)
            {
                y = nahoda.Next(0, 220);
                pictureBox_kuzel2.Location = new Point(480, y);
            }
            else
            {
                pictureBox_kuzel1.Left -= 3;
                pictureBox_kuzel2.Left -= 2;
            }    
        }

        private void Form_AutoKlaves_KeyDown(object sender, KeyEventArgs e)
        {
            //reakcia auta na šípky
            /*switch (e.KeyCode)
            {
                case Keys.Left:
                    x -= 5;
                    break;
                case Keys.Right:
                    x += 5;
                    break;
                case Keys.Up:
                    y -= 5;
                    break;
                case Keys.Down:
                    y += 5;
                    break;
            }*/

            if (e.KeyCode == Keys.Up)
            {
                if (pictureBox_auto1.Top > 19)
                {
                    pictureBox_auto1.Top -= 13;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (pictureBox_auto1.Top < 217)
                {
                    pictureBox_auto1.Top += 13;
                }
            }

            panel_Auto.Refresh();
        }

        private void casovac_Tick(object sender, EventArgs e)
        {
            ciaryPohyb();
            Prehra();
        }

        private void label_restart_Click(object sender, EventArgs e)
        {
            casovac.Start();
            pictureBox_kuzel1.Location = new Point(480, 25);
            pictureBox_kuzel2.Location = new Point(480, 200);
            label_prehra.Hide();
            label_koniec.Hide();
        }

        private void label_koniec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label_restart_MouseHover(object sender, EventArgs e)
        {
            label_restart.BackColor = Color.White;
        }

        private void label_restart_MouseLeave(object sender, EventArgs e)
        {
            label_restart.BackColor = Color.Transparent;
        }

        private void label_koniec_MouseHover(object sender, EventArgs e)
        {
            label_koniec.BackColor = Color.White;
        }

        private void label_koniec_MouseLeave(object sender, EventArgs e)
        {
            label_koniec.BackColor= Color.Transparent;
        }
    }
}
