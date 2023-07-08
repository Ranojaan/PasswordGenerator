using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {

        int currentPasswordLength = 0;
        Random Character = new Random();

        private void passwordGenerator(int passwordLength)
        {
            String AllCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz!@#$%^&*()_";
            String randomPassword = "";

            for (int i = 0;i < passwordLength; i++)
            {
                int randomNum = Character.Next(0,AllCharacters.Length);
                randomPassword += AllCharacters[randomNum];
 
            }

            PasswordLabel.Text = randomPassword;
        }
        public Form1()
        {
            
            InitializeComponent();
            PasswordLengthSlider.Minimum = 5;
            PasswordLengthSlider.Maximum = 20;
            passwordGenerator(5);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordLabel.Text);
        }

        private void PasswordLengthSlider_Scroll(object sender, EventArgs e)
        {
            PasswordLengthLabel.Text = "Password Length : " + PasswordLengthSlider.Value.ToString();
            currentPasswordLength = PasswordLengthSlider.Value;
            passwordGenerator(currentPasswordLength);
        }

       
    }
}
