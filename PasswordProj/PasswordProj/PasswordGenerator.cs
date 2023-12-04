using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace PasswordProj
{

    //TODO: 
    //Implement MDI for SaveButton_Click 
    //Implement file saving 
    public partial class PasswordGenerator : Form
    {

        public PasswordGenerator()
        {
            InitializeComponent();
        }
        //Helper method to save the password into a file
        public static void SavePasswordToFile(string password, string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(stream, password);
            }
        }
        //Saves generated password and prompts the user with the save form 
        private void saveButton_Click(object sender, EventArgs e)
        {
            string password = outputTextBox.Text;
            string filePath = Path.Combine(Environment.CurrentDirectory, "Database.ser");

            PasswordGenerator.SavePasswordToFile(password, filePath);

            // Optionally, show a message to the user that the file has been saved
            MessageBox.Show("Password saved successfully.");
        }


        //Status: Complete 
        private void generateButton_Click(object sender, EventArgs e)
        {
            Generators gen = new Generators();
            
            bool numbers = false;
            bool special = false;

            int length = Convert.ToInt32(lengthUpDown.Value);


            if (numbersCheck.Checked)
            {
                numbers = true;
            }

            if (specialCheck.Checked)
            {
                special = true;
            }

            string password = gen.generatePassword(length, numbers, special);

            outputTextBox.Text = password; 

        }

        //Status: Complete 
        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputTextBox.Text);

        }
    }
}
