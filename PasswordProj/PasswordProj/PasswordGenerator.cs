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

        //List of passwords as strings  
        private List<string> hiddenPasswords = new List<string>(); // To store actual passwords

        // Flag to track visibility state
        private bool isPasswordVisible = false;

        //For the serialization methods
        private int counter = 0;

        //For the hide and unhide functionality 
        bool flag = true;


        public PasswordGenerator()
        {
            InitializeComponent();

        }
        //Saves the password into a file
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
                    return;
                }

                if (output == null)
                {
                    MessageBox.Show("Please select an output file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Open the LabelPromptForm as a dialog and check the result
                using (InputForm promptForm = new InputForm())
                {
                    if (promptForm.ShowDialog() == DialogResult.OK)
                    {
                        string passwordLabel = promptForm.UserInput;

                        // Serialize and write the password to the output stream with the label
                        formatter.Serialize(output, passwordLabel + ": " + password);

                        // Show a message to the user that the file has been saved
                        MessageBox.Show("Password saved successfully with label: " + passwordLabel);
                    }
                    else
                    {
                        MessageBox.Show("Saving was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the password to the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Uses finally to stop receiving error when file is trying to read on the Reader tab 
            {
                // Ensure the output stream is closed properly
                if (output != null)
                {
                    output.Close();
                    output = null; // Reset output to ensure it's not reused
                }
            }
        }




        private void generateButton_Click(object sender, EventArgs e)
        {
            Generators gen = new Generators();

            bool numbers = false;
            bool special = false;

            //Converts the updown value into an int 
            int length = Convert.ToInt32(lengthUpDown.Value);


            if (numbersCheck.Checked)
            {
                numbers = true;
            }

            if (specialCheck.Checked)
            {
                special = true;
            }

            //Triggers the generate password method 
            string password = gen.generatePassword(length, numbers, special);

            //Provides the user with the generated password 
            outputTextBox.Text = password;

        }

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
            if (flag)
            {
                flag = false;
                revealButton.Text = "Hide";
            }
            else
            {
                flag = true;
                revealButton.Text = "Reveal";
            }
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
                    listBoxPasswords.Items.Clear(); // Clear the ListBox for new data
                    counter = 0;

                    while (stream.Position < stream.Length)
                    {
                        counter++;
                        string entry = (string)formatter.Deserialize(stream);
                        string label;
                        string password;

                        // Check if the entry contains a custom label
                        if (entry.Contains(":"))
                        {
                            // Split the entry into label and password
                            var parts = entry.Split(new[] { ':' }, 2);
                            label = parts[0].Trim();
                            password = parts[1].Trim();
                        }
                        else
                        {
                            // No custom label, use default
                            label = "Password #" + counter;
                            password = entry.Trim();
                        }

                        // Create a display string that will show the label and the masked or unmasked password
                        string displayText = showPasswords ? $"{label}: {password}" : $"{label}: {new string('*', password.Length)}";
                        listBoxPasswords.Items.Add(displayText);
                        // Add the original entry to the hiddenPasswords list for potential deletion
                        hiddenPasswords.Add(entry);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Turns the selected text into a variable 
                var selectedIndex = listBoxPasswords.SelectedIndex;
                // Check if an item is selected in the list box since you can't have an index that is less than 0 
                if (selectedIndex != -1)
                {
                    // Remove the selected item from the list
                    hiddenPasswords.RemoveAt(selectedIndex);
                    listBoxPasswords.Items.RemoveAt(selectedIndex);

                    // Re-serialize the updated list to the file
                    using (FileStream stream = new FileStream(selectedFilePath, FileMode.Create)) // Overwrite the file
                    {
                        foreach (var password in hiddenPasswords)
                        {
                            formatter.Serialize(stream, password);
                        }
                    }
                    MessageBox.Show("Password deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Please select a password to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copyPassword_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an item is selected in the list box since you can't have an index that is less than 0 
                if (listBoxPasswords.SelectedIndex != -1)
                {
                    // Get the selected item
                    string selectedEntry = listBoxPasswords.SelectedItem.ToString();

                    // Extract the password from the selected entry
                    string password = ExtractPassword(selectedEntry);

                    // Copies the password to the clipboard
                    Clipboard.SetText(password);
                    MessageBox.Show("Password copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a password to copy.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while copying the password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This method splits the string using the ":" and only grabs the second half which is the password that is wanted by the user 
        private string ExtractPassword(string entry)
        {
            // Check if the entry contains a custom label and split it
            if (entry.Contains(":"))
            {
                var parts = entry.Split(new[] { ':' }, 2);
                //Returns only the second half of the split 
                return parts[1].Trim();
            }

            //If no label is found it just returns what was given
            return entry;

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            Generators generators = new Generators();
            string password = passTextbox.Text;
            string strength = generators.CheckPasswordStrength(password);
            strengthLabel.Text = strength;

            if (strengthLabel.Text.Equals("Weak"))
            {
                strengthLabel.BackColor = Color.Red;
            }
            else if (strengthLabel.Text.Equals("Moderate"))
            {
                strengthLabel.BackColor = Color.Yellow;
            }
            else if (strengthLabel.Text.Equals("Strong"))
            {
                strengthLabel.BackColor = Color.LightGreen;
                Font boldFont = new Font(strengthLabel.Font, FontStyle.Bold);
                strengthLabel.Font = boldFont;
            }
        }
    }
}



