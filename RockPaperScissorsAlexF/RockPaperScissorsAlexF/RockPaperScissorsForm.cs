using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsAlexF
{
    public partial class frmRockPaperScissors : Form
    {
        //Declare global varibales and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;
        int CPUInput;

        public frmRockPaperScissors()
        {
            InitializeComponent();

            // create the random number generator object
            randomNumberGenerator = new Random();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Declare local variables and constants
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            // get the user's selection, if there is no selection set it to 0
            if (radRock.Checked == true)
            {
                playerChoice = ROCK; 
            }
            else if (radPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radScissors.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            {
                playerChoice = 0;
            }

            // randomly generate a number between 1 and 3, representing ROCK, PAPER or SCISSORS
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // set radio button for the computer's choice
            if (computerChoice == ROCK)
            {
                this.radRockCom.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                this.radPaperCom.Checked = true;
            }
            else if (computerChoice == SCISSORS)
            {
                this.radScissorsCom.Checked = true;
            }

            // check to see who won
            if (computerChoice == ROCK)
            {



            }


        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {
            CPUInput = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
        }
    }
}
