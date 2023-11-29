namespace EmployeeSalaryMgr.View
{
    partial class EditEmployeeView
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
            cancelBtn = new Button();
            editOkBtn = new Button();
            genderLabel = new Label();
            lastNameTxtBox = new TextBox();
            emailTxtBox = new TextBox();
            salaryTxtBox = new TextBox();
            positionTxtBox = new TextBox();
            firstNameTxtBox = new TextBox();
            positionLabel = new Label();
            genderComboBox = new ComboBox();
            salaryLabel = new Label();
            emailLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(500, 301);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 33);
            cancelBtn.TabIndex = 27;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // editOkBtn
            // 
            editOkBtn.Location = new Point(600, 301);
            editOkBtn.Name = "editOkBtn";
            editOkBtn.Size = new Size(94, 33);
            editOkBtn.TabIndex = 26;
            editOkBtn.Text = "OK";
            editOkBtn.UseVisualStyleBackColor = true;
            editOkBtn.Click += editOkBtn_Click;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(12, 81);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(57, 20);
            genderLabel.TabIndex = 25;
            genderLabel.Text = "Gender";
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.Location = new Point(425, 45);
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.Size = new Size(254, 27);
            lastNameTxtBox.TabIndex = 24;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(98, 112);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(236, 27);
            emailTxtBox.TabIndex = 23;
            // 
            // salaryTxtBox
            // 
            salaryTxtBox.Location = new Point(98, 181);
            salaryTxtBox.Name = "salaryTxtBox";
            salaryTxtBox.Size = new Size(151, 27);
            salaryTxtBox.TabIndex = 22;
            // 
            // positionTxtBox
            // 
            positionTxtBox.Location = new Point(98, 148);
            positionTxtBox.Name = "positionTxtBox";
            positionTxtBox.Size = new Size(236, 27);
            positionTxtBox.TabIndex = 21;
            // 
            // firstNameTxtBox
            // 
            firstNameTxtBox.Location = new Point(98, 45);
            firstNameTxtBox.Name = "firstNameTxtBox";
            firstNameTxtBox.Size = new Size(236, 27);
            firstNameTxtBox.TabIndex = 20;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(12, 151);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(61, 20);
            positionLabel.TabIndex = 19;
            positionLabel.Text = "Position";
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(98, 78);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(151, 28);
            genderComboBox.TabIndex = 18;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(12, 184);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(49, 20);
            salaryLabel.TabIndex = 17;
            salaryLabel.Text = "Salary";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(12, 115);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(340, 48);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 15;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 48);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 14;
            firstNameLabel.Text = "First Name";
            // 
            // EditEmployeeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 346);
            Controls.Add(cancelBtn);
            Controls.Add(editOkBtn);
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
            Name = "EditEmployeeView";
            Text = "EditEmployeeView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button editOkBtn;
        private Label genderLabel;
        private TextBox lastNameTxtBox;
        private TextBox emailTxtBox;
        private TextBox salaryTxtBox;
        private TextBox positionTxtBox;
        private TextBox firstNameTxtBox;
        private Label positionLabel;
        private ComboBox genderComboBox;
        private Label salaryLabel;
        private Label emailLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
    }
}