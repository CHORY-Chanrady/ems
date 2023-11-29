namespace EmployeeSalaryMgr.View
{
    partial class GeneratePaySlipsView
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
            fromLabel = new Label();
            fromDatetimePicker = new DateTimePicker();
            toDatetimePicker = new DateTimePicker();
            toLable = new Label();
            OkBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Location = new Point(12, 38);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(43, 20);
            fromLabel.TabIndex = 1;
            fromLabel.Text = "From";
            // 
            // fromDatetimePicker
            // 
            fromDatetimePicker.Location = new Point(61, 38);
            fromDatetimePicker.Name = "fromDatetimePicker";
            fromDatetimePicker.Size = new Size(250, 27);
            fromDatetimePicker.TabIndex = 2;
            // 
            // toDatetimePicker
            // 
            toDatetimePicker.Location = new Point(61, 71);
            toDatetimePicker.Name = "toDatetimePicker";
            toDatetimePicker.Size = new Size(250, 27);
            toDatetimePicker.TabIndex = 4;
            // 
            // toLable
            // 
            toLable.AutoSize = true;
            toLable.Location = new Point(30, 76);
            toLable.Name = "toLable";
            toLable.Size = new Size(25, 20);
            toLable.TabIndex = 3;
            toLable.Text = "To";
            // 
            // OkBtn
            // 
            OkBtn.Location = new Point(235, 322);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(94, 29);
            OkBtn.TabIndex = 5;
            OkBtn.Text = "OK";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(135, 322);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // GeneratePaySlipsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 363);
            Controls.Add(cancelBtn);
            Controls.Add(OkBtn);
            Controls.Add(toDatetimePicker);
            Controls.Add(toLable);
            Controls.Add(fromDatetimePicker);
            Controls.Add(fromLabel);
            Name = "GeneratePaySlipsView";
            Text = "GeneratePaySlipsView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fromLabel;
        private DateTimePicker fromDatetimePicker;
        private DateTimePicker toDatetimePicker;
        private Label toLable;
        private Button OkBtn;
        private Button cancelBtn;
    }
}