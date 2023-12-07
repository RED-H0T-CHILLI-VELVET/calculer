using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double v1 = 0, v2 = 0, v3 = 0;
        String inputDigitado;
        int opt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 

        }
        //limpar
        private void clear_Click(object sender, EventArgs e)
        {
            inputBox.Clear();
        }
        //Clicke dos  botoes de números
        private void bttn1_Click(object sender, EventArgs e)
        {
            inputBox.AppendText("1"); 
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            inputBox.AppendText("2");
        }

        private void bttn3_Click(object sender, EventArgs e)
        {
            inputBox.AppendText("3");
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            inputBox.AppendText("4");
        }

        private void bttn5_Click(object sender, EventArgs e)
        {
            inputBox.AppendText("5");
        }

        private void bttn6_Click(object sender, EventArgs e)
        {
            inputBox.AppendText("6");
        }

        private void bttn7_Click(object sender, EventArgs e)
        {
            inputBox.AppendText("7");
        }

        private void bttn8_Click(object sender, EventArgs e)
        {
            inputBox.AppendText("8");
        }

        private void bttn9_Click(object sender, EventArgs e)
        {
            inputBox.AppendText("9");
        }

        private void bttn0_Click(object sender, EventArgs e)
        {
            inputBox.AppendText("0");
        }
        //clicke dos botoes de operacoes matemat
        private void addBtn_Click(object sender, EventArgs e)
        {
            v1 = Double.Parse(inputBox.Text);
            opt = 1;
            inputBox.Clear();
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            v1 = Double.Parse(inputBox.Text);
            opt = 2;
            inputBox.Clear();
            
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            v1 = Double.Parse(inputBox.Text);
            opt = 3;
            inputBox.Clear();
            
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            v1 = Double.Parse(inputBox.Text);
            opt = 4;
            inputBox.Clear();
            
        }

        private void resolve_Click(object sender, EventArgs e)
        {
           v2 = Double.Parse(inputBox.Text);

            if (opt==1) {
                v3 = v1 + v2;
            }else if (opt==2)
            {
                v3 = v1 - v2;
            }else if(opt==3)
            {
                v3 = v1 * v2;
            }else if (opt == 4)
            {
                v3 = v1 / v2;
            }
            inputBox.Clear();
            inputBox.AppendText(v3.ToString());
        }
         
    }
}
