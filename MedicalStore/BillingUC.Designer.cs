namespace MedicalStore
{
    partial class BillingUC
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
            this.tbBilling = new System.Windows.Forms.TabControl();
            this.tbBill = new System.Windows.Forms.TabPage();
            this.lblTotalAmountDisplay = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgAllBill = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.txtBillingQuantity = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.lblBillingQuantity = new System.Windows.Forms.Label();
            this.lblCurrentQuantity = new System.Windows.Forms.Label();
            this.lblIName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgBillReport = new System.Windows.Forms.DataGridView();
            this.tbBilling.SuspendLayout();
            this.tbBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllBill)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBillReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBilling
            // 
            this.tbBilling.Controls.Add(this.tbBill);
            this.tbBilling.Controls.Add(this.tabPage2);
            this.tbBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBilling.Location = new System.Drawing.Point(3, 17);
            this.tbBilling.Name = "tbBilling";
            this.tbBilling.SelectedIndex = 0;
            this.tbBilling.Size = new System.Drawing.Size(1238, 628);
            this.tbBilling.TabIndex = 0;
            // 
            // tbBill
            // 
            this.tbBill.BackColor = System.Drawing.Color.NavajoWhite;
            this.tbBill.Controls.Add(this.lblTotalAmountDisplay);
            this.tbBill.Controls.Add(this.txtMobile);
            this.tbBill.Controls.Add(this.lblMobile);
            this.tbBill.Controls.Add(this.txtCName);
            this.tbBill.Controls.Add(this.lblCustomer);
            this.tbBill.Controls.Add(this.btnPrint);
            this.tbBill.Controls.Add(this.dgAllBill);
            this.tbBill.Controls.Add(this.txtPrice);
            this.tbBill.Controls.Add(this.lblPrice);
            this.tbBill.Controls.Add(this.btnAddBill);
            this.tbBill.Controls.Add(this.txtBillingQuantity);
            this.tbBill.Controls.Add(this.txtQuantity);
            this.tbBill.Controls.Add(this.cmbItemName);
            this.tbBill.Controls.Add(this.lblBillingQuantity);
            this.tbBill.Controls.Add(this.lblCurrentQuantity);
            this.tbBill.Controls.Add(this.lblIName);
            this.tbBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbBill.Location = new System.Drawing.Point(4, 25);
            this.tbBill.Name = "tbBill";
            this.tbBill.Padding = new System.Windows.Forms.Padding(3);
            this.tbBill.Size = new System.Drawing.Size(1230, 599);
            this.tbBill.TabIndex = 0;
            this.tbBill.Text = "New Bill";
            // 
            // lblTotalAmountDisplay
            // 
            this.lblTotalAmountDisplay.AutoSize = true;
            this.lblTotalAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTotalAmountDisplay.Location = new System.Drawing.Point(987, 71);
            this.lblTotalAmountDisplay.Name = "lblTotalAmountDisplay";
            this.lblTotalAmountDisplay.Size = new System.Drawing.Size(125, 52);
            this.lblTotalAmountDisplay.TabIndex = 37;
            this.lblTotalAmountDisplay.Text = "Total";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(625, 71);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(121, 23);
            this.txtMobile.TabIndex = 36;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(551, 74);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(55, 17);
            this.lblMobile.TabIndex = 35;
            this.lblMobile.Text = "Mobile";
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(348, 71);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(121, 23);
            this.txtCName.TabIndex = 34;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(239, 77);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(76, 17);
            this.lblCustomer.TabIndex = 33;
            this.lblCustomer.Text = "Customer";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.Location = new System.Drawing.Point(588, 102);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 37);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgAllBill
            // 
            this.dgAllBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgAllBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllBill.Location = new System.Drawing.Point(225, 145);
            this.dgAllBill.Name = "dgAllBill";
            this.dgAllBill.Size = new System.Drawing.Size(675, 174);
            this.dgAllBill.TabIndex = 31;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(636, 33);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(36, 23);
            this.txtPrice.TabIndex = 30;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(585, 36);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 17);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "Price";
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddBill.Location = new System.Drawing.Point(390, 99);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(110, 40);
            this.btnAddBill.TabIndex = 28;
            this.btnAddBill.Text = "Add To Kart";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // txtBillingQuantity
            // 
            this.txtBillingQuantity.Location = new System.Drawing.Point(874, 33);
            this.txtBillingQuantity.Name = "txtBillingQuantity";
            this.txtBillingQuantity.Size = new System.Drawing.Size(62, 23);
            this.txtBillingQuantity.TabIndex = 27;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(507, 31);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(36, 23);
            this.txtQuantity.TabIndex = 26;
            // 
            // cmbItemName
            // 
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(207, 30);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(121, 24);
            this.cmbItemName.TabIndex = 25;
            // 
            // lblBillingQuantity
            // 
            this.lblBillingQuantity.AutoSize = true;
            this.lblBillingQuantity.Location = new System.Drawing.Point(709, 36);
            this.lblBillingQuantity.Name = "lblBillingQuantity";
            this.lblBillingQuantity.Size = new System.Drawing.Size(120, 17);
            this.lblBillingQuantity.TabIndex = 24;
            this.lblBillingQuantity.Text = "Quantity To Bill";
            // 
            // lblCurrentQuantity
            // 
            this.lblCurrentQuantity.AutoSize = true;
            this.lblCurrentQuantity.Location = new System.Drawing.Point(373, 33);
            this.lblCurrentQuantity.Name = "lblCurrentQuantity";
            this.lblCurrentQuantity.Size = new System.Drawing.Size(128, 17);
            this.lblCurrentQuantity.TabIndex = 23;
            this.lblCurrentQuantity.Text = "Current Quantity";
            // 
            // lblIName
            // 
            this.lblIName.AutoSize = true;
            this.lblIName.Location = new System.Drawing.Point(112, 33);
            this.lblIName.Name = "lblIName";
            this.lblIName.Size = new System.Drawing.Size(84, 17);
            this.lblIName.TabIndex = 22;
            this.lblIName.Text = "Item Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPage2.Controls.Add(this.dgBillReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1230, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Sales";
            // 
            // dgBillReport
            // 
            this.dgBillReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgBillReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBillReport.Location = new System.Drawing.Point(71, 6);
            this.dgBillReport.Name = "dgBillReport";
            this.dgBillReport.Size = new System.Drawing.Size(1054, 379);
            this.dgBillReport.TabIndex = 0;
            // 
            // BillingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tbBilling);
            this.Name = "BillingUC";
            this.Size = new System.Drawing.Size(1221, 494);
            this.tbBilling.ResumeLayout(false);
            this.tbBill.ResumeLayout(false);
            this.tbBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllBill)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBillReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbBilling;
        private System.Windows.Forms.TabPage tbBill;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgAllBill;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.TextBox txtBillingQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.Label lblBillingQuantity;
        private System.Windows.Forms.Label lblCurrentQuantity;
        private System.Windows.Forms.Label lblIName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgBillReport;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblTotalAmountDisplay;
    }
}
