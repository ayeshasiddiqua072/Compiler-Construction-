using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Mid_Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            try
            {
                if (ParseS(input) && input.All(char.IsWhiteSpace))
                {
                    ResultLabel.Text = "Accepted";
                }
                else
                {
                    ResultLabel.Text = "Rejected";
                }
            }
            catch (Exception ex)
            {
                ResultLabel.Text = "Error: " + ex.Message;
            }
        }

        private bool ParseS(string input)
        {
            // Skip leading spaces
            input = input.TrimStart();
            if (input.StartsWith("id"))
            {
                return ParseE(input.Substring(2));
            }
            return false;
        }

        private bool ParseE(string input)
        {
            // Skip leading spaces
            input = input.TrimStart();
            if (input.StartsWith("+"))
            {
                return ParseT(input.Substring(1)) && ParseEPrime(input.Substring(1));
            }
            return true; // E can derive ε
        }

        private bool ParseEPrime(string input)
        {
            // Skip leading spaces
            input = input.TrimStart();
            if (input.StartsWith("id"))
            {
                return ParseT(input.Substring(2)) && ParseEPrime(input.Substring(2));
            }
            return true; // E' can derive ε
        }

        private bool ParseT(string input)
        {
            // Skip leading spaces
            input = input.TrimStart();
            if (input.StartsWith("*"))
            {
                return ParseF(input.Substring(1)) && ParseTPrime(input.Substring(1));
            }
            return true; // T can derive ε
        }

        private bool ParseTPrime(string input)
        {
            // Skip leading spaces
            input = input.TrimStart();
            if (input.StartsWith("id"))
            {
                return ParseF(input.Substring(2)) && ParseTPrime(input.Substring(2));
            }
            return true; // T' can derive ε
        }

        private bool ParseF(string input)
        {
            // Skip leading spaces
            input = input.TrimStart();
            if (input.StartsWith("id"))
            {
                return true;
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
