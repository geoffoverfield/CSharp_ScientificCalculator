/***************************
 *      Geoff Overfield    *
 *      March 24, 2015     *
 *  Scientific Calculator  *
 **************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string display = "";   //to be displayed to label
        double op1 = 0, op2 = 0;  //left and right opperands
        double result = 0;        //result of arithmetic
        Char opr;         //operator

        private void Concatonate()
        {
            if (result != 0)
            {
                op1 = result;
            }
            else op1 = Convert.ToDouble(display);
            try
            {
                op2 = Convert.ToDouble(display);
            }
            catch
            {
                op2 = 0.0;
                display = "";
                MessageBox.Show("Fatal Error Occurred.  Goodbye!");
                Application.Exit();
            }
            
            result = 0.0;
        }
       
        //For displaying numbers in window
        private void Display(long n)                                           
        {
            display = display + n.ToString();
            lblDisplay.Text = display;
        }
        //For Info on Menu Strip
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)    
        {
            MessageBox.Show("Created by the Champ...  You're Welcome!!");
        }
        //Button 1
        private void btn1_Click(object sender, EventArgs e)                     
        {
            Display(1);
        }
        //Button 2
        private void btn2_Click(object sender, EventArgs e)                     
        {
            Display(2);
        }
        //Button 3
        private void btn3_Click(object sender, EventArgs e)                     
        {
            Display(3);
        }
        //Button 4
        private void btn4_Click(object sender, EventArgs e)                     
        {
            Display(4);
        }
        //Button 5
        private void btn5_Click(object sender, EventArgs e)                     
        {
            Display(5);
        }
        //Button 6
        private void btn6_Click(object sender, EventArgs e)                     
        {
            Display(6);
        }
        //Button 7
        private void btn7_Click(object sender, EventArgs e)                     
        {
            Display(7);
        }
        //Button 8
        private void btn8_Click(object sender, EventArgs e)                     
        {
            Display(8);
        }
        //Button 9
        private void btn9_Click(object sender, EventArgs e)                     
        {
            Display(9);
        }
        //Button 0
        private void btn0_Click(object sender, EventArgs e)                     
        {
            Display(0);
        }
        //Funtion to quit and close calculator from menu strip
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)    
        {
            Application.Exit();
        }
        //Associated with "=" Button - Extensive Control Stucture to evaluate user input and manipulate it based on mathematics
        private void Solve_Click(object sender, EventArgs e)
        {
            Concatonate();
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                case 'F':
                    result = 1 / op1;
                    break;
                case 'Y':
                    result = Math.Pow(op1, op2);
                    break;
                case 'R':
                    result = (Math.Pow(op1, (1.0 / op2)));
                    break;
                default :
                    MessageBox.Show("Fatal Error Occurred!");
                    break;
            }
            lblDisplay.Text = result.ToString();
            op2 = 0;
        }
        //Associated with "C" Button - Function to clear screen after answers are presented
        private void Clear_Click(object sender, EventArgs e)
        {
            op1 = 0.0;
            op2 = 0.0;
            result = 0.0;
            display = "";
            lblDisplay.Text = "";
        }
        //Associated with "+" Button - Performs addition
        private void Add_Click(object sender, EventArgs e)
        {
            opr = '+';
            op1 = Convert.ToDouble(display);
            lblDisplay.Text = "";
            display = "";
        }
        //Associated with "*" Button - Performs multiplication
        private void Multiply_Click(object sender, EventArgs e)
        {
            opr = '*';
            op1 = Convert.ToDouble(display);
            lblDisplay.Text = "";
            display = "";
        }
        //Associated with "-" Button - Performs subtraction
        private void Subtract_Click(object sender, EventArgs e)
        {
            opr = '-';
            op1 = Convert.ToDouble(display);
            lblDisplay.Text = "";
            display = "";      
        }
        //Associated with "/" Button - Performs division
        private void Divide_Click(object sender, EventArgs e)
        {
            opr = '/';
            op1 = Convert.ToDouble(display);
            lblDisplay.Text = "";
            display = "";
        }
        //Associated with "√" Button - Performs Square Root of number entered
        private void btnSqRt_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(display);
            result = Math.Sqrt(op1);
            lblDisplay.Text = result.ToString();
        }
        //Associated with "3√" Button - Performs Cube Root of number entered
        private void CubedRoot_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(display);
            result = (Math.Pow(op1, (1.0 / 3.0)));
            lblDisplay.Text = result.ToString();
        }
        //Associated with "x^2" Button - Performs squaring of number entered
        private void btnXSqrd_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(display);
            result = Math.Pow(op1, 2);
            lblDisplay.Text = result.ToString();
        }
        //Associated with "x^y" Button - Performs squaring of numbers entered
        private void btnXToTheY_Click(object sender, EventArgs e)
        {
            opr = 'Y';
            op1 = Convert.ToDouble(display);
            lblDisplay.Text = "";
            display = "";
        }
        //Associated with "%" Button - Calculates decimal of percentage
        private void Percent_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(display);
            result = op1 / 100;
            display = result.ToString();
            lblDisplay.Text = display;
        }
        //Associated with "+/-" Button - Converts positive to negative
        private void PosNeg_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(display);
            result = op1 * -1;
            display = result.ToString();
            lblDisplay.Text = display;
        }
        //Associated with "1/x" Button - Converts to decimal for fraction of 1th of number entered
        private void Fraction_Click(object sender, EventArgs e)
        {
            opr = 'F';
            op1 = Convert.ToDouble(display);
            lblDisplay.Text = "";
            display = "";
        }
        //Associated with "y√x" Button - Performs roots of numbers entered
        private void Root_Click(object sender, EventArgs e)
        {
            opr = 'R';
            op1 = Convert.ToDouble(display);
            lblDisplay.Text = "0";
            display = "";
        }
		//Keeps display fresh with double buffer at 10milSec
        private void timer1_Tick(object sender, EventArgs e)
        {
            display = lblDisplay.Text;
        }
    }
}
