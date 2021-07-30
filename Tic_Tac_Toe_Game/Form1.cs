using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Tic_Tac_Toe_Game : Form
    {
        int addOne;
        Boolean xTurn = true;
        int round = 0;
        
        void disableButtons() //Desativa os botões - não pode mais selecionar
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

        void score()
        {
            //======= para X =======
            
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Firebrick;
                button2.BackColor = Color.Firebrick;
                button3.BackColor = Color.Firebrick;

                MessageBox.Show("Player X won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label4.Text);
                label4.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Firebrick;
                button5.BackColor = Color.Firebrick;
                button6.BackColor = Color.Firebrick;

                MessageBox.Show("Player X won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label4.Text);
                label4.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Firebrick;
                button8.BackColor = Color.Firebrick;
                button9.BackColor = Color.Firebrick;

                MessageBox.Show("Player X won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label4.Text);
                label4.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Firebrick;
                button4.BackColor = Color.Firebrick;
                button7.BackColor = Color.Firebrick;

                MessageBox.Show("Player X won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label4.Text);
                label4.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Firebrick;
                button5.BackColor = Color.Firebrick;
                button8.BackColor = Color.Firebrick;

                MessageBox.Show("Player X won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label4.Text);
                label4.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Firebrick;
                button6.BackColor = Color.Firebrick;
                button9.BackColor = Color.Firebrick;

                MessageBox.Show("Player X won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label4.Text);
                label4.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Firebrick;
                button5.BackColor = Color.Firebrick;
                button9.BackColor = Color.Firebrick;

                MessageBox.Show("Player X won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label4.Text);
                label4.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Firebrick;
                button5.BackColor = Color.Firebrick;
                button7.BackColor = Color.Firebrick;

                MessageBox.Show("Player X won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label4.Text);
                label4.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }


            //======= para O =======

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.Firebrick;
                button2.BackColor = Color.Firebrick;
                button3.BackColor = Color.Firebrick;

                MessageBox.Show("Player O won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label5.Text);
                label5.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Firebrick;
                button5.BackColor = Color.Firebrick;
                button6.BackColor = Color.Firebrick;

                MessageBox.Show("Player O won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label5.Text);
                label5.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Firebrick;
                button8.BackColor = Color.Firebrick;
                button9.BackColor = Color.Firebrick;

                MessageBox.Show("Player O won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label5.Text);
                label5.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Firebrick;
                button4.BackColor = Color.Firebrick;
                button7.BackColor = Color.Firebrick;

                MessageBox.Show("Player O won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label5.Text);
                label5.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Firebrick;
                button5.BackColor = Color.Firebrick;
                button8.BackColor = Color.Firebrick;

                MessageBox.Show("Player O won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label5.Text);
                label5.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Firebrick;
                button6.BackColor = Color.Firebrick;
                button9.BackColor = Color.Firebrick;

                MessageBox.Show("Player O won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label5.Text);
                label5.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Firebrick;
                button5.BackColor = Color.Firebrick;
                button9.BackColor = Color.Firebrick;

                MessageBox.Show("Player O won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label5.Text);
                label5.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Firebrick;
                button5.BackColor = Color.Firebrick;
                button7.BackColor = Color.Firebrick;

                MessageBox.Show("Player O won the round!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label5.Text);
                label5.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
                round--;
            }

            if (round == 9)
            {
                MessageBox.Show("The round ends in draw! ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addOne = int.Parse(label6.Text);
                label6.Text = Convert.ToString(addOne + 1); //armazena no addOne
                disableButtons();
            }
        }

        public Tic_Tac_Toe_Game()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tic_Tac_Toe_Game_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; //botãao clicavel que alterara o valor independete do botão que eu clicar

            if (btn.Text == "") //Somente atribui valor se btn for vazio
            {
                if (xTurn)
                {
                    btn.Text = "X";
                    xTurn = false;
                    round++;
                    score();
                }
                else
                {
                    btn.Text = "O";
                    xTurn = true;
                    round++;
                    score();
                }
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
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
            buttonNewGame.Enabled = true;

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            round = 0;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Want to reset all the points?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
                buttonReset.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                label4.Text = "0";
                label5.Text = "0";
                label6.Text = "0";

                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;



                round = 0;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ExitProgram;
                ExitProgram = MessageBox.Show("Do you want to exit?", "TicTacToe", MessageBoxButtons.YesNo);
                if (ExitProgram == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.YesNo);
            }
        }
    }
}
