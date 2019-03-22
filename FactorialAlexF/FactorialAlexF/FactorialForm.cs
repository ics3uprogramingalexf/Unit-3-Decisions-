/*
 * Created by: Alexander Forgeron
 * Created on: 19-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program calculates factorial
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialAlexF
{
    public partial class FactorialForm : Form
    {
        public FactorialForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            //clear the items from the listbox
            this.lstNum.Items.Clear();

            //Initialize the final answer to 1
            factorialAnswer = 1;

            // get the number from the user
            factorialNumber = Convert.ToDouble(this.txtInput.Text);

            // set the counter to 0
            factorialCounter = 0;

            // multiply the counter by the incremented number until it reaches the users number
            do
            {
                //increment the counter by 1
                factorialCounter = factorialCounter + 1;

                // list the counter number in the listbox for the user to see
                lstNum.Items.Add(factorialCounter);

                // multiply the counter by the number
                factorialAnswer = factorialAnswer * factorialCounter;

            } while (factorialNumber >= factorialCounter + 1);
            this.lblQuestion.Text = this.txtInput.Text + "! =" + Convert.ToString(factorialAnswer);
        }
    }
}
