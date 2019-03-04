using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessingGameAlexF
{
    public partial class frmGuessingGame : Form
    {
        public frmGuessingGame()
        {
            InitializeComponent();
        }

        private void btnCheckNumber_Click(object sender, EventArgs e)
        {
            const int NUMBER = 7;
            int guess;

            guess = int.Parse(txtNumber.Text);


            if (guess == NUMBER);
            {
            picCorrectOrWrong.Image 
           
            }

            else
            {


            }



        }
    }
}
