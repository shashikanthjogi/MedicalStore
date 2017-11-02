namespace MedicalStore
{
    partial class StockUC
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
            this.tbStock = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.dtEdate = new System.Windows.Forms.DateTimePicker();
            this.cmbCompanies = new System.Windows.Forms.ComboBox();
            this.txtSQuantity = new System.Windows.Forms.TextBox();
            this.txtSPrice = new System.Windows.Forms.TextBox();
            this.txtSItem = new System.Windows.Forms.TextBox();
            this.lblSEDate = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.lblSQuantity = new System.Windows.Forms.Label();
            this.lblSPrice = new System.Windows.Forms.Label();
            this.lblSItem = new System.Windows.Forms.Label();
            this.tbpgUpdStock = new System.Windows.Forms.TabPage();
            this.txtItPrice = new System.Windows.Forms.TextBox();
            this.iblIPrice = new System.Windows.Forms.Label();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.txtItQuantity = new System.Windows.Forms.TextBox();
            this.txtIQuantity = new System.Windows.Forms.TextBox();
            this.cboIName = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIQuantity = new System.Windows.Forms.Label();
            this.lblIName = new System.Windows.Forms.Label();
            this.tbpgDelStock = new System.Windows.Forms.TabPage();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnDelStock = new System.Windows.Forms.Button();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.tbpgViewStock = new System.Windows.Forms.TabPage();
            this.dgViewStock = new System.Windows.Forms.DataGridView();
            this.tbStock.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbpgUpdStock.SuspendLayout();
            this.tbpgDelStock.SuspendLayout();
            this.tbpgViewStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // tbStock
            // 
            this.tbStock.Controls.Add(this.tabPage1);
            this.tbStock.Controls.Add(this.tbpgUpdStock);
            this.tbStock.Controls.Add(this.tbpgDelStock);
            this.tbStock.Controls.Add(this.tbpgViewStock);
            this.tbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStock.Location = new System.Drawing.Point(78, 21);
            this.tbStock.Name = "tbStock";
            this.tbStock.SelectedIndex = 0;
            this.tbStock.Size = new System.Drawing.Size(1079, 522);
            this.tbStock.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPage1.Controls.Add(this.btnAddStock);
            this.tabPage1.Controls.Add(this.dtEdate);
            this.tabPage1.Controls.Add(this.cmbCompanies);
            this.tabPage1.Controls.Add(this.txtSQuantity);
            this.tabPage1.Controls.Add(this.txtSPrice);
            this.tabPage1.Controls.Add(this.txtSItem);
            this.tabPage1.Controls.Add(this.lblSEDate);
            this.tabPage1.Controls.Add(this.lblSName);
            this.tabPage1.Controls.Add(this.lblSQuantity);
            this.tabPage1.Controls.Add(this.lblSPrice);
            this.tabPage1.Controls.Add(this.lblSItem);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1071, 493);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Add Stock";
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddStock.Location = new System.Drawing.Point(420, 226);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(111, 44);
            this.btnAddStock.TabIndex = 15;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // dtEdate
            // 
            this.dtEdate.Location = new System.Drawing.Point(460, 170);
            this.dtEdate.Name = "dtEdate";
            this.dtEdate.Size = new System.Drawing.Size(169, 23);
            this.dtEdate.TabIndex = 14;
            // 
            // cmbCompanies
            // 
            this.cmbCompanies.FormattingEnabled = true;
            this.cmbCompanies.Location = new System.Drawing.Point(460, 129);
            this.cmbCompanies.Name = "cmbCompanies";
            this.cmbCompanies.Size = new System.Drawing.Size(169, 24);
            this.cmbCompanies.TabIndex = 12;
            // 
            // txtSQuantity
            // 
            this.txtSQuantity.Location = new System.Drawing.Point(460, 91);
            this.txtSQuantity.Name = "txtSQuantity";
            this.txtSQuantity.Size = new System.Drawing.Size(169, 23);
            this.txtSQuantity.TabIndex = 11;
            // 
            // txtSPrice
            // 
            this.txtSPrice.Location = new System.Drawing.Point(460, 54);
            this.txtSPrice.Name = "txtSPrice";
            this.txtSPrice.Size = new System.Drawing.Size(169, 23);
            this.txtSPrice.TabIndex = 10;
            // 
            // txtSItem
            // 
            this.txtSItem.Location = new System.Drawing.Point(460, 13);
            this.txtSItem.Name = "txtSItem";
            this.txtSItem.Size = new System.Drawing.Size(169, 23);
            this.txtSItem.TabIndex = 8;
            // 
            // lblSEDate
            // 
            this.lblSEDate.AutoSize = true;
            this.lblSEDate.Location = new System.Drawing.Point(283, 171);
            this.lblSEDate.Name = "lblSEDate";
            this.lblSEDate.Size = new System.Drawing.Size(91, 17);
            this.lblSEDate.TabIndex = 7;
            this.lblSEDate.Text = "Expiry Date";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(280, 133);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(120, 17);
            this.lblSName.TabIndex = 5;
            this.lblSName.Text = "Company Name";
            // 
            // lblSQuantity
            // 
            this.lblSQuantity.AutoSize = true;
            this.lblSQuantity.Location = new System.Drawing.Point(280, 91);
            this.lblSQuantity.Name = "lblSQuantity";
            this.lblSQuantity.Size = new System.Drawing.Size(69, 17);
            this.lblSQuantity.TabIndex = 4;
            this.lblSQuantity.Text = "Quantity";
            // 
            // lblSPrice
            // 
            this.lblSPrice.AutoSize = true;
            this.lblSPrice.Location = new System.Drawing.Point(280, 54);
            this.lblSPrice.Name = "lblSPrice";
            this.lblSPrice.Size = new System.Drawing.Size(80, 17);
            this.lblSPrice.TabIndex = 3;
            this.lblSPrice.Text = "Item Price";
            // 
            // lblSItem
            // 
            this.lblSItem.Location = new System.Drawing.Point(283, 16);
            this.lblSItem.Name = "lblSItem";
            this.lblSItem.Size = new System.Drawing.Size(91, 17);
            this.lblSItem.TabIndex = 2;
            this.lblSItem.Text = "Item Name";
            // 
            // tbpgUpdStock
            // 
            this.tbpgUpdStock.BackColor = System.Drawing.Color.NavajoWhite;
            this.tbpgUpdStock.Controls.Add(this.txtItPrice);
            this.tbpgUpdStock.Controls.Add(this.iblIPrice);
            this.tbpgUpdStock.Controls.Add(this.btnUpdateStock);
            this.tbpgUpdStock.Controls.Add(this.txtItQuantity);
            this.tbpgUpdStock.Controls.Add(this.txtIQuantity);
            this.tbpgUpdStock.Controls.Add(this.cboIName);
            this.tbpgUpdStock.Controls.Add(this.label11);
            this.tbpgUpdStock.Controls.Add(this.lblIQuantity);
            this.tbpgUpdStock.Controls.Add(this.lblIName);
            this.tbpgUpdStock.Location = new System.Drawing.Point(4, 25);
            this.tbpgUpdStock.Name = "tbpgUpdStock";
            this.tbpgUpdStock.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgUpdStock.Size = new System.Drawing.Size(1071, 493);
            this.tbpgUpdStock.TabIndex = 1;
            this.tbpgUpdStock.Text = "Update Stock";
            // 
            // txtItPrice
            // 
            this.txtItPrice.Location = new System.Drawing.Point(475, 166);
            this.txtItPrice.Name = "txtItPrice";
            this.txtItPrice.Size = new System.Drawing.Size(162, 23);
            this.txtItPrice.TabIndex = 8;
            // 
            // iblIPrice
            // 
            this.iblIPrice.AutoSize = true;
            this.iblIPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iblIPrice.Location = new System.Drawing.Point(320, 166);
            this.iblIPrice.Name = "iblIPrice";
            this.iblIPrice.Size = new System.Drawing.Size(45, 17);
            this.iblIPrice.TabIndex = 7;
            this.iblIPrice.Text = "Price";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateStock.Location = new System.Drawing.Point(429, 208);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(111, 47);
            this.btnUpdateStock.TabIndex = 6;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            // 
            // txtItQuantity
            // 
            this.txtItQuantity.Location = new System.Drawing.Point(475, 133);
            this.txtItQuantity.Name = "txtItQuantity";
            this.txtItQuantity.Size = new System.Drawing.Size(162, 23);
            this.txtItQuantity.TabIndex = 5;
            // 
            // txtIQuantity
            // 
            this.txtIQuantity.Location = new System.Drawing.Point(475, 105);
            this.txtIQuantity.Name = "txtIQuantity";
            this.txtIQuantity.Size = new System.Drawing.Size(162, 23);
            this.txtIQuantity.TabIndex = 4;
            // 
            // cboIName
            // 
            this.cboIName.FormattingEnabled = true;
            this.cboIName.Location = new System.Drawing.Point(475, 78);
            this.cboIName.Name = "cboIName";
            this.cboIName.Size = new System.Drawing.Size(162, 24);
            this.cboIName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(317, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Quantity";
            // 
            // lblIQuantity
            // 
            this.lblIQuantity.AutoSize = true;
            this.lblIQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIQuantity.Location = new System.Drawing.Point(317, 110);
            this.lblIQuantity.Name = "lblIQuantity";
            this.lblIQuantity.Size = new System.Drawing.Size(128, 17);
            this.lblIQuantity.TabIndex = 1;
            this.lblIQuantity.Text = "Current Quantity";
            // 
            // lblIName
            // 
            this.lblIName.AutoSize = true;
            this.lblIName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIName.Location = new System.Drawing.Point(317, 78);
            this.lblIName.Name = "lblIName";
            this.lblIName.Size = new System.Drawing.Size(84, 17);
            this.lblIName.TabIndex = 0;
            this.lblIName.Text = "Item Name";
            // 
            // tbpgDelStock
            // 
            this.tbpgDelStock.BackColor = System.Drawing.Color.NavajoWhite;
            this.tbpgDelStock.Controls.Add(this.txtItemQuantity);
            this.tbpgDelStock.Controls.Add(this.lblItemQuantity);
            this.tbpgDelStock.Controls.Add(this.lblItemName);
            this.tbpgDelStock.Controls.Add(this.btnDelStock);
            this.tbpgDelStock.Controls.Add(this.cboItemName);
            this.tbpgDelStock.Location = new System.Drawing.Point(4, 25);
            this.tbpgDelStock.Name = "tbpgDelStock";
            this.tbpgDelStock.Size = new System.Drawing.Size(1071, 493);
            this.tbpgDelStock.TabIndex = 2;
            this.tbpgDelStock.Text = "Delete Stock";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(565, 130);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(163, 23);
            this.txtItemQuantity.TabIndex = 6;
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemQuantity.Location = new System.Drawing.Point(408, 131);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(128, 17);
            this.lblItemQuantity.TabIndex = 5;
            this.lblItemQuantity.Text = "Current Quantity";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemName.Location = new System.Drawing.Point(408, 84);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(84, 17);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item Name";
            // 
            // btnDelStock
            // 
            this.btnDelStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelStock.Location = new System.Drawing.Point(481, 174);
            this.btnDelStock.Name = "btnDelStock";
            this.btnDelStock.Size = new System.Drawing.Size(140, 44);
            this.btnDelStock.TabIndex = 1;
            this.btnDelStock.Text = "DELETE STOCK";
            this.btnDelStock.UseVisualStyleBackColor = false;
            // 
            // cboItemName
            // 
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.Location = new System.Drawing.Point(565, 80);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(163, 24);
            this.cboItemName.TabIndex = 0;
            // 
            // tbpgViewStock
            // 
            this.tbpgViewStock.BackColor = System.Drawing.Color.NavajoWhite;
            this.tbpgViewStock.Controls.Add(this.dgViewStock);
            this.tbpgViewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpgViewStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpgViewStock.Location = new System.Drawing.Point(4, 25);
            this.tbpgViewStock.Name = "tbpgViewStock";
            this.tbpgViewStock.Size = new System.Drawing.Size(1071, 493);
            this.tbpgViewStock.TabIndex = 3;
            this.tbpgViewStock.Text = "View Stock";
            // 
            // dgViewStock
            // 
            this.dgViewStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewStock.Location = new System.Drawing.Point(98, 78);
            this.dgViewStock.Name = "dgViewStock";
            this.dgViewStock.Size = new System.Drawing.Size(914, 247);
            this.dgViewStock.TabIndex = 0;
            // 
            // StockUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tbStock);
            this.Name = "StockUC";
            this.Size = new System.Drawing.Size(1261, 546);
            this.tbStock.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbpgUpdStock.ResumeLayout(false);
            this.tbpgUpdStock.PerformLayout();
            this.tbpgDelStock.ResumeLayout(false);
            this.tbpgDelStock.PerformLayout();
            this.tbpgViewStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbStock;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblSQuantity;
        private System.Windows.Forms.Label lblSPrice;
        private System.Windows.Forms.Label lblSItem;
        private System.Windows.Forms.TabPage tbpgUpdStock;
        private System.Windows.Forms.TabPage tbpgDelStock;
        private System.Windows.Forms.TabPage tbpgViewStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.DateTimePicker dtEdate;
        private System.Windows.Forms.ComboBox cmbCompanies;
        private System.Windows.Forms.TextBox txtSQuantity;
        private System.Windows.Forms.TextBox txtSPrice;
        private System.Windows.Forms.TextBox txtSItem;
        private System.Windows.Forms.Label lblSEDate;
        private System.Windows.Forms.TextBox txtItQuantity;
        private System.Windows.Forms.TextBox txtIQuantity;
        private System.Windows.Forms.ComboBox cboIName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIQuantity;
        private System.Windows.Forms.Label lblIName;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnDelStock;
        private System.Windows.Forms.ComboBox cboItemName;
        private System.Windows.Forms.DataGridView dgViewStock;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.TextBox txtItPrice;
        private System.Windows.Forms.Label iblIPrice;
    }
}
