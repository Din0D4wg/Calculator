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
    public partial class Calculator : Form
    {
        string uInput = "";                 //user input
        double result = 0;                  //current state of results
        string operation = "";             //current state of math equation
        bool operationpending = false;


        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        
        private void btn1_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender;
            uInput += button.Text; //attaches the button text (1) to the userinput
            TBdisplay.Text = uInput; //update display
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender; 
            uInput += button.Text;
            TBdisplay.Text = uInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender; 
            uInput += button.Text;
            TBdisplay.Text = uInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender; 
            uInput += button.Text;
            TBdisplay.Text = uInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender; 
            uInput += button.Text;
            TBdisplay.Text = uInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender; 
            uInput += button.Text;
            TBdisplay.Text = uInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender; 
            uInput += button.Text;
            TBdisplay.Text = uInput;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender; 
            uInput += button.Text;
            TBdisplay.Text = uInput;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender; 
            uInput += button.Text;
            TBdisplay.Text = uInput;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            uInput += button.Text;
            TBdisplay.Text = uInput;
        }

        //dot input
        private void btndot_Click(object sender, EventArgs e)
        {
            //Only adds the dots if it currently not in the input 
            if (!uInput.Contains ("."))
            {
                uInput += ".";
                TBdisplay.Text = uInput;
            }
        }

        private void Evaluate ()
        {

            if (operationpending)       //Only evaluate if an operation is pending
            {
                double secondinput = double.Parse(uInput);
                //converts the user input into a number

                switch (operation)
                {
                    case "+":
                        result += secondinput;
                        break;

                    case "-":
                        result -= secondinput;
                        break;

                    case "x":
                        result *= secondinput;
                        break;

                    case "÷":
                        if (secondinput != 0)
                        {
                            result /= secondinput;
                            break;
                        }
                        else
                        {
                            TBdisplay.Text = "Error";
                            return;
                        }

                    case "%":
                        result %= secondinput;
                        break;

                    default:

                        TBdisplay.Text = "Error";
                        return;
                }
                TBdisplay.Text = result.ToString();
                uInput = "";
                operationpending = false;



            }
        }


        private void btnplus_Click(object sender, EventArgs e)
        {
            if (operationpending)
            {
                Evaluate();
            }
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender;
            operation = button.Text;
            result = double.Parse(uInput);
            uInput = "";
            operationpending = true;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            if (operationpending)
            {
                Evaluate();
            }
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender;
            operation = button.Text;
            result = double.Parse(uInput);
            uInput = "";
            operationpending = true;
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            if (operationpending)
            {
                Evaluate();
            }
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender;
            operation = button.Text;
            result = double.Parse(uInput);
            uInput = "";
            operationpending = true;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (operationpending)
            {
                Evaluate();
            }
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender;
            operation = button.Text;
            result = double.Parse(uInput);
            uInput = "";
            operationpending = true;
        }

        private void btnremainder_Click(object sender, EventArgs e)
        {
            if (operationpending)
            {
                Evaluate();
            }
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender;
            operation = button.Text;
            result = double.Parse(uInput);
            uInput = "";
            operationpending = true;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            TBdisplay.Text = "";
            uInput = "";
            operation = "";
            operationpending = false;
            result = 0;
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            

            Evaluate();
            //Evaluate does the calculation based on the users input operation
        }

    }
}
