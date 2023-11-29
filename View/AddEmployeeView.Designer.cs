namespace EmployeeSalaryMgr.View
{
    partial class AddEmployeeView
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            salaryLabel = new Label();
            genderComboBox = new ComboBox();
            positionLabel = new Label();
            firstNameTxtBox = new TextBox();
            positionTxtBox = new TextBox();
            salaryTxtBox = new TextBox();
            emailTxtBox = new TextBox();
            lastNameTxtBox = new TextBox();
            genderLabel = new Label();
            addBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 50);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(340, 50);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(12, 117);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(12, 186);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(49, 20);
            salaryLabel.TabIndex = 3;
            salaryLabel.Text = "Salary";
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(98, 80);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(151, 28);
            genderComboBox.TabIndex = 4;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(12, 153);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(61, 20);
            positionLabel.TabIndex = 5;
            positionLabel.Text = "Position";
            // 
            // firstNameTxtBox
            // 
            firstNameTxtBox.Location = new Point(98, 47);
            firstNameTxtBox.Name = "firstNameTxtBox";
            firstNameTxtBox.Size = new Size(236, 27);
            firstNameTxtBox.TabIndex = 6;
            // 
            // positionTxtBox
            // 
            positionTxtBox.Location = new Point(98, 150);
            positionTxtBox.Name = "positionTxtBox";
            positionTxtBox.Size = new Size(236, 27);
            positionTxtBox.TabIndex = 7;
            // 
            // salaryTxtBox
            // 
            salaryTxtBox.Location = new Point(98, 183);
            salaryTxtBox.Name = "salaryTxtBox";
            salaryTxtBox.Size = new Size(151, 27);
            salaryTxtBox.TabIndex = 8;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(98, 114);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(236, 27);
            emailTxtBox.TabIndex = 9;
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.Location = new Point(425, 47);
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.Size = new Size(254, 27);
            lastNameTxtBox.TabIndex = 10;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(12, 83);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(57, 20);
            genderLabel.TabIndex = 11;
            genderLabel.Text = "Gender";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(600, 301);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 33);
            addBtn.TabIndex = 12;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(500, 301);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 33);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // AddEmployeeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 346);
            Controls.Add(cancelBtn);
            Controls.Add(addBtn);
            Controls.Add(genderLabel);
            Controls.Add(lastNameTxtBox);
            Controls.Add(emailTxtBox);
            Controls.Add(salaryTxtBox);
            Controls.Add(positionTxtBox);
            Controls.Add(firstNameTxtBox);
            Controls.Add(positionLabel);
            Controls.Add(genderComboBox);
            Controls.Add(salaryLabel);
            Controls.Add(emailLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "AddEmployeeView";
            Text = "AddEmployeeView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label salaryLabel;
        private ComboBox genderComboBox;
        private Label positionLabel;
        private TextBox firstNameTxtBox;
        private TextBox positionTxtBox;
        private TextBox salaryTxtBox;
        private TextBox emailTxtBox;
        private TextBox lastNameTxtBox;
        private Label genderLabel;
        private Button addBtn;
        private Button cancelBtn;
    }
}