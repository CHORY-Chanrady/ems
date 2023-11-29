namespace EmployeeSalaryMgr
{
    partial class EmployeeView
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
            employeeDgv = new DataGridView();
            addEmployeeBtn = new Button();
            deleteEmployeeBtn = new Button();
            editEmployeeBtn = new Button();
            calculateSalaryBtn = new Button();
            searchTxtBox = new TextBox();
            filterComboBox = new ComboBox();
            filterLabel = new Label();
            searchLabel = new Label();
            generateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeDgv).BeginInit();
            SuspendLayout();
            // 
            // employeeDgv
            // 
            employeeDgv.AllowUserToAddRows = false;
            employeeDgv.AllowUserToDeleteRows = false;
            employeeDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeeDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeDgv.BackgroundColor = SystemColors.Control;
            employeeDgv.BorderStyle = BorderStyle.Fixed3D;
            employeeDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDgv.GridColor = Color.Gainsboro;
            employeeDgv.Location = new Point(12, 79);
            employeeDgv.MultiSelect = false;
            employeeDgv.Name = "employeeDgv";
            employeeDgv.ReadOnly = true;
            employeeDgv.RowHeadersWidth = 51;
            employeeDgv.RowTemplate.Height = 29;
            employeeDgv.Size = new Size(1045, 420);
            employeeDgv.TabIndex = 0;
            employeeDgv.CellContentClick += employeeDgv_CellContentClick;
            // 
            // addEmployeeBtn
            // 
            addEmployeeBtn.Location = new Point(12, 12);
            addEmployeeBtn.Name = "addEmployeeBtn";
            addEmployeeBtn.Size = new Size(65, 30);
            addEmployeeBtn.TabIndex = 1;
            addEmployeeBtn.Text = "add";
            addEmployeeBtn.UseVisualStyleBackColor = true;
            addEmployeeBtn.Click += addEmployeeBtn_Click;
            // 
            // deleteEmployeeBtn
            // 
            deleteEmployeeBtn.Location = new Point(154, 12);
            deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            deleteEmployeeBtn.Size = new Size(65, 30);
            deleteEmployeeBtn.TabIndex = 2;
            deleteEmployeeBtn.Text = "delete";
            deleteEmployeeBtn.UseVisualStyleBackColor = true;
            deleteEmployeeBtn.Click += deleteEmployeeBtn_Click;
            // 
            // editEmployeeBtn
            // 
            editEmployeeBtn.Location = new Point(83, 12);
            editEmployeeBtn.Name = "editEmployeeBtn";
            editEmployeeBtn.Size = new Size(65, 30);
            editEmployeeBtn.TabIndex = 3;
            editEmployeeBtn.Text = "edit";
            editEmployeeBtn.UseVisualStyleBackColor = true;
            editEmployeeBtn.Click += editEmployeeBtn_Click;
            // 
            // calculateSalaryBtn
            // 
            calculateSalaryBtn.Location = new Point(225, 12);
            calculateSalaryBtn.Name = "calculateSalaryBtn";
            calculateSalaryBtn.Size = new Size(90, 30);
            calculateSalaryBtn.TabIndex = 4;
            calculateSalaryBtn.Text = "calculate";
            calculateSalaryBtn.UseVisualStyleBackColor = true;
            calculateSalaryBtn.Click += calculateSalaryBtn_Click;
            // 
            // searchTxtBox
            // 
            searchTxtBox.Location = new Point(445, 14);
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.Size = new Size(267, 27);
            searchTxtBox.TabIndex = 5;
            searchTxtBox.TextChanged += searchTxtBox_TextChanged;
            // 
            // filterComboBox
            // 
            filterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Location = new Point(445, 45);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(219, 28);
            filterComboBox.TabIndex = 7;
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Location = new Point(386, 48);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(42, 20);
            filterLabel.TabIndex = 8;
            filterLabel.Text = "Filter";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(386, 17);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(53, 20);
            searchLabel.TabIndex = 9;
            searchLabel.Text = "Search";
            // 
            // generateBtn
            // 
            generateBtn.Location = new Point(12, 48);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(158, 29);
            generateBtn.TabIndex = 10;
            generateBtn.Text = "Generate Pay slips";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 511);
            Controls.Add(generateBtn);
            Controls.Add(searchLabel);
            Controls.Add(filterLabel);
            Controls.Add(filterComboBox);
            Controls.Add(searchTxtBox);
            Controls.Add(calculateSalaryBtn);
            Controls.Add(editEmployeeBtn);
            Controls.Add(deleteEmployeeBtn);
            Controls.Add(addEmployeeBtn);
            Controls.Add(employeeDgv);
            Name = "EmployeeView";
            Text = "EmployeeView";
            Load += EmployeeView_Load;
            ((System.ComponentModel.ISupportInitialize)employeeDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView employeeDgv;
        private Button addEmployeeBtn;
        private Button deleteEmployeeBtn;
        private Button editEmployeeBtn;
        private Button calculateSalaryBtn;
        private TextBox searchTxtBox;
        private ComboBox filterComboBox;
        private Label filterLabel;
        private Label searchLabel;
        private Button generateBtn;
    }
}