namespace Employee
{
    partial class Form1
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNumberLabel = new System.Windows.Forms.Label();
            this.EmployeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.ShiftLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PayRateLabel = new System.Windows.Forms.Label();
            this.PayRateTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(146, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(87, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Employee Name:";
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(312, 36);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNameTextBox.TabIndex = 1;
            // 
            // EmployeeNumberLabel
            // 
            this.EmployeeNumberLabel.AutoSize = true;
            this.EmployeeNumberLabel.Location = new System.Drawing.Point(146, 80);
            this.EmployeeNumberLabel.Name = "EmployeeNumberLabel";
            this.EmployeeNumberLabel.Size = new System.Drawing.Size(96, 13);
            this.EmployeeNumberLabel.TabIndex = 2;
            this.EmployeeNumberLabel.Text = "Employee Number:";
            // 
            // EmployeeNumberTextBox
            // 
            this.EmployeeNumberTextBox.Location = new System.Drawing.Point(312, 73);
            this.EmployeeNumberTextBox.Name = "EmployeeNumberTextBox";
            this.EmployeeNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNumberTextBox.TabIndex = 3;
            // 
            // ShiftLabel
            // 
            this.ShiftLabel.AutoSize = true;
            this.ShiftLabel.Location = new System.Drawing.Point(146, 121);
            this.ShiftLabel.Name = "ShiftLabel";
            this.ShiftLabel.Size = new System.Drawing.Size(160, 13);
            this.ShiftLabel.TabIndex = 4;
            this.ShiftLabel.Text = "Employee Shift(Day=1, Night=2):";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(312, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // PayRateLabel
            // 
            this.PayRateLabel.AutoSize = true;
            this.PayRateLabel.Location = new System.Drawing.Point(149, 160);
            this.PayRateLabel.Name = "PayRateLabel";
            this.PayRateLabel.Size = new System.Drawing.Size(87, 13);
            this.PayRateLabel.TabIndex = 6;
            this.PayRateLabel.Text = "Hourly Pay Rate:";
            // 
            // PayRateTextBox
            // 
            this.PayRateTextBox.Location = new System.Drawing.Point(312, 153);
            this.PayRateTextBox.Name = "PayRateTextBox";
            this.PayRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.PayRateTextBox.TabIndex = 7;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(249, 220);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 23);
            this.EnterButton.TabIndex = 8;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PayRateTextBox);
            this.Controls.Add(this.PayRateLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ShiftLabel);
            this.Controls.Add(this.EmployeeNumberTextBox);
            this.Controls.Add(this.EmployeeNumberLabel);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.Label EmployeeNumberLabel;
        private System.Windows.Forms.TextBox EmployeeNumberTextBox;
        private System.Windows.Forms.Label ShiftLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label PayRateLabel;
        private System.Windows.Forms.TextBox PayRateTextBox;
        private System.Windows.Forms.Button EnterButton;
    }
}

