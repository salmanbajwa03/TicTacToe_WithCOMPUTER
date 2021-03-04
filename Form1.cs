using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_With_AI
{
    

    public partial class Form1 : Form
    {
        bool againstComputer = false;
        bool turn = true;// true = X false = O
        int turnCount = 0;
      //  static String player1, player2;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Change Player 2 Name Istead Of Computer !. To Play 2v2");
        }

        //public static void setPlayerName(String n1,String n2)
        //{
        //    player1 = n1;
        //    player2 = n2;
        //}

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Salman Bajwa .. !!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            
            if (pp2.Text == "Player 2")
            {
                MessageBox.Show("You Must Select Player 2 Name Before Start .. Type Computer(Player 2) to play with Computer");
            }
            else if (pp2.Text == "Player 1")
            {
                MessageBox.Show("You Must Select Player 1 Name Before Start /n Type Computer( Player 2) to play with Computer");
            }
            else
            {
                
                Button B = (Button)sender;
                if (turn)
                {
                    B.Text = "X";
                }
                else
                {
                    B.Text = "O";
                }
                turn = !turn;
               
                B.Enabled = false;
                turnCount++;
                IsWin();
                
            }
            if ((!turn) && (againstComputer))
            {
                computer_make_move();
            }

            
        }

        private void computer_make_move()
        {
            //priority 1: get tic tac toe
            //2 : block x tic tac toe
            //3 : go for corner space 
            // 4: pick open space 


            Button move = null;
            //look for opportunities
            move=look_for_win_or_block("O");//look for win;
                if(move==null)//look for block 
                {
                     move=look_for_win_or_block("X");
                    if(move==null)
                    {
                        move = look_for_corner();
                        if(move==null)
                        {
                            move=look_for_open_space();
                        }
                    }
                }


                move.PerformClick();

        }

        private Button look_for_win_or_block(string mark)
        {

            Console.WriteLine("Look for win or block " + mark);
            //horizontal Check
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A3.Text == mark) && (A1.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B3.Text == mark) && (B1.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C3.Text == mark) && (C1.Text == mark) && (C2.Text == ""))
                return C2;

            //Vertical 
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;
            //right Diagonal
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            //left Diagonal
            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;

            return null;

        }

        private Button look_for_corner()
        {
            Console.WriteLine("Looking For Corners ");
            if(A1.Text=="O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;

            }

            if (C3.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (A1.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;

            }

            if (C1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (A1.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;

            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;

            }

            if (A1.Text == "O")
                return A1;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;

            

            return null;

        }

        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for Open Space");
            Button b = null;
            foreach(Control c in Controls)
            {
                b = c as Button;
                if(b!=null)
                {
                    if (b.Text == "")
                        return b;
                }
            }
            return null;
        }

        private void disableButton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }
            }
            catch { }
        }

        public bool IsHorizontalWin()
        {
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Text!=""))
            {
                return true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Text != ""))
            {
                return true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Text != ""))
            {
                return true;
            }

            return false;
        
        }
        public bool IsVerticalWin()
        {
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Text != ""))
            {
                return true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Text != ""))
            {
                return true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Text != ""))
            {
                return true;
            }

            return false;

        }
        public bool IsLeftDiagonalWin()
        {
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Text != ""))
            {
                return true;
            }
          

            return false;

        }
        public bool IsRightDiagonalWin()
        {
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (C1.Text != ""))
            {
                return true;
            }

            return false;

        }

        public bool isDraw()
        {
           
            if(turnCount==9)
            {
                return true;
            }
            
           
            return false;
        }

        private void IsWin()
        {

            if (IsHorizontalWin()||IsVerticalWin()||IsRightDiagonalWin()||IsLeftDiagonalWin())
            {
                disableButton();
                string Win = "";
                if (turn)
                {
                    Win = pp2.Text;
                    o_win_count.Text=(Int32.Parse(o_win_count.Text)+1).ToString();
                }
                else
                {
                    Win = pp1.Text;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
               
                MessageBox.Show(Win + " Is WIN...!!!");
                
                
            }

            else if(isDraw())
            {
                try
                {
                    MessageBox.Show("Game is Draw.. !!");
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                }
                catch { }
                
            }
           
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
           
                foreach (Control c in Controls)
                {
                     try
            {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
            }
                     catch { }

                }
           
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (B.Enabled)
            {
                if (turn)
                    B.Text = "X";
                else
                    B.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (B.Enabled)
            {

                B.Text = "";

            }
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.ShowDialog();
            //pp1.Text = player1;
            //pp2.Text = player2;
            setDefaultToolStripMenuItem.PerformClick();
        }

        private void pp2_TextChanged(object sender, EventArgs e)
        {
            if (pp2.Text.ToUpper() == "COMPUTER")
            {
                againstComputer = true;
            }
            else
                againstComputer = false; 
        }

        private void setDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pp1.Text = "Bajwa";
            pp2.Text = "Computer";
        }

        private void pp1_TextChanged(object sender, EventArgs e)
        {
            //
        }

    }
}
