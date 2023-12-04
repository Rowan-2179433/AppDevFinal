using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace PasswordProj
{

    //TODO: 
    //Implement MDI for SaveButton_Click 
    //Implement file saving 
    public partial class PasswordGenerator : Form
    {
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;
        private string selectedFilePath;
        private List<string> hiddenPasswords = new List<string>(); // To store actual passwords
        private bool isPasswordVisible = false; // Flag to track visibility state
        private int counter = 0;

        public PasswordGenerator()
        {
            InitializeComponent();
            passwordTextBox.Font = new Font(passwordTextBox.Font.FontFamily, 14);

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
            try
            {
                string password = outputTextBox.Text;
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter a password before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method to prevent saving an empty password
                }

                // Check if an output stream has been selected
                if (output == null)
                {
                    MessageBox.Show("Please select an output file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if no output stream is selected
                }

                // Serialize and write the password to the output stream
                formatter.Serialize(output, password);

                // Show a message to the user that the file has been saved
                MessageBox.Show("Password saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the password to the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                Clipboard.SetText(outputTextBox.Text);
                MessageBox.Show("Text copied to clipboard successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while copying the password to the clipboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                output?.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {

                DialogResult result = fileChooser.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFileName = fileChooser.FileName;

                    if (string.IsNullOrEmpty(selectedFileName))
                    {
                        MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        saveButton.Enabled = false; // Disable save button if the file name is empty
                    }
                    else
                    {
                        try
                        {
                            output = new FileStream(selectedFileName, FileMode.Append, FileAccess.Write);
                            saveButton.Enabled = true; // Enable save button when a valid file is selected
                        }
                        catch (IOException)
                        {
                            MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            saveButton.Enabled = false; // Disable save button on error
                        }
                    }
                }
                else
                {
                    saveButton.Enabled = false; // Disable save button if the user cancels file selection
                }
            }

        }

        private void readerSelectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                if (fileChooser.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = fileChooser.FileName;
                    ReadAndDisplayPasswords(selectedFilePath, false);
                }
            }
        }

        private void revealButton_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible; // Toggle visibility
            ReadAndDisplayPasswords(selectedFilePath, isPasswordVisible);
        }
        private void ReadAndDisplayPasswords(string filePath, bool showPasswords)
        {
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    hiddenPasswords.Clear(); // Clear the list for new data
                    passwordTextBox.Clear(); // Clear the RichTextBox for new data
                    counter = 0;

                    while (stream.Position < stream.Length)
                    {
                        counter++;
                        string password = (string)formatter.Deserialize(stream);
                        hiddenPasswords.Add(password);

                        string displayText = showPasswords ? password : new string('*', password.Length);
                        passwordTextBox.AppendText("Password #" + counter + ": " + displayText + Environment.NewLine + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
   


