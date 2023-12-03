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
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.numbersCheck = new System.Windows.Forms.CheckBox();
            this.specialCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lengthUpDown
            // 
            this.lengthUpDown.Location = new System.Drawing.Point(125, 111);
            this.lengthUpDown.Name = "lengthUpDown";
            this.lengthUpDown.Size = new System.Drawing.Size(125, 20);
            this.lengthUpDown.TabIndex = 3;
            // 
            // numbersCheck
            // 
            this.numbersCheck.AutoSize = true;
            this.numbersCheck.Location = new System.Drawing.Point(51, 56);
            this.numbersCheck.Name = "numbersCheck";
            this.numbersCheck.Size = new System.Drawing.Size(68, 17);
            this.numbersCheck.TabIndex = 4;
            this.numbersCheck.Text = "Numbers";
            this.numbersCheck.UseVisualStyleBackColor = true;
            // 
            // specialCheck
            // 
            this.specialCheck.AutoSize = true;
            this.specialCheck.Location = new System.Drawing.Point(125, 56);
            this.specialCheck.Name = "specialCheck";
            this.specialCheck.Size = new System.Drawing.Size(115, 17);
            this.specialCheck.TabIndex = 5;
            this.specialCheck.Text = "Special Characters";
            this.specialCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password Length:";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(33, 224);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(86, 23);
            this.copyButton.TabIndex = 7;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(159, 224);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 188);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(242, 20);
            this.outputTextBox.TabIndex = 10;
            this.outputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Generator: ";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(61, 149);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(155, 23);
            this.generateButton.TabIndex = 12;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 271);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.specialCheck);
            this.Controls.Add(this.numbersCheck);
            this.Controls.Add(this.lengthUpDown);
            this.Name = "PasswordGenerator";
            this.Text = "Password";
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown lengthUpDown;
        private System.Windows.Forms.CheckBox numbersCheck;
        private System.Windows.Forms.CheckBox specialCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButton;
    }
}

