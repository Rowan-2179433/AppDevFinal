using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordProj
{

    public partial class InputForm : Form
    {
        public string UserInput { get; private set; }

        public InputForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Store the user's input in the public property when they click submit
            UserInput = userInputTextBox.Text;

            // Check if the user has actually entered something
            if (string.IsNullOrWhiteSpace(UserInput))
            {
                MessageBox.Show("Please enter a label.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK; // This will close the form
        }
    }
}
