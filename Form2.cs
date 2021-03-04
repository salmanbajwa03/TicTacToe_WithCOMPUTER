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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void StartB_Click(object sender, EventArgs e)
        {
            if (T1.Text == "")
            {
                MessageBox.Show("PLAYER 1 SELECT YOUR NAME .. !");
            }
            else if (T2.Text == "")
            {
                MessageBox.Show("PLAYER 2 SELECT YOUR NAME .. !");
            }
            else
            {
               // Form1.setPlayerName(T1.Text, T2.Text);

                this.Close();
            }

        }

        private void T2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void p2(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                StartB.PerformClick();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
