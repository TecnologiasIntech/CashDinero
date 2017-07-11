using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CashDinero
{
    public partial class newLogin : Form
    {
        public newLogin()
        {
            InitializeComponent();
        }

        private int countPass = 0;

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void progresBar_progressChanged(object sender, EventArgs e)
        {

        }

        // ++
        void timer25_Tick(object sender, EventArgs e)
        {
            if (progresBar.Value != 25)
            {
                progresBar.Value++;
            }
            else
            {
                timer.Stop();
            }
        }
        void timer50_Tick(object sender, EventArgs e)
        {
            if (progresBar.Value != 50)
            {
                progresBar.Value++;
            }
            else
            {
                timer1.Stop();
            }
        }
        void timer75_Tick(object sender, EventArgs e)
        {
            if (progresBar.Value != 75)
            {
                progresBar.Value++;
            }
            else
            {
                timer2.Stop();
            }
        }
        void timer100_Tick(object sender, EventArgs e)
        {
            if (progresBar.Value != 100)
            {
                progresBar.Value++;
            }
            else
            {
                timer3.Stop();
            }
        }

        // --

        void timer25n_Tick(object sender, EventArgs e)
        {
            if (progresBar.Value != 25)
            {
                progresBar.Value--;
            }
            else
            {
                timer.Stop();
            }
        }
        void timer50n_Tick(object sender, EventArgs e)
        {
            if (progresBar.Value != 50)
            {
                progresBar.Value--;
            }
            else
            {
                timer1.Stop();
            }
        }
        void timer75n_Tick(object sender, EventArgs e)
        {
            if (progresBar.Value != 75)
            {
                progresBar.Value--;
            }
            else
            {
                timer2.Stop();
            }
        }
        void timer100n_Tick(object sender, EventArgs e)
        {
            if (progresBar.Value != 100)
            {
                progresBar.Value--;
            }
            else
            {
                timer3.Stop();
            }
        }


        private void newPassTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_newPassword.Text.Count() > countPass)
            {
                countPass++;
                if (txt_newPassword.Text.Count() == 0)
                {
                    labelLevel.Text = "Poor";
                    progresBar.Value = 0;
                    progresBar.ProgressColor = Color.Silver;

                }
                else if (txt_newPassword.Text.Count() > 0 && txt_newPassword.Text.Count() <= 6)
                {
                    labelLevel.Text = "Regular";
                    timer.Start();

                    timer.Enabled = true;
                    timer.Start();
                    timer.Interval = 25;
                    timer.Tick += new EventHandler(timer25_Tick);

                    progresBar.ProgressColor = Color.Red;

                }
                else if (txt_newPassword.Text.Count() > 6 && txt_newPassword.Text.Count() <= 12)
                {
                    labelLevel.Text = "Good";
                    timer1.Enabled = true;
                    timer1.Start();
                    timer1.Interval = 25;
                    timer1.Tick += new EventHandler(timer50_Tick);
                    progresBar.ProgressColor = Color.Yellow;

                }
                else if (txt_newPassword.Text.Count() > 12 && txt_newPassword.Text.Count() <= 16)
                {
                    labelLevel.Text = "Excellent";
                    timer2.Enabled = true;
                    timer2.Start();
                    timer2.Interval = 25;
                    timer2.Tick += new EventHandler(timer75_Tick);
                    progresBar.ProgressColor = Color.Orange;

                }
                else if (txt_newPassword.Text.Count() > 16)
                {
                    labelLevel.Text = "Unbreakable";
                    timer3.Enabled = true;
                    timer3.Start();
                    timer3.Interval = 25;
                    timer3.Tick += new EventHandler(timer100_Tick);
                    progresBar.ProgressColor = Color.Red;

                }
            }
        }

        private void txt_newPassword_KeyUp(object sender, KeyEventArgs e)
        {
            countPass--;
            if(e.KeyCode == Keys.Back)
            {
                if (txt_newPassword.Text.Count() == 0)
                {
                    labelLevel.Text = "Poor";
                    progresBar.Value = 0;
                    progresBar.ProgressColor = Color.Silver;

                }
                else if (txt_newPassword.Text.Count() > 0 && txt_newPassword.Text.Count() <= 6)
                {
                    labelLevel.Text = "Regular";
                    timer.Start();

                    timer.Enabled = true;
                    timer.Start();
                    timer.Interval = 25;
                    timer.Tick += new EventHandler(timer25n_Tick);

                    progresBar.ProgressColor = Color.Red;

                }
                else if (txt_newPassword.Text.Count() > 6 && txt_newPassword.Text.Count() <= 12)
                {
                    labelLevel.Text = "Good";
                    timer1.Enabled = true;
                    timer1.Start();
                    timer1.Interval = 25;
                    timer1.Tick += new EventHandler(timer50n_Tick);
                    progresBar.ProgressColor = Color.Yellow;

                }
                else if (txt_newPassword.Text.Count() > 12 && txt_newPassword.Text.Count() <= 16)
                {
                    labelLevel.Text = "Excellent";
                    timer2.Enabled = true;
                    timer2.Start();
                    timer2.Interval = 25;
                    timer2.Tick += new EventHandler(timer75n_Tick);
                    progresBar.ProgressColor = Color.Orange;

                }
                else if (txt_newPassword.Text.Count() > 16)
                {
                    labelLevel.Text = "Unbreakable";
                    timer3.Enabled = true;
                    timer3.Start();
                    timer3.Interval = 25;
                    timer3.Tick += new EventHandler(timer100n_Tick);
                    progresBar.ProgressColor = Color.Red;

                }
            }
        }
    }
}
