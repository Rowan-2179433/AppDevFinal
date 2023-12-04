namespace PasswordProj
{
    partial class RetrieverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayPasswordsLabel = new System.Windows.Forms.Label();
            this.revealButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // displayPasswordsLabel
            // 
            this.displayPasswordsLabel.AutoSize = true;
            this.displayPasswordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPasswordsLabel.Location = new System.Drawing.Point(136, 24);
            this.displayPasswordsLabel.Name = "displayPasswordsLabel";
            this.displayPasswordsLabel.Size = new System.Drawing.Size(183, 24);
            this.displayPasswordsLabel.TabIndex = 0;
            this.displayPasswordsLabel.Text = "Display Passwords";
            // 
            // revealButton
            // 
            this.revealButton.Location = new System.Drawing.Point(180, 76);
            this.revealButton.Name = "revealButton";
            this.revealButton.Size = new System.Drawing.Size(75, 23);
            this.revealButton.TabIndex = 1;
            this.revealButton.Text = "Reveal Passwords";
            this.revealButton.UseVisualStyleBackColor = true;
            this.revealButton.Click += new System.EventHandler(this.revealButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 128);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(447, 351);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "";
            // 
            // RetrieverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 506);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.revealButton);
            this.Controls.Add(this.displayPasswordsLabel);
            this.Name = "RetrieverForm";
            this.Text = "RetrieverForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayPasswordsLabel;
        private System.Windows.Forms.Button revealButton;
        private System.Windows.Forms.RichTextBox passwordTextBox;
    }
}