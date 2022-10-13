namespace Employee_Management_System
{
    partial class EmployeeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMobileNumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxEmpNumber = new System.Windows.Forms.TextBox();
            this.btnEmployeeLogin = new System.Windows.Forms.Button();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmployeeRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.labelMobileNumber);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.textBoxEmpNumber);
            this.panel1.Controls.Add(this.btnEmployeeLogin);
            this.panel1.Controls.Add(this.textBoxEmpName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(310, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 223);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelMobileNumber
            // 
            this.labelMobileNumber.AutoSize = true;
            this.labelMobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelMobileNumber.Location = new System.Drawing.Point(264, 144);
            this.labelMobileNumber.Name = "labelMobileNumber";
            this.labelMobileNumber.Size = new System.Drawing.Size(0, 16);
            this.labelMobileNumber.TabIndex = 7;
            this.labelMobileNumber.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(264, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 16);
            this.labelName.TabIndex = 6;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // textBoxEmpNumber
            // 
            this.textBoxEmpNumber.Location = new System.Drawing.Point(68, 141);
            this.textBoxEmpNumber.Name = "textBoxEmpNumber";
            this.textBoxEmpNumber.Size = new System.Drawing.Size(190, 20);
            this.textBoxEmpNumber.TabIndex = 4;
            this.textBoxEmpNumber.UseSystemPasswordChar = true;
            // 
            // btnEmployeeLogin
            // 
            this.btnEmployeeLogin.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEmployeeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeLogin.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeeLogin.Location = new System.Drawing.Point(236, 184);
            this.btnEmployeeLogin.Name = "btnEmployeeLogin";
            this.btnEmployeeLogin.Size = new System.Drawing.Size(110, 30);
            this.btnEmployeeLogin.TabIndex = 5;
            this.btnEmployeeLogin.Text = "Sign In";
            this.btnEmployeeLogin.UseVisualStyleBackColor = false;
            this.btnEmployeeLogin.Click += new System.EventHandler(this.btnEmployeeLogin_Click);
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Location = new System.Drawing.Point(68, 60);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(190, 20);
            this.textBoxEmpName.TabIndex = 3;
            this.textBoxEmpName.TextChanged += new System.EventHandler(this.textBoxEmpName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mobile Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEmployeeRegister
            // 
            this.btnEmployeeRegister.BackColor = System.Drawing.Color.SlateGray;
            this.btnEmployeeRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeRegister.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnEmployeeRegister.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeeRegister.Location = new System.Drawing.Point(310, 380);
            this.btnEmployeeRegister.Name = "btnEmployeeRegister";
            this.btnEmployeeRegister.Size = new System.Drawing.Size(362, 36);
            this.btnEmployeeRegister.TabIndex = 6;
            this.btnEmployeeRegister.Text = "Register";
            this.btnEmployeeRegister.UseVisualStyleBackColor = false;
            this.btnEmployeeRegister.Click += new System.EventHandler(this.btnEmployeeRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(322, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Or If you don\'t have an Account Please Register";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(909, 503);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEmployeeRegister);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeLogin";
            this.Text = "Employee Login";
            this.Load += new System.EventHandler(this.EmployeeLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmpNumber;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.Button btnEmployeeLogin;
        private System.Windows.Forms.Button btnEmployeeRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMobileNumber;
        private System.Windows.Forms.Label labelName;
    }
}