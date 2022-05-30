using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Game
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;

        void Enable_False()
        {
            btn_Tick1.Enabled = false;
            btn_Tick2.Enabled = false;
            btn_Tick3.Enabled = false;
            btn_Tick4.Enabled = false;
            btn_Tick5.Enabled = false;
            btn_Tick6.Enabled = false;
            btn_Tick7.Enabled = false;
            btn_Tick8.Enabled = false;
        }

        void Reset()
        {
            btn_Tick1.Enabled = true;
            btn_Tick2.Enabled = true;
            btn_Tick3.Enabled = true;
            btn_Tick4.Enabled = true;
            btn_Tick8.Enabled = true;
            btn_Tick5.Enabled = true;
            btn_Tick6.Enabled = true;
            btn_Tick7.Enabled = true;
            btn_Tick9.Enabled = true;

            btn_Tick1.Text = "";
            btn_Tick2.Text = "";
            btn_Tick3.Text = "";
            btn_Tick4.Text = "";
            btn_Tick5.Text = "";
            btn_Tick6.Text = "";
            btn_Tick7.Text = "";
            btn_Tick8.Text = "";
            btn_Tick9.Text = "";

            btn_Tick1.BackColor = Color.White;
            btn_Tick2.BackColor = Color.White;
            btn_Tick3.BackColor = Color.White;
            btn_Tick4.BackColor = Color.White;
            btn_Tick5.BackColor = Color.White;
            btn_Tick6.BackColor = Color.White;
            btn_Tick7.BackColor = Color.White;
            btn_Tick8.BackColor = Color.White;
            btn_Tick9.BackColor = Color.White;
        }

        void score()
        {
            if (btn_Tick1.Text == "X" && btn_Tick2.Text == "X" && btn_Tick3.Text == "X")
            {
                btn_Tick1.BackColor = Color.AliceBlue;
                btn_Tick2.BackColor = Color.AliceBlue;
                btn_Tick3.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player X ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerX.Text) + 1;
                lbl_PlayerX.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick4.Text == "X" && btn_Tick5.Text == "X" && btn_Tick6.Text == "X")
            {
                btn_Tick4.BackColor = Color.AliceBlue;
                btn_Tick5.BackColor = Color.AliceBlue;
                btn_Tick6.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player X ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerX.Text) + 1;
                lbl_PlayerX.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick7.Text == "X" && btn_Tick8.Text == "X" && btn_Tick9.Text == "X")
            {
                btn_Tick7.BackColor = Color.AliceBlue;
                btn_Tick8.BackColor = Color.AliceBlue;
                btn_Tick9.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player X ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerX.Text) + 1;
                lbl_PlayerX.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick1.Text == "X" && btn_Tick4.Text == "X" && btn_Tick7.Text == "X")
            {
                btn_Tick1.BackColor = Color.AliceBlue;
                btn_Tick4.BackColor = Color.AliceBlue;
                btn_Tick7.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player X ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerX.Text) + 1;
                lbl_PlayerX.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick2.Text == "X" && btn_Tick5.Text == "X" && btn_Tick8.Text == "X")
            {
                btn_Tick2.BackColor = Color.AliceBlue;
                btn_Tick5.BackColor = Color.AliceBlue;
                btn_Tick8.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player X ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerX.Text) + 1;
                lbl_PlayerX.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick3.Text == "X" && btn_Tick6.Text == "X" && btn_Tick9.Text == "X")
            {
                btn_Tick3.BackColor = Color.AliceBlue;
                btn_Tick6.BackColor = Color.AliceBlue;
                btn_Tick9.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player X ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerX.Text) + 1;
                lbl_PlayerX.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick1.Text == "X" && btn_Tick5.Text == "X" && btn_Tick9.Text == "X")
            {
                btn_Tick1.BackColor = Color.AliceBlue;
                btn_Tick5.BackColor = Color.AliceBlue;
                btn_Tick9.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player X ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerX.Text) + 1;
                lbl_PlayerX.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick3.Text == "X" && btn_Tick5.Text == "X" && btn_Tick7.Text == "X")
            {
                btn_Tick3.BackColor = Color.AliceBlue;
                btn_Tick5.BackColor = Color.AliceBlue;
                btn_Tick7.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player X ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerX.Text) + 1;
                lbl_PlayerX.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            //=============================================================================================================

            if (btn_Tick1.Text == "O" && btn_Tick2.Text == "O" && btn_Tick3.Text == "O")
            {
                btn_Tick1.BackColor = Color.AliceBlue;
                btn_Tick2.BackColor = Color.AliceBlue;
                btn_Tick3.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player O ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerO.Text) + 1;
                lbl_PlayerO.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick4.Text == "O" && btn_Tick5.Text == "O" && btn_Tick6.Text == "O")
            {
                btn_Tick4.BackColor = Color.AliceBlue;
                btn_Tick5.BackColor = Color.AliceBlue;
                btn_Tick6.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player O ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerO.Text) + 1;
                lbl_PlayerO.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick7.Text == "O" && btn_Tick8.Text == "O" && btn_Tick9.Text == "O")
            {
                btn_Tick7.BackColor = Color.AliceBlue;
                btn_Tick8.BackColor = Color.AliceBlue;
                btn_Tick9.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player O ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerO.Text) + 1;
                lbl_PlayerO.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick1.Text == "O" && btn_Tick4.Text == "O" && btn_Tick7.Text == "O")
            {
                btn_Tick1.BackColor = Color.AliceBlue;
                btn_Tick4.BackColor = Color.AliceBlue;
                btn_Tick7.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player O ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerO.Text) + 1;
                lbl_PlayerO.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick2.Text == "O" && btn_Tick5.Text == "O" && btn_Tick8.Text == "O")
            {
                btn_Tick2.BackColor = Color.AliceBlue;
                btn_Tick5.BackColor = Color.AliceBlue;
                btn_Tick8.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player O ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerO.Text) + 1;
                lbl_PlayerO.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick3.Text == "O" && btn_Tick6.Text == "O" && btn_Tick9.Text == "O")
            {
                btn_Tick3.BackColor = Color.AliceBlue;
                btn_Tick6.BackColor = Color.AliceBlue;
                btn_Tick9.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player O ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerO.Text) + 1;
                lbl_PlayerO.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick1.Text == "O" && btn_Tick5.Text == "O" && btn_Tick9.Text == "O")
            {
                btn_Tick1.BackColor = Color.AliceBlue;
                btn_Tick5.BackColor = Color.AliceBlue;
                btn_Tick9.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player O ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerO.Text) + 1;
                lbl_PlayerO.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }

            if (btn_Tick3.Text == "O" && btn_Tick5.Text == "O" && btn_Tick7.Text == "O")
            {
                btn_Tick3.BackColor = Color.AliceBlue;
                btn_Tick5.BackColor = Color.AliceBlue;
                btn_Tick7.BackColor = Color.AliceBlue;

                MessageBox.Show("The Winner is Player O ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PlayerO.Text) + 1;
                lbl_PlayerO.Text = Convert.ToString(plusone);
                Enable_False();
                Reset();
            }
            //===============================================================================================================          
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Tick1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                btn_Tick1.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tick1.Text = "O";
                checker = false;
            }
            score();
            btn_Tick1.Enabled = false;
        }

        private void btn_Tick2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tick2.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tick2.Text = "O";
                checker = false;
            }
            score();
            btn_Tick2.Enabled = false;
        }

        private void btn_Tick3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tick3.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tick3.Text = "O";
                checker = false;
            }
            score();
            btn_Tick3.Enabled = false;
        }

        private void btn_Tick4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tick4.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tick4.Text = "O";
                checker = false;
            }
            score();
            btn_Tick4.Enabled = false;
        }

        private void btn_Tick5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tick5.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tick5.Text = "O";
                checker = false;
            }
            score();
            btn_Tick5.Enabled = false;
        }

        private void btn_Tick6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tick6.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tick6.Text = "O";
                checker = false;
            }
            score();
            btn_Tick6.Enabled = false;
        }

        private void btn_Tick7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tick7.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tick7.Text = "O";
                checker = false;
            }
            score();
            btn_Tick7.Enabled = false;
        }

        private void btn_Tick8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tick8.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tick8.Text = "O";
                checker = false;
            }
            score();
            btn_Tick8.Enabled = false;
        }

        private void btn_Tick9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tick9.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tick9.Text = "O";
                checker = false;
            }
            score();
            btn_Tick9.Enabled = false;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
                btn_Tick1.Enabled = true;
                btn_Tick2.Enabled = true;
                btn_Tick3.Enabled = true;
                btn_Tick4.Enabled = true;
                btn_Tick8.Enabled = true;
                btn_Tick5.Enabled = true;
                btn_Tick6.Enabled = true;
                btn_Tick7.Enabled = true;

                btn_Tick1.Text = "";
                btn_Tick2.Text = "";
                btn_Tick3.Text = "";
                btn_Tick4.Text = "";
                btn_Tick5.Text = "";
                btn_Tick6.Text = "";
                btn_Tick7.Text = "";
                btn_Tick8.Text = "";
                btn_Tick9.Text = "";
                   
                lbl_PlayerX.Text = "";
                lbl_PlayerO.Text = "";

                btn_Tick1.BackColor = Color.White;
                btn_Tick2.BackColor = Color.White;
                btn_Tick3.BackColor = Color.White;
                btn_Tick4.BackColor = Color.White;
                btn_Tick5.BackColor = Color.White;
                btn_Tick6.BackColor = Color.White;
                btn_Tick7.BackColor = Color.White;
                btn_Tick8.BackColor = Color.White;
                btn_Tick9.BackColor = Color.White;
            
        }
    }
}
