namespace PasswordProj
{
    partial class PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.numbersCheck = new System.Windows.Forms.CheckBox();
            this.specialCheck = new System.Windows.Forms.CheckBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.genLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.passwordControl = new System.Windows.Forms.TabControl();
            this.generatorPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.readerSelectButton = new System.Windows.Forms.Button();
            this.revealButton = new System.Windows.Forms.Button();
            this.displayPasswordsLabel = new System.Windows.Forms.Label();
            this.listBoxPasswords = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.copyPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            this.passwordControl.SuspendLayout();
            this.generatorPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lengthUpDown
            // 
            this.lengthUpDown.Location = new System.Drawing.Point(238, 100);
            this.lengthUpDown.Name = "lengthUpDown";
            this.lengthUpDown.Size = new System.Drawing.Size(90, 20);
            this.lengthUpDown.TabIndex = 3;
            // 
            // numbersCheck
            // 
            this.numbersCheck.AutoSize = true;
            this.numbersCheck.Location = new System.Drawing.Point(140, 63);
            this.numbersCheck.Name = "numbersCheck";
            this.numbersCheck.Size = new System.Drawing.Size(68, 17);
            this.numbersCheck.TabIndex = 4;
            this.numbersCheck.Text = "Numbers";
            this.numbersCheck.UseVisualStyleBackColor = true;
            // 
            // specialCheck
            // 
            this.specialCheck.AutoSize = true;
            this.specialCheck.Location = new System.Drawing.Point(214, 63);
            this.specialCheck.Name = "specialCheck";
            this.specialCheck.Size = new System.Drawing.Size(115, 17);
            this.specialCheck.TabIndex = 5;
            this.specialCheck.Text = "Special Characters";
            this.specialCheck.UseVisualStyleBackColor = true;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(140, 102);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(92, 13);
            this.lengthLabel.TabIndex = 6;
            this.lengthLabel.Text = "Password Length:";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(29, 259);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(120, 46);
            this.copyButton.TabIndex = 7;
            this.copyButton.Text = "Copy Password";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(320, 259);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 46);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(29, 201);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(411, 27);
            this.outputTextBox.TabIndex = 10;
            this.outputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genLabel
            // 
            this.genLabel.AutoSize = true;
            this.genLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genLabel.Location = new System.Drawing.Point(135, 19);
            this.genLabel.Name = "genLabel";
            this.genLabel.Size = new System.Drawing.Size(199, 24);
            this.genLabel.TabIndex = 11;
            this.genLabel.Text = "Password Generator";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(159, 142);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(151, 28);
            this.generateButton.TabIndex = 12;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(29, 327);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(411, 59);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(174, 259);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(120, 46);
            this.selectButton.TabIndex = 14;
            this.selectButton.Text = "Select File";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // passwordControl
            // 
            this.passwordControl.Controls.Add(this.generatorPage);
            this.passwordControl.Controls.Add(this.tabPage2);
            this.passwordControl.Location = new System.Drawing.Point(12, 9);
            this.passwordControl.Name = "passwordControl";
            this.passwordControl.SelectedIndex = 0;
            this.passwordControl.Size = new System.Drawing.Size(476, 454);
            this.passwordControl.TabIndex = 15;
            // 
            // generatorPage
            // 
            this.generatorPage.Controls.Add(this.saveButton);
            this.generatorPage.Controls.Add(this.selectButton);
            this.generatorPage.Controls.Add(this.lengthUpDown);
            this.generatorPage.Controls.Add(this.exitButton);
            this.generatorPage.Controls.Add(this.numbersCheck);
            this.generatorPage.Controls.Add(this.generateButton);
            this.generatorPage.Controls.Add(this.specialCheck);
            this.generatorPage.Controls.Add(this.genLabel);
            this.generatorPage.Controls.Add(this.lengthLabel);
            this.generatorPage.Controls.Add(this.outputTextBox);
            this.generatorPage.Controls.Add(this.copyButton);
            this.generatorPage.Location = new System.Drawing.Point(4, 22);
            this.generatorPage.Name = "generatorPage";
            this.generatorPage.Padding = new System.Windows.Forms.Padding(3);
            this.generatorPage.Size = new System.Drawing.Size(468, 428);
            this.generatorPage.TabIndex = 0;
            this.generatorPage.Text = "Generator";
            this.generatorPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.copyPassword);
            this.tabPage2.Controls.Add(this.deleteButton);
            this.tabPage2.Controls.Add(this.listBoxPasswords);
            this.tabPage2.Controls.Add(this.readerSelectButton);
            this.tabPage2.Controls.Add(this.revealButton);
            this.tabPage2.Controls.Add(this.displayPasswordsLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reader";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // readerSelectButton
            // 
            this.readerSelectButton.Location = new System.Drawing.Point(147, 49);
            this.readerSelectButton.Name = "readerSelectButton";
            this.readerSelectButton.Size = new System.Drawing.Size(86, 23);
            this.readerSelectButton.TabIndex = 19;
            this.readerSelectButton.Text = "Select File";
            this.readerSelectButton.UseVisualStyleBackColor = true;
            this.readerSelectButton.Click += new System.EventHandler(this.readerSelectButton_Click);
            // 
            // revealButton
            // 
            this.revealButton.Location = new System.Drawing.Point(247, 49);
            this.revealButton.Name = "revealButton";
            this.revealButton.Size = new System.Drawing.Size(75, 23);
            this.revealButton.TabIndex = 17;
            this.revealButton.Text = "Reveal Passwords";
            this.revealButton.UseVisualStyleBackColor = true;
            this.revealButton.Click += new System.EventHandler(this.revealButton_Click);
            // 
            // displayPasswordsLabel
            // 
            this.displayPasswordsLabel.AutoSize = true;
            this.displayPasswordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPasswordsLabel.Location = new System.Drawing.Point(143, 12);
            this.displayPasswordsLabel.Name = "displayPasswordsLabel";
            this.displayPasswordsLabel.Size = new System.Drawing.Size(183, 24);
            this.displayPasswordsLabel.TabIndex = 16;
            this.displayPasswordsLabel.Text = "Display Passwords";
            // 
            // listBoxPasswords
            // 
            this.listBoxPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPasswords.FormattingEnabled = true;
            this.listBoxPasswords.ItemHeight = 20;
            this.listBoxPasswords.Location = new System.Drawing.Point(18, 98);
            this.listBoxPasswords.Name = "listBoxPasswords";
            this.listBoxPasswords.Size = new System.Drawing.Size(433, 284);
            this.listBoxPasswords.TabIndex = 20;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(48, 388);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(148, 34);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // copyPassword
            // 
            this.copyPassword.Location = new System.Drawing.Point(274, 389);
            this.copyPassword.Name = "copyPassword";
            this.copyPassword.Size = new System.Drawing.Size(151, 33);
            this.copyPassword.TabIndex = 22;
            this.copyPassword.Text = "Copy Password";
            this.copyPassword.UseVisualStyleBackColor = true;
            this.copyPassword.Click += new System.EventHandler(this.copyPassword_Click);
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(500, 472);
            this.Controls.Add(this.passwordControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PasswordGenerator";
            this.Text = "The Vault - Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            this.passwordControl.ResumeLayout(false);
            this.generatorPage.ResumeLayout(false);
            this.generatorPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown lengthUpDown;
        private System.Windows.Forms.CheckBox numbersCheck;
        private System.Windows.Forms.CheckBox specialCheck;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label genLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TabControl passwordControl;
        private System.Windows.Forms.TabPage generatorPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button readerSelectButton;
        private System.Windows.Forms.Button revealButton;
        private System.Windows.Forms.Label displayPasswordsLabel;
        private System.Windows.Forms.ListBox listBoxPasswords;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button copyPassword;
    }
}

