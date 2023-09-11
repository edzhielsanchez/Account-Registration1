namespace Account_Registration
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStudentNo = new TextBox();
            label1 = new Label();
            txtLastName = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            Address = new Label();
            txtAddress = new RichTextBox();
            label5 = new Label();
            txtContactNo = new TextBox();
            FirstName = new Label();
            txtFirstName = new TextBox();
            Program = new Label();
            cbProgram = new ComboBox();
            txtMiddleName = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(12, 30);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(164, 23);
            txtStudentNo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Student No.:";
            // 
            // txtLastName
            // 
            txtLastName.AutoSize = true;
            txtLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.Location = new Point(12, 61);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(65, 15);
            txtLastName.TabIndex = 3;
            txtLastName.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 5;
            label3.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(12, 126);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(164, 23);
            txtAge.TabIndex = 4;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Address.Location = new Point(12, 155);
            Address.Name = "Address";
            Address.Size = new Size(51, 15);
            Address.TabIndex = 6;
            Address.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 175);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(504, 97);
            txtAddress.TabIndex = 0;
            txtAddress.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(182, 108);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 12;
            label5.Text = "Contact No.:";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(182, 126);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(164, 23);
            txtContactNo.TabIndex = 11;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FirstName.Location = new Point(182, 61);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(67, 15);
            FirstName.TabIndex = 10;
            FirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(182, 79);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(164, 23);
            txtFirstName.TabIndex = 9;
            // 
            // Program
            // 
            Program.AutoSize = true;
            Program.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Program.Location = new Point(182, 12);
            Program.Name = "Program";
            Program.Size = new Size(55, 15);
            Program.TabIndex = 8;
            Program.Text = "Program";
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(182, 30);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(272, 23);
            cbProgram.TabIndex = 13;
            // 
            // txtMiddleName
            // 
            txtMiddleName.AutoSize = true;
            txtMiddleName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMiddleName.Location = new Point(352, 61);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(81, 15);
            txtMiddleName.TabIndex = 14;
            txtMiddleName.Text = "Middle Name";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(352, 79);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(164, 23);
            textBox6.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Location = new Point(227, 278);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 16;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 311);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(txtMiddleName);
            Controls.Add(cbProgram);
            Controls.Add(label5);
            Controls.Add(txtContactNo);
            Controls.Add(FirstName);
            Controls.Add(txtFirstName);
            Controls.Add(Program);
            Controls.Add(txtAddress);
            Controls.Add(Address);
            Controls.Add(label3);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(txtStudentNo);
            Name = "FrmRegistration";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentNo;
        private Label label1;
        private Label txtLastName;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtAge;
        private Label Address;
        private RichTextBox txtAddress;
        private Label label5;
        private TextBox txtContactNo;
        private Label FirstName;
        private TextBox txtFirstName;
        private Label Program;
        private ComboBox cbProgram;
        private Label txtMiddleName;
        private TextBox textBox6;
        private Button button1;
    }
}