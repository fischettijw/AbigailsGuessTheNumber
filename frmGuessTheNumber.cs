using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbigailsGuessTheNumber
{
    public partial class frmGuessTheNumber : Form
    {
        int secretNumber;
        int numOfGuesses;
        int guess;
        int lowestHigh;
        int highestLow;

        public frmGuessTheNumber()
        {
            InitializeComponent();
        }

        private void frmGuessTheNumber_Load(object sender, EventArgs e)
        {
            initialize();
        }

        public void initialize()
        {
            btnGenerate.Enabled = true;
            txtMaxNumber.Text = "100";
            lblLowestHigh.Text = txtMaxNumber.Text;
            lblHighestLow.Text = "0";
            txtGuess.Text = "";
            txtGuess.Enabled = false;
            btnGenerate.Text = "Generate Secret Number";
            btnGenerate.Select();
            txtNumGuesses.Text = "";
            numOfGuesses = 0;
            lblHighLow.Text = "Last Guess was TOO -------";
            lblHighLow.Text = "";
            btnGuess.Enabled = false;
            btnNewGame.Enabled = false;
            txtMaxNumber.Enabled = true;
            txtMaxNumber.SelectionStart = 0;
            txtMaxNumber.SelectionLength = txtMaxNumber.Text.Length;
            txtMaxNumber.Select();
            txtDebug.Text = "";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                secretNumber = new Random().Next(1, Convert.ToInt32(txtMaxNumber.Text));
                lblLowestHigh.Text = txtMaxNumber.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Maximum Number MUST be an INTEGER Number");
                txtMaxNumber.Text = "100";
                return;
            }
            txtDebug.Text = secretNumber.ToString();
            btnGenerate.Text = "Secret Number Generated";
            btnGenerate.Enabled = false;
            btnNewGame.Enabled = true;
            btnGuess.Enabled = true;
            txtMaxNumber.Enabled = false;
            txtGuess.Enabled = true;
            txtGuess.SelectionStart = 0;
            txtGuess.SelectionLength = txtGuess.Text.Length;
            txtGuess.Select();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            initialize();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            numOfGuesses += 1;
            txtNumGuesses.Text = numOfGuesses.ToString();

            try
            {
                guess = Convert.ToInt32(txtGuess.Text);
                lowestHigh = Convert.ToInt32(lblLowestHigh.Text);
                highestLow = Convert.ToInt32(lblHighestLow.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Guess MUST be an INTEGER Number");
                txtGuess.Text = "";
                numOfGuesses -= 1;
                txtNumGuesses.Text = numOfGuesses.ToString();
                return;
            }
            if (guess < secretNumber)
            {
                lblHighLow.Text = "Last Guess was TOO LOW";
                if (guess > highestLow)
                {
                    lblHighestLow.Text = guess.ToString();
                }
            }

            if (guess > secretNumber)
            {
                lblHighLow.Text = "Last Guess was TOO HIGH";
                if (guess < lowestHigh)
                {
                    lblLowestHigh.Text = guess.ToString();
                }
            }

            if (guess == secretNumber)
            {
                lblHighLow.Text = "*** YOU WON WITH " + numOfGuesses + " GUESSES ***";
                btnGuess.Enabled = false;
            }

            txtGuess.SelectionStart = 0;
            txtGuess.SelectionLength = txtGuess.Text.Length;
            txtGuess.Select();
        }

    }
}
