namespace MedicalStore
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbHome = new System.Windows.Forms.TabControl();
            this.tbRegistration = new System.Windows.Forms.TabPage();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.tbViewEmp = new System.Windows.Forms.TabPage();
            this.dgViewEmp = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.tbHome.SuspendLayout();
            this.tbRegistration.SuspendLayout();
            this.tbViewEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(400, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome User. Please select an option from the menu.";
            // 
            // tbHome
            // 
            this.tbHome.Controls.Add(this.tbRegistration);
            this.tbHome.Controls.Add(this.tbViewEmp);
            this.tbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHome.Location = new System.Drawing.Point(190, 67);
            this.tbHome.Name = "tbHome";
            this.tbHome.SelectedIndex = 0;
            this.tbHome.Size = new System.Drawing.Size(859, 446);
            this.tbHome.TabIndex = 1;
            // 
            // tbRegistration
            // 
            this.tbRegistration.BackColor = System.Drawing.Color.NavajoWhite;
            this.tbRegistration.Controls.Add(this.btnRegister);
            this.tbRegistration.Controls.Add(this.cmbDesignation);
            this.tbRegistration.Controls.Add(this.txtSalary);
            this.tbRegistration.Controls.Add(this.txtMobile);
            this.tbRegistration.Controls.Add(this.txtAddress);
            this.tbRegistration.Controls.Add(this.txtLName);
            this.tbRegistration.Controls.Add(this.lblSalary);
            this.tbRegistration.Controls.Add(this.lblDesignation);
            this.tbRegistration.Controls.Add(this.lblMobile);
            this.tbRegistration.Controls.Add(this.lblAddress);
            this.tbRegistration.Controls.Add(this.lblLName);
            this.tbRegistration.Controls.Add(this.txtFName);
            this.tbRegistration.Controls.Add(this.lblFName);
            this.tbRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbRegistration.Location = new System.Drawing.Point(4, 25);
            this.tbRegistration.Name = "tbRegistration";
            this.tbRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegistration.Size = new System.Drawing.Size(851, 417);
            this.tbRegistration.TabIndex = 0;
            this.tbRegistration.Text = "Registration";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegister.Location = new System.Drawing.Point(387, 207);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(128, 45);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(417, 138);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(168, 24);
            this.cmbDesignation.TabIndex = 11;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(417, 169);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(168, 23);
            this.txtSalary.TabIndex = 10;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(417, 107);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(168, 23);
            this.txtMobile.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(417, 77);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(168, 23);
            this.txtAddress.TabIndex = 8;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(417, 44);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(168, 23);
            this.txtLName.TabIndex = 7;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(308, 172);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(54, 17);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Salary";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(307, 138);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(94, 17);
            this.lblDesignation.TabIndex = 5;
            this.lblDesignation.Text = "Designation";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(308, 107);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(55, 17);
            this.lblMobile.TabIndex = 4;
            this.lblMobile.Text = "Mobile";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(308, 78);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 17);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(308, 49);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(85, 17);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(417, 11);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(168, 23);
            this.txtFName.TabIndex = 1;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(308, 14);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(86, 17);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // tbViewEmp
            // 
            this.tbViewEmp.BackColor = System.Drawing.Color.NavajoWhite;
            this.tbViewEmp.Controls.Add(this.dgViewEmp);
            this.tbViewEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbViewEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbViewEmp.Location = new System.Drawing.Point(4, 25);
            this.tbViewEmp.Name = "tbViewEmp";
            this.tbViewEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tbViewEmp.Size = new System.Drawing.Size(851, 417);
            this.tbViewEmp.TabIndex = 1;
            this.tbViewEmp.Text = "View Employees";
            // 
            // dgViewEmp
            // 
            this.dgViewEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewEmp.GridColor = System.Drawing.Color.Gainsboro;
            this.dgViewEmp.Location = new System.Drawing.Point(38, 28);
            this.dgViewEmp.Name = "dgViewEmp";
            this.dgViewEmp.Size = new System.Drawing.Size(773, 214);
            this.dgViewEmp.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(913, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 3;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbHome);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1120, 526);
            this.tbHome.ResumeLayout(false);
            this.tbRegistration.ResumeLayout(false);
            this.tbRegistration.PerformLayout();
            this.tbViewEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbHome;
        private System.Windows.Forms.TabPage tbRegistration;
        private System.Windows.Forms.TabPage tbViewEmp;
        private System.Windows.Forms.DataGridView dgViewEmp;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label label9;
    }
}
