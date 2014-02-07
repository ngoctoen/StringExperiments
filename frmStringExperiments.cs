using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringExperiments
{
    public partial class frmStringExperiments : Form
    {
        public frmStringExperiments()
        {
            InitializeComponent();
        }

        private void frmStringExperiments_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNumChars_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            string input = txtInput.Text;
            int output = input.Length;
            //output = Convert.ToInt32(txtInput.Text);
            txtOutput.Text = "There are " + output + " characters including space";
            
        }

        private void btnNumWords_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            string input = txtInput.Text;
            char space;
            space = new Char();
            space = ' ';

            string[] words;
            words = input.Split(space);
            txtOutput.Text = "There are " + words.Length + " words";
    
            
        }

        private void btnFileNameAndExtension_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            string input = txtInput.Text;
            char period;
            period = new Char();
            period = '.';

            string[] words;
            words = input.Split(period);

            for (int i = 0; i < words.Length; i++)
            {
                txtOutput.Text = txtOutput.Text + words[i] + "\r\n";
            }

        }

        private void btnDownshift_Click(object sender, EventArgs e)
        {
            string newinput = txtInput.Text.ToLower();
            txtOutput.Text = newinput;
        }

        private void btnUpshift_Click(object sender, EventArgs e)
        {
            string newinput = txtInput.Text.ToUpper();
            txtOutput.Text = newinput;
        }

        private void btnLastCharacter_Click(object sender, EventArgs e)
        {
            Char LastChar;
            string input = txtInput.Text;
            LastChar = input[input.Length -1];
            txtOutput.Text = "The last character is " + LastChar;
            
        }

        private void btnWhatever_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string change;
            change = txtOutput.Text.Replace(txtOriginal.Text, txtChange.Text);
            txtOutput.Text = change;
        }

           

        

       

        
    }
}
