namespace MedicalStore
{
    partial class LoginUC
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
            this.tbLogin = new System.Windows.Forms.TabControl();
            this.tbpgLogin = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLogin.SuspendLayout();
            this.tbpgLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Controls.Add(this.tbpgLogin);
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(161, 50);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.SelectedIndex = 0;
            this.tbLogin.Size = new System.Drawing.Size(943, 361);
            this.tbLogin.TabIndex = 13;
            // 
            // tbpgLogin
            // 
            this.tbpgLogin.BackColor = System.Drawing.Color.NavajoWhite;
            this.tbpgLogin.Controls.Add(this.btnLogin);
            this.tbpgLogin.Controls.Add(this.btnReset);
            this.tbpgLogin.Controls.Add(this.txtPass);
            this.tbpgLogin.Controls.Add(this.txtUName);
            this.tbpgLogin.Controls.Add(this.lblPassword);
            this.tbpgLogin.Controls.Add(this.lblUName);
            this.tbpgLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpgLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbpgLogin.Location = new System.Drawing.Point(4, 22);
            this.tbpgLogin.Name = "tbpgLogin";
            this.tbpgLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgLogin.Size = new System.Drawing.Size(935, 335);
            this.tbpgLogin.TabIndex = 0;
            this.tbpgLogin.Text = "LOGIN";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLogin.Location = new System.Drawing.Point(393, 126);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 56);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.YellowGreen;
            this.btnReset.Location = new System.Drawing.Point(535, 126);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 56);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(493, 77);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(208, 20);
            this.txtPass.TabIndex = 5;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(493, 35);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(208, 20);
            this.txtUName.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(329, 77);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUName.Location = new System.Drawing.Point(329, 38);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(83, 17);
            this.lblUName.TabIndex = 2;
            this.lblUName.Text = "UserName";
            
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLogin);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(1293, 573);
            this.tbLogin.ResumeLayout(false);
            this.tbpgLogin.ResumeLayout(false);
            this.tbpgLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbLogin;
        private System.Windows.Forms.TabPage tbpgLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
