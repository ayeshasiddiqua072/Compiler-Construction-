using System;
using System.Text;
using System.Windows.Forms;

namespace CC_LabMid_Question3
{
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {
            string firstName = "Ayesha";
            string lastName = "Siddiqua";
            string regNumber = "72";

            if (firstName.Length < 1 || lastName.Length < 1 || regNumber.Length < 1)
            {
                MessageBox.Show("Please enter your first name, last name, and registration number.");
                return;
            }

            // Create a StringBuilder to build the password
            StringBuilder password = new StringBuilder();

            // Add initials of first and last name
            password.Append(firstName[0]);
            password.Append(lastName[0]);

            // Add registration number
            password.Append(regNumber);

            // Generate random uppercase alphabet
            Random random = new Random();
            password.Append((char)random.Next('A', 'Z' + 1));

            // Generate 3 random numbers (1 less than previously)
            for (int i = 0; i < 3; i++)
            {
                password.Append((char)random.Next('0', '9' + 1));
            }

            // Generate 2 special characters (same as previously)
            string specialCharacters = "!@#$%^&*()_-+=<>?";
            for (int i = 0; i < 2; i++)
            {
                password.Append(specialCharacters[random.Next(specialCharacters.Length)]);
            }

            // Shuffle the password characters for better security
            password = ShuffleString(password);

            // Limit the password to a maximum length of 16 (1 less than previously)
            if (password.Length > 15)
            {
                password.Length = 15;
            }

            // Display the generated password
            GeneratedPasswordLabel.Text = password.ToString();
        }

        private StringBuilder ShuffleString(StringBuilder str)
        {
            Random random = new Random();
            int n = str.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                char value = str[k];
                str[k] = str[n];
                str[n] = value;
            }
            return str;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Question3_Load(object sender, EventArgs e)
        {

        }
    }
}
