using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        private bool turn = true;
        private int score1;
        private int score2;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void disable_all()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void enable_all()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void clear_all()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty; 
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty; ;
            button9.Text = string.Empty;

            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;
        }

        private bool check_win(string s)
        {
            if(button1.Text == button2.Text && button2.Text == button3.Text && button1.Text==s)
            {
                button1.BackColor = Color.MediumPurple;
                button2.BackColor = Color.MediumPurple;
                button3.BackColor = Color.MediumPurple;
                MessageBox.Show(string.Format("Congratulations!, the winner: Player {0}", s), "Results", MessageBoxButtons.OK);
                return true;
            }
            else if(button4.Text == button5.Text && button5.Text == button6.Text && button4.Text == s)
            {
                button4.BackColor = Color.MediumPurple;
                button5.BackColor = Color.MediumPurple;
                button6.BackColor = Color.MediumPurple;
                MessageBox.Show(string.Format("Congratulations!, the winner: Player {0}", s), "Results", MessageBoxButtons.OK);
                return true;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text == s)
            {
                button7.BackColor = Color.MediumPurple;
                button8.BackColor = Color.MediumPurple;
                button9.BackColor = Color.MediumPurple;
                MessageBox.Show(string.Format("Congratulations!, the winner: Player {0}", s), "Results", MessageBoxButtons.OK);
                return true;
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text == s)
            {
                button1.BackColor = Color.MediumPurple;
                button5.BackColor = Color.MediumPurple;
                button9.BackColor = Color.MediumPurple;
                MessageBox.Show(string.Format("Congratulations!, the winner: Player {0}", s), "Results", MessageBoxButtons.OK);
                return true;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text == s)
            {
                button3.BackColor = Color.MediumPurple;
                button5.BackColor = Color.MediumPurple;
                button7.BackColor = Color.MediumPurple;
                MessageBox.Show(string.Format("Congratulations!, the winner: Player {0}", s), "Results", MessageBoxButtons.OK);
                return true;
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text == s)
            {
                button1.BackColor = Color.MediumPurple;
                button4.BackColor = Color.MediumPurple;
                button7.BackColor = Color.MediumPurple;
                MessageBox.Show(string.Format("Congratulations!, the winner: Player {0}", s), "Results", MessageBoxButtons.OK);
                return true;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text == s)
            {
                button2.BackColor = Color.MediumPurple;
                button5.BackColor = Color.MediumPurple;
                button8.BackColor = Color.MediumPurple;
                MessageBox.Show(string.Format("Congratulations!, the winner: Player {0}", s), "Results", MessageBoxButtons.OK);
                return true;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text == s)
            {
                button3.BackColor = Color.MediumPurple;
                button6.BackColor = Color.MediumPurple;
                button9.BackColor = Color.MediumPurple;
                MessageBox.Show(string.Format("Congratulations!, the winner: Player {0}", s), "Results", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.button1.BackColor = Color.WhiteSmoke;
            if (turn)
            {
                button1.Text = "X";
                if (check_win("X"))
                {
                    this.score1++;
                    this.label4.Text = this.score1.ToString();
                    disable_all();
                }
                turn = false;
            }
            else
            {
                button1.Text = "O";
                if (check_win("O"))
                {
                    this.score2++;
                    this.label5.Text = this.score2.ToString();
                    disable_all();
                }
                turn = true;
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            this.button2.BackColor = Color.WhiteSmoke;
            if (turn)
            {
                button2.Text = "X";
                if (check_win("X"))
                {
                    this.score1++;
                    this.label4.Text = this.score1.ToString();
                    disable_all();
                }
                turn = false;
            }
            else
            {
                button2.Text = "O";
                if (check_win("O"))
                {
                    this.score2++;
                    this.label5.Text = this.score2.ToString();
                    disable_all();
                }
                turn = true;
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            this.button3.BackColor = Color.WhiteSmoke;
            if (turn)
            {
                button3.Text = "X";
                if (check_win("X"))
                {
                    this.score1++;
                    this.label4.Text = this.score1.ToString();
                    disable_all();
                }
                turn = false;
            }
            else
            {
                button3.Text = "O";
                if (check_win("O"))
                {
                    this.score2++;
                    this.label5.Text = this.score2.ToString();
                    disable_all();
                }
                turn = true;
            }          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            this.button4.BackColor = Color.WhiteSmoke;
            if (turn)
            {
                button4.Text = "X";
                if (check_win("X"))
                {
                    this.score1++;
                    this.label4.Text = this.score1.ToString();
                    disable_all();
                }
                turn = false;
            }
            else
            {
                button4.Text = "O";
                if (check_win("O"))
                {
                    this.score2++;
                    this.label5.Text = this.score2.ToString();
                    disable_all();
                }
                turn = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            this.button6.BackColor = Color.WhiteSmoke;
            if (turn)
            {
                button6.Text = "X";
                if (check_win("X"))
                {
                    this.score1++;
                    this.label4.Text = this.score1.ToString();
                    disable_all();
                }
                turn = false;
            }
            else
            {
                button6.Text = "O";
                if (check_win("O"))
                {
                    this.score2++;
                    this.label5.Text = this.score2.ToString();
                    disable_all();
                }
                turn = true;
            }           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            this.button5.BackColor = Color.WhiteSmoke;
            if (turn)
            {
                button5.Text = "X";
                if (check_win("X"))
                {
                    this.score1++;
                    this.label4.Text = this.score1.ToString();
                    disable_all();
                }
                turn = false;
            }
            else
            {
                button5.Text = "O";
                if (check_win("O"))
                {
                    this.score2++;
                    this.label5.Text = this.score2.ToString();
                    disable_all();
                }
                turn = true;
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            this.button7.BackColor = Color.WhiteSmoke;
            if (turn)
            {
                button7.Text = "X";
                if (check_win("X"))
                {
                    this.score1++;
                    this.label4.Text = this.score1.ToString();
                    disable_all();
                }
                turn = false;
            }
            else
            {
                button7.Text = "O";
                if (check_win("O"))
                {
                    this.score2++;
                    this.label5.Text = this.score2.ToString();
                    disable_all();
                }
                turn = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            this.button8.BackColor = Color.WhiteSmoke;
            if (turn)
            {
                button8.Text = "X";
                if (check_win("X"))
                {
                    this.score1++;
                    this.label4.Text = this.score1.ToString();
                    disable_all();
                }
                turn = false;
            }
            else
            {
                button8.Text = "O";
                if (check_win("O"))
                {
                    this.score2++;
                    this.label5.Text = this.score2.ToString();
                    disable_all();
                }
                turn = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            this.button9.BackColor = Color.WhiteSmoke;
            if (turn)
            {
                button9.Text = "X";
                if (check_win("X"))
                {
                    this.score1++;
                    this.label4.Text = this.score1.ToString();
                    disable_all();
                }
                turn = false;
            }
            else
            {
                button9.Text = "O";
                if (check_win("O"))
                {
                    this.score2++;
                    this.label5.Text = this.score2.ToString();
                    disable_all();
                }
                turn = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            enable_all();
            clear_all();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*
            MessageBox.Show("Farewell players!");
            Application.Exit();
            */
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.score1 = 0;
            this.score2 = 0;
            this.label4.Text = "0";
            this.label5.Text = "0";
            enable_all();
            clear_all();
        }
    }
}
