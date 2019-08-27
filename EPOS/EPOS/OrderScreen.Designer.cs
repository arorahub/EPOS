namespace EPOS
{
    partial class frmOrderScreen
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
            this.cboMenuItems = new System.Windows.Forms.ComboBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnOrderCompleted = new System.Windows.Forms.Button();
            this.txtTotalBforTax = new System.Windows.Forms.TextBox();
            this.lstvReceipt = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOrderPickItem = new System.Windows.Forms.Label();
            this.lblOrderInventoryView = new System.Windows.Forms.Label();
            this.lblOrderRecpiet = new System.Windows.Forms.Label();
            this.lblOrderTotalBeforeTax = new System.Windows.Forms.Label();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.txtOrderTax = new System.Windows.Forms.TextBox();
            this.lblOrderTax = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.txtOrderChange = new System.Windows.Forms.TextBox();
            this.lblOrderChange = new System.Windows.Forms.Label();
            this.txtOrderAmmountPaid = new System.Windows.Forms.TextBox();
            this.lblAmmountPaid = new System.Windows.Forms.Label();
            this.dgvInventoryMenuItemView = new System.Windows.Forms.DataGridView();
            this.btnOrderCheckOut = new System.Windows.Forms.Button();
            this.btnOrderRemoveItem = new System.Windows.Forms.Button();
            this.btnOrderNewOrder = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnOrderBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryMenuItemView)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMenuItems
            // 
            this.cboMenuItems.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMenuItems.FormattingEnabled = true;
            this.cboMenuItems.Location = new System.Drawing.Point(69, 519);
            this.cboMenuItems.Margin = new System.Windows.Forms.Padding(4);
            this.cboMenuItems.Name = "cboMenuItems";
            this.cboMenuItems.Size = new System.Drawing.Size(234, 27);
            this.cboMenuItems.TabIndex = 12;
            this.cboMenuItems.SelectedIndexChanged += new System.EventHandler(this.CboMenuItems_SelectedIndexChanged);
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemPrice.Location = new System.Drawing.Point(70, 560);
            this.txtItemPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemPrice.Multiline = true;
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(146, 28);
            this.txtItemPrice.TabIndex = 13;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(69, 596);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(126, 35);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnOrderCompleted
            // 
            this.btnOrderCompleted.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCompleted.Location = new System.Drawing.Point(453, 629);
            this.btnOrderCompleted.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderCompleted.Name = "btnOrderCompleted";
            this.btnOrderCompleted.Size = new System.Drawing.Size(141, 33);
            this.btnOrderCompleted.TabIndex = 18;
            this.btnOrderCompleted.Text = "Total";
            this.btnOrderCompleted.UseVisualStyleBackColor = true;
            this.btnOrderCompleted.Click += new System.EventHandler(this.BtnOrderCompleted_Click);
            // 
            // txtTotalBforTax
            // 
            this.txtTotalBforTax.Enabled = false;
            this.txtTotalBforTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBforTax.Location = new System.Drawing.Point(448, 519);
            this.txtTotalBforTax.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalBforTax.Multiline = true;
            this.txtTotalBforTax.Name = "txtTotalBforTax";
            this.txtTotalBforTax.Size = new System.Drawing.Size(146, 28);
            this.txtTotalBforTax.TabIndex = 19;
            this.txtTotalBforTax.Text = "$";
            // 
            // lstvReceipt
            // 
            this.lstvReceipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstvReceipt.Location = new System.Drawing.Point(370, 50);
            this.lstvReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.lstvReceipt.Name = "lstvReceipt";
            this.lstvReceipt.Size = new System.Drawing.Size(418, 462);
            this.lstvReceipt.TabIndex = 21;
            this.lstvReceipt.UseCompatibleStateImageBehavior = false;
            this.lstvReceipt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Items";
            this.columnHeader1.Width = 238;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price ";
            this.columnHeader2.Width = 161;
            // 
            // lblOrderPickItem
            // 
            this.lblOrderPickItem.AutoSize = true;
            this.lblOrderPickItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderPickItem.Location = new System.Drawing.Point(9, 523);
            this.lblOrderPickItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderPickItem.Name = "lblOrderPickItem";
            this.lblOrderPickItem.Size = new System.Drawing.Size(46, 19);
            this.lblOrderPickItem.TabIndex = 23;
            this.lblOrderPickItem.Text = "Items";
            // 
            // lblOrderInventoryView
            // 
            this.lblOrderInventoryView.AutoSize = true;
            this.lblOrderInventoryView.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderInventoryView.Location = new System.Drawing.Point(9, 25);
            this.lblOrderInventoryView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderInventoryView.Name = "lblOrderInventoryView";
            this.lblOrderInventoryView.Size = new System.Drawing.Size(71, 24);
            this.lblOrderInventoryView.TabIndex = 25;
            this.lblOrderInventoryView.Text = "Menu ";
            // 
            // lblOrderRecpiet
            // 
            this.lblOrderRecpiet.AutoSize = true;
            this.lblOrderRecpiet.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderRecpiet.Location = new System.Drawing.Point(366, 25);
            this.lblOrderRecpiet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderRecpiet.Name = "lblOrderRecpiet";
            this.lblOrderRecpiet.Size = new System.Drawing.Size(86, 24);
            this.lblOrderRecpiet.TabIndex = 26;
            this.lblOrderRecpiet.Text = "Receipt";
            // 
            // lblOrderTotalBeforeTax
            // 
            this.lblOrderTotalBeforeTax.AutoSize = true;
            this.lblOrderTotalBeforeTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotalBeforeTax.Location = new System.Drawing.Point(322, 526);
            this.lblOrderTotalBeforeTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTotalBeforeTax.Name = "lblOrderTotalBeforeTax";
            this.lblOrderTotalBeforeTax.Size = new System.Drawing.Size(118, 19);
            this.lblOrderTotalBeforeTax.TabIndex = 27;
            this.lblOrderTotalBeforeTax.Text = "Total Before Tax";
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderPrice.Location = new System.Drawing.Point(10, 565);
            this.lblOrderPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(43, 19);
            this.lblOrderPrice.TabIndex = 28;
            this.lblOrderPrice.Text = "Price";
            // 
            // txtOrderTax
            // 
            this.txtOrderTax.Enabled = false;
            this.txtOrderTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTax.Location = new System.Drawing.Point(446, 556);
            this.txtOrderTax.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderTax.Multiline = true;
            this.txtOrderTax.Name = "txtOrderTax";
            this.txtOrderTax.Size = new System.Drawing.Size(146, 28);
            this.txtOrderTax.TabIndex = 29;
            this.txtOrderTax.Text = "$";
            // 
            // lblOrderTax
            // 
            this.lblOrderTax.AutoSize = true;
            this.lblOrderTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTax.Location = new System.Drawing.Point(407, 564);
            this.lblOrderTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTax.Name = "lblOrderTax";
            this.lblOrderTax.Size = new System.Drawing.Size(31, 19);
            this.lblOrderTax.TabIndex = 30;
            this.lblOrderTax.Text = "Tax";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Enabled = false;
            this.txtOrderTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTotal.Location = new System.Drawing.Point(446, 593);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderTotal.Multiline = true;
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(146, 28);
            this.txtOrderTotal.TabIndex = 31;
            this.txtOrderTotal.Text = "$";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.Location = new System.Drawing.Point(400, 602);
            this.lblOrderTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(43, 19);
            this.lblOrderTotal.TabIndex = 32;
            this.lblOrderTotal.Text = "Total";
            // 
            // txtOrderChange
            // 
            this.txtOrderChange.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderChange.Location = new System.Drawing.Point(702, 554);
            this.txtOrderChange.Name = "txtOrderChange";
            this.txtOrderChange.Size = new System.Drawing.Size(86, 27);
            this.txtOrderChange.TabIndex = 36;
            this.txtOrderChange.Text = "$";
            // 
            // lblOrderChange
            // 
            this.lblOrderChange.AutoSize = true;
            this.lblOrderChange.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderChange.Location = new System.Drawing.Point(600, 557);
            this.lblOrderChange.Name = "lblOrderChange";
            this.lblOrderChange.Size = new System.Drawing.Size(90, 19);
            this.lblOrderChange.TabIndex = 35;
            this.lblOrderChange.Text = "Change Due";
            // 
            // txtOrderAmmountPaid
            // 
            this.txtOrderAmmountPaid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderAmmountPaid.Location = new System.Drawing.Point(702, 516);
            this.txtOrderAmmountPaid.Name = "txtOrderAmmountPaid";
            this.txtOrderAmmountPaid.Size = new System.Drawing.Size(86, 27);
            this.txtOrderAmmountPaid.TabIndex = 34;
            this.txtOrderAmmountPaid.Text = "$";
            // 
            // lblAmmountPaid
            // 
            this.lblAmmountPaid.AutoSize = true;
            this.lblAmmountPaid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmountPaid.Location = new System.Drawing.Point(598, 519);
            this.lblAmmountPaid.Name = "lblAmmountPaid";
            this.lblAmmountPaid.Size = new System.Drawing.Size(99, 19);
            this.lblAmmountPaid.TabIndex = 33;
            this.lblAmmountPaid.Text = "Amount Paid";
            // 
            // dgvInventoryMenuItemView
            // 
            this.dgvInventoryMenuItemView.AllowUserToAddRows = false;
            this.dgvInventoryMenuItemView.AllowUserToDeleteRows = false;
            this.dgvInventoryMenuItemView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryMenuItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryMenuItemView.Location = new System.Drawing.Point(12, 50);
            this.dgvInventoryMenuItemView.Name = "dgvInventoryMenuItemView";
            this.dgvInventoryMenuItemView.ReadOnly = true;
            this.dgvInventoryMenuItemView.Size = new System.Drawing.Size(357, 462);
            this.dgvInventoryMenuItemView.TabIndex = 37;
            // 
            // btnOrderCheckOut
            // 
            this.btnOrderCheckOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCheckOut.Location = new System.Drawing.Point(642, 588);
            this.btnOrderCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderCheckOut.Name = "btnOrderCheckOut";
            this.btnOrderCheckOut.Size = new System.Drawing.Size(146, 33);
            this.btnOrderCheckOut.TabIndex = 38;
            this.btnOrderCheckOut.Text = "Check Out";
            this.btnOrderCheckOut.UseVisualStyleBackColor = true;
            this.btnOrderCheckOut.Click += new System.EventHandler(this.btnOrderCheckOut_Click);
            // 
            // btnOrderRemoveItem
            // 
            this.btnOrderRemoveItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderRemoveItem.Location = new System.Drawing.Point(70, 639);
            this.btnOrderRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderRemoveItem.Name = "btnOrderRemoveItem";
            this.btnOrderRemoveItem.Size = new System.Drawing.Size(126, 35);
            this.btnOrderRemoveItem.TabIndex = 39;
            this.btnOrderRemoveItem.Text = "Remove Item";
            this.btnOrderRemoveItem.UseVisualStyleBackColor = true;
            this.btnOrderRemoveItem.Click += new System.EventHandler(this.BtnOrderRemoveItem_Click);
            // 
            // btnOrderNewOrder
            // 
            this.btnOrderNewOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderNewOrder.Location = new System.Drawing.Point(642, 633);
            this.btnOrderNewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderNewOrder.Name = "btnOrderNewOrder";
            this.btnOrderNewOrder.Size = new System.Drawing.Size(143, 29);
            this.btnOrderNewOrder.TabIndex = 40;
            this.btnOrderNewOrder.Text = "New Order";
            this.btnOrderNewOrder.UseVisualStyleBackColor = true;
            this.btnOrderNewOrder.Click += new System.EventHandler(this.BtnOrderNewOrder_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(515, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 26);
            this.dateTimePicker1.TabIndex = 41;
            this.dateTimePicker1.Value = new System.DateTime(2019, 8, 4, 0, 0, 0, 0);
            // 
            // btnOrderBackToMenu
            // 
            this.btnOrderBackToMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderBackToMenu.Location = new System.Drawing.Point(642, 673);
            this.btnOrderBackToMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderBackToMenu.Name = "btnOrderBackToMenu";
            this.btnOrderBackToMenu.Size = new System.Drawing.Size(143, 29);
            this.btnOrderBackToMenu.TabIndex = 42;
            this.btnOrderBackToMenu.Text = "Main Menu";
            this.btnOrderBackToMenu.UseVisualStyleBackColor = true;
            this.btnOrderBackToMenu.Click += new System.EventHandler(this.BtnOrderBackToMenu_Click);
            // 
            // frmOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(790, 709);
            this.Controls.Add(this.btnOrderBackToMenu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnOrderNewOrder);
            this.Controls.Add(this.btnOrderRemoveItem);
            this.Controls.Add(this.btnOrderCheckOut);
            this.Controls.Add(this.dgvInventoryMenuItemView);
            this.Controls.Add(this.txtOrderChange);
            this.Controls.Add(this.lblOrderChange);
            this.Controls.Add(this.txtOrderAmmountPaid);
            this.Controls.Add(this.lblAmmountPaid);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.lblOrderTax);
            this.Controls.Add(this.txtOrderTax);
            this.Controls.Add(this.lblOrderPrice);
            this.Controls.Add(this.lblOrderTotalBeforeTax);
            this.Controls.Add(this.lblOrderRecpiet);
            this.Controls.Add(this.lblOrderInventoryView);
            this.Controls.Add(this.lblOrderPickItem);
            this.Controls.Add(this.lstvReceipt);
            this.Controls.Add(this.txtTotalBforTax);
            this.Controls.Add(this.btnOrderCompleted);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.cboMenuItems);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrderScreen";
            this.Text = "Order Screen";
            this.Load += new System.EventHandler(this.FrmOrderScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryMenuItemView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMenuItems;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnOrderCompleted;
        private System.Windows.Forms.TextBox txtTotalBforTax;
        private System.Windows.Forms.ListView lstvReceipt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblOrderPickItem;
        private System.Windows.Forms.Label lblOrderInventoryView;
        private System.Windows.Forms.Label lblOrderRecpiet;
        private System.Windows.Forms.Label lblOrderTotalBeforeTax;
        private System.Windows.Forms.Label lblOrderPrice;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtOrderTax;
        private System.Windows.Forms.Label lblOrderTax;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.TextBox txtOrderChange;
        private System.Windows.Forms.Label lblOrderChange;
        private System.Windows.Forms.TextBox txtOrderAmmountPaid;
        private System.Windows.Forms.Label lblAmmountPaid;
        private System.Windows.Forms.DataGridView dgvInventoryMenuItemView;
        private System.Windows.Forms.Button btnOrderCheckOut;
        private System.Windows.Forms.Button btnOrderRemoveItem;
        private System.Windows.Forms.Button btnOrderNewOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnOrderBackToMenu;
    }
}