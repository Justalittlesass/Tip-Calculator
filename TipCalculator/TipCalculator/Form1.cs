///Candace Barnes
///01/24/2017
///Calculates two separate tip amounts (15 and 20 percent) based on user input and presents the total amount once the tips are added.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TipCalculator
{
    public partial class Form1 : Form
    {
        //Declare global variable for User Input
        Double Uinput;
        public Form1()
        {
            InitializeComponent();
        }

        //Limit the input allowed in the textbox to numerics and decimal only
        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            ///Net-Informations.com
            ///1/24/2017
            ///Textbox to allow only numbers in C# VB.Net
            ///http://net-informations.com/q/faq/txtbox.html


            if (System.Text.RegularExpressions.Regex.IsMatch(Input.Text, "  ^ [0-9]"))
            {
                Input.Text = "";
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Stores user input in global double variable
        private void Input_TextChanged(object sender, EventArgs e)
        {

            Uinput = float.Parse(Input.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Defines the button click to perform all of the calculations and display the results in the appropriate labels

        private void Calculate_Click(object sender, EventArgs e)
        {
            Double FifteenPerc = Uinput * .15;
            Double TwentyPerc = Uinput * .20;
            Double Fiftotall = Uinput + FifteenPerc;
            Double Twentytot = Uinput + TwentyPerc;
            Fifteen.Text = (FifteenPerc.ToString("c"));
            Twenty.Text = (TwentyPerc.ToString("c"));
            Fiftotal.Text = (Fiftotall.ToString("c"));
            Twentotal.Text = (Twentytot.ToString("c"));


        }



        private void Fifteen_Lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
