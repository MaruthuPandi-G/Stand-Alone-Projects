namespace Employee_Management_System
{
    partial class EmployeeDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalaryDetails = new System.Windows.Forms.Button();
            this.buttonBankDetails = new System.Windows.Forms.Button();
            this.btnRelievedEmployee = new System.Windows.Forms.Button();
            this.btnEmployeeSuggestion = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.employeeDesignation = new System.Windows.Forms.ComboBox();
            this.employeeDepartment = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnSalaryDetails);
            this.panel1.Controls.Add(this.buttonBankDetails);
            this.panel1.Controls.Add(this.btnRelievedEmployee);
            this.panel1.Controls.Add(this.btnEmployeeSuggestion);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.employeeDesignation);
            this.panel1.Controls.Add(this.employeeDepartment);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.textBoxEmployeeId);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 184);
            this.panel1.TabIndex = 0;
            // 
            // btnSalaryDetails
            // 
            this.btnSalaryDetails.BackColor = System.Drawing.Color.Blue;
            this.btnSalaryDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalaryDetails.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalaryDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalaryDetails.Location = new System.Drawing.Point(614, 48);
            this.btnSalaryDetails.Name = "btnSalaryDetails";
            this.btnSalaryDetails.Size = new System.Drawing.Size(130, 30);
            this.btnSalaryDetails.TabIndex = 9;
            this.btnSalaryDetails.Text = "Salary Details";
            this.btnSalaryDetails.UseVisualStyleBackColor = false;
            this.btnSalaryDetails.Click += new System.EventHandler(this.btnSalaryDetails_Click);
            // 
            // buttonBankDetails
            // 
            this.buttonBankDetails.BackColor = System.Drawing.Color.Blue;
            this.buttonBankDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBankDetails.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.buttonBankDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBankDetails.Location = new System.Drawing.Point(455, 48);
            this.buttonBankDetails.Name = "buttonBankDetails";
            this.buttonBankDetails.Size = new System.Drawing.Size(130, 30);
            this.buttonBankDetails.TabIndex = 8;
            this.buttonBankDetails.Text = "Bank Details";
            this.buttonBankDetails.UseVisualStyleBackColor = false;
            this.buttonBankDetails.Click += new System.EventHandler(this.buttonBankDetails_Click);
            // 
            // btnRelievedEmployee
            // 
            this.btnRelievedEmployee.BackColor = System.Drawing.Color.Blue;
            this.btnRelievedEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelievedEmployee.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnRelievedEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelievedEmployee.Location = new System.Drawing.Point(731, 120);
            this.btnRelievedEmployee.Name = "btnRelievedEmployee";
            this.btnRelievedEmployee.Size = new System.Drawing.Size(156, 38);
            this.btnRelievedEmployee.TabIndex = 7;
            this.btnRelievedEmployee.Text = "Ex-Employee Details";
            this.btnRelievedEmployee.UseVisualStyleBackColor = false;
            this.btnRelievedEmployee.Click += new System.EventHandler(this.btnRelievedEmployee_Click);
            // 
            // btnEmployeeSuggestion
            // 
            this.btnEmployeeSuggestion.BackColor = System.Drawing.Color.Blue;
            this.btnEmployeeSuggestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeSuggestion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeSuggestion.ForeColor = System.Drawing.Color.Snow;
            this.btnEmployeeSuggestion.Location = new System.Drawing.Point(294, 48);
            this.btnEmployeeSuggestion.Name = "btnEmployeeSuggestion";
            this.btnEmployeeSuggestion.Size = new System.Drawing.Size(130, 30);
            this.btnEmployeeSuggestion.TabIndex = 6;
            this.btnEmployeeSuggestion.Text = "Suggestion Details";
            this.btnEmployeeSuggestion.UseVisualStyleBackColor = false;
            this.btnEmployeeSuggestion.Click += new System.EventHandler(this.btnEmployeeSuggestion_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(297, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // employeeDesignation
            // 
            this.employeeDesignation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.employeeDesignation.FormattingEnabled = true;
            this.employeeDesignation.Items.AddRange(new object[] {
            "General Manager",
            "Engineer",
            "Executive",
            "Associative",
            "Assistant Manager"});
            this.employeeDesignation.Location = new System.Drawing.Point(159, 120);
            this.employeeDesignation.Name = "employeeDesignation";
            this.employeeDesignation.Size = new System.Drawing.Size(121, 21);
            this.employeeDesignation.TabIndex = 4;
            this.employeeDesignation.SelectedIndexChanged += new System.EventHandler(this.employeeDesignation_SelectedIndexChanged);
            // 
            // employeeDepartment
            // 
            this.employeeDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.employeeDepartment.FormattingEnabled = true;
            this.employeeDepartment.Items.AddRange(new object[] {
            "Sales",
            "Production",
            "Finance",
            "Marketting",
            "Accounting",
            "House Management"});
            this.employeeDepartment.Location = new System.Drawing.Point(15, 120);
            this.employeeDepartment.Name = "employeeDepartment";
            this.employeeDepartment.Size = new System.Drawing.Size(121, 21);
            this.employeeDepartment.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Blue;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFind.Location = new System.Drawing.Point(133, 48);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(130, 30);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Personal Details";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(371, 12);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(148, 20);
            this.textBoxEmployeeId.TabIndex = 2;
            // 
            // dataGridViewEmployeeDetails
            // 
            this.dataGridViewEmployeeDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeDetails.Location = new System.Drawing.Point(0, 182);
            this.dataGridViewEmployeeDetails.Name = "dataGridViewEmployeeDetails";
            this.dataGridViewEmployeeDetails.Size = new System.Drawing.Size(909, 249);
            this.dataGridViewEmployeeDetails.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(778, 456);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 503);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewEmployeeDetails);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeDetails";
            this.Text = "EmployeeDetails";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeDetails;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Button btnRelievedEmployee;
        private System.Windows.Forms.Button btnEmployeeSuggestion;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox employeeDesignation;
        private System.Windows.Forms.ComboBox employeeDepartment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button buttonBankDetails;
        private System.Windows.Forms.Button btnSalaryDetails;
    }
}