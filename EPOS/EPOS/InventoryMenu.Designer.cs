namespace EPOS
{
    partial class InventoryMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryMenu));
            this.txtUpdateInventoryName = new System.Windows.Forms.TextBox();
            this.pnlViewInventory = new System.Windows.Forms.Panel();
            this.dgvInventoryMenuItemView = new System.Windows.Forms.DataGridView();
            this.picInventoryMenuViewTitle = new System.Windows.Forms.PictureBox();
            this.btnInventoryMenuViewReport = new System.Windows.Forms.Button();
            this.pnlUpdateInventory = new System.Windows.Forms.Panel();
            this.txtUpdateInventoryPrice = new System.Windows.Forms.TextBox();
            this.lblUpdateInventoryPrice = new System.Windows.Forms.Label();
            this.btnUpdateInventoryAddNewItem = new System.Windows.Forms.Button();
            this.lblUpdateInventoryPriceToBiz = new System.Windows.Forms.Label();
            this.lblUpdateInventoryName = new System.Windows.Forms.Label();
            this.txtUpdateInventoryPriceToBiz = new System.Windows.Forms.TextBox();
            this.picUpdateInventoryTitle = new System.Windows.Forms.PictureBox();
            this.btnInventoryMenuView = new System.Windows.Forms.Button();
            this.btnInventoryUpdate = new System.Windows.Forms.Button();
            this.btnInventoryMainmenu = new System.Windows.Forms.Button();
            this.pnlViewInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryMenuItemView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryMenuViewTitle)).BeginInit();
            this.pnlUpdateInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateInventoryTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUpdateInventoryName
            // 
            this.txtUpdateInventoryName.Location = new System.Drawing.Point(210, 75);
            this.txtUpdateInventoryName.Multiline = true;
            this.txtUpdateInventoryName.Name = "txtUpdateInventoryName";
            this.txtUpdateInventoryName.Size = new System.Drawing.Size(159, 21);
            this.txtUpdateInventoryName.TabIndex = 1;
            // 
            // pnlViewInventory
            // 
            this.pnlViewInventory.Controls.Add(this.dgvInventoryMenuItemView);
            this.pnlViewInventory.Controls.Add(this.picInventoryMenuViewTitle);
            this.pnlViewInventory.Controls.Add(this.btnInventoryMenuViewReport);
            this.pnlViewInventory.Location = new System.Drawing.Point(2, 3);
            this.pnlViewInventory.Name = "pnlViewInventory";
            this.pnlViewInventory.Size = new System.Drawing.Size(496, 482);
            this.pnlViewInventory.TabIndex = 4;
            // 
            // dgvInventoryMenuItemView
            // 
            this.dgvInventoryMenuItemView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryMenuItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryMenuItemView.Location = new System.Drawing.Point(0, 87);
            this.dgvInventoryMenuItemView.Name = "dgvInventoryMenuItemView";
            this.dgvInventoryMenuItemView.Size = new System.Drawing.Size(483, 324);
            this.dgvInventoryMenuItemView.TabIndex = 9;
            // 
            // picInventoryMenuViewTitle
            // 
            this.picInventoryMenuViewTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picInventoryMenuViewTitle.BackgroundImage")));
            this.picInventoryMenuViewTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picInventoryMenuViewTitle.Location = new System.Drawing.Point(44, 9);
            this.picInventoryMenuViewTitle.Name = "picInventoryMenuViewTitle";
            this.picInventoryMenuViewTitle.Size = new System.Drawing.Size(401, 70);
            this.picInventoryMenuViewTitle.TabIndex = 10;
            this.picInventoryMenuViewTitle.TabStop = false;
            // 
            // btnInventoryMenuViewReport
            // 
            this.btnInventoryMenuViewReport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryMenuViewReport.Location = new System.Drawing.Point(131, 417);
            this.btnInventoryMenuViewReport.Name = "btnInventoryMenuViewReport";
            this.btnInventoryMenuViewReport.Size = new System.Drawing.Size(179, 47);
            this.btnInventoryMenuViewReport.TabIndex = 3;
            this.btnInventoryMenuViewReport.Text = "Run Report";
            this.btnInventoryMenuViewReport.UseVisualStyleBackColor = true;
            this.btnInventoryMenuViewReport.Click += new System.EventHandler(this.BtnInventoryMenuViewReport_Click);
            // 
            // pnlUpdateInventory
            // 
            this.pnlUpdateInventory.Controls.Add(this.txtUpdateInventoryPrice);
            this.pnlUpdateInventory.Controls.Add(this.lblUpdateInventoryPrice);
            this.pnlUpdateInventory.Controls.Add(this.btnUpdateInventoryAddNewItem);
            this.pnlUpdateInventory.Controls.Add(this.lblUpdateInventoryPriceToBiz);
            this.pnlUpdateInventory.Controls.Add(this.lblUpdateInventoryName);
            this.pnlUpdateInventory.Controls.Add(this.txtUpdateInventoryPriceToBiz);
            this.pnlUpdateInventory.Controls.Add(this.picUpdateInventoryTitle);
            this.pnlUpdateInventory.Controls.Add(this.txtUpdateInventoryName);
            this.pnlUpdateInventory.Location = new System.Drawing.Point(504, 3);
            this.pnlUpdateInventory.Name = "pnlUpdateInventory";
            this.pnlUpdateInventory.Size = new System.Drawing.Size(533, 279);
            this.pnlUpdateInventory.TabIndex = 5;
            // 
            // txtUpdateInventoryPrice
            // 
            this.txtUpdateInventoryPrice.Location = new System.Drawing.Point(210, 127);
            this.txtUpdateInventoryPrice.Multiline = true;
            this.txtUpdateInventoryPrice.Name = "txtUpdateInventoryPrice";
            this.txtUpdateInventoryPrice.Size = new System.Drawing.Size(49, 21);
            this.txtUpdateInventoryPrice.TabIndex = 21;
            this.txtUpdateInventoryPrice.Text = "$";
            // 
            // lblUpdateInventoryPrice
            // 
            this.lblUpdateInventoryPrice.AutoSize = true;
            this.lblUpdateInventoryPrice.Location = new System.Drawing.Point(147, 130);
            this.lblUpdateInventoryPrice.Name = "lblUpdateInventoryPrice";
            this.lblUpdateInventoryPrice.Size = new System.Drawing.Size(57, 13);
            this.lblUpdateInventoryPrice.TabIndex = 18;
            this.lblUpdateInventoryPrice.Text = "Item Price ";
            this.lblUpdateInventoryPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUpdateInventoryAddNewItem
            // 
            this.btnUpdateInventoryAddNewItem.Location = new System.Drawing.Point(280, 127);
            this.btnUpdateInventoryAddNewItem.Name = "btnUpdateInventoryAddNewItem";
            this.btnUpdateInventoryAddNewItem.Size = new System.Drawing.Size(89, 23);
            this.btnUpdateInventoryAddNewItem.TabIndex = 16;
            this.btnUpdateInventoryAddNewItem.Text = "Update Item";
            this.btnUpdateInventoryAddNewItem.UseVisualStyleBackColor = true;
            this.btnUpdateInventoryAddNewItem.Click += new System.EventHandler(this.btnUpdateInventoryAddNewItem_Click);
            // 
            // lblUpdateInventoryPriceToBiz
            // 
            this.lblUpdateInventoryPriceToBiz.AutoSize = true;
            this.lblUpdateInventoryPriceToBiz.Location = new System.Drawing.Point(146, 103);
            this.lblUpdateInventoryPriceToBiz.Name = "lblUpdateInventoryPriceToBiz";
            this.lblUpdateInventoryPriceToBiz.Size = new System.Drawing.Size(57, 13);
            this.lblUpdateInventoryPriceToBiz.TabIndex = 15;
            this.lblUpdateInventoryPriceToBiz.Text = "Cost to Biz";
            this.lblUpdateInventoryPriceToBiz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUpdateInventoryName
            // 
            this.lblUpdateInventoryName.AutoSize = true;
            this.lblUpdateInventoryName.Location = new System.Drawing.Point(146, 78);
            this.lblUpdateInventoryName.Name = "lblUpdateInventoryName";
            this.lblUpdateInventoryName.Size = new System.Drawing.Size(58, 13);
            this.lblUpdateInventoryName.TabIndex = 14;
            this.lblUpdateInventoryName.Text = "Item Name";
            this.lblUpdateInventoryName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUpdateInventoryPriceToBiz
            // 
            this.txtUpdateInventoryPriceToBiz.Location = new System.Drawing.Point(210, 100);
            this.txtUpdateInventoryPriceToBiz.Multiline = true;
            this.txtUpdateInventoryPriceToBiz.Name = "txtUpdateInventoryPriceToBiz";
            this.txtUpdateInventoryPriceToBiz.Size = new System.Drawing.Size(49, 21);
            this.txtUpdateInventoryPriceToBiz.TabIndex = 12;
            this.txtUpdateInventoryPriceToBiz.Text = "$";
            // 
            // picUpdateInventoryTitle
            // 
            this.picUpdateInventoryTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUpdateInventoryTitle.BackgroundImage")));
            this.picUpdateInventoryTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUpdateInventoryTitle.Location = new System.Drawing.Point(0, 3);
            this.picUpdateInventoryTitle.Name = "picUpdateInventoryTitle";
            this.picUpdateInventoryTitle.Size = new System.Drawing.Size(529, 60);
            this.picUpdateInventoryTitle.TabIndex = 11;
            this.picUpdateInventoryTitle.TabStop = false;
            // 
            // btnInventoryMenuView
            // 
            this.btnInventoryMenuView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryMenuView.Location = new System.Drawing.Point(691, 298);
            this.btnInventoryMenuView.Name = "btnInventoryMenuView";
            this.btnInventoryMenuView.Size = new System.Drawing.Size(154, 52);
            this.btnInventoryMenuView.TabIndex = 6;
            this.btnInventoryMenuView.Text = "View Inventory";
            this.btnInventoryMenuView.UseVisualStyleBackColor = true;
            this.btnInventoryMenuView.Click += new System.EventHandler(this.BtnInventoryMenuView_Click);
            // 
            // btnInventoryUpdate
            // 
            this.btnInventoryUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryUpdate.Location = new System.Drawing.Point(518, 298);
            this.btnInventoryUpdate.Name = "btnInventoryUpdate";
            this.btnInventoryUpdate.Size = new System.Drawing.Size(154, 52);
            this.btnInventoryUpdate.TabIndex = 7;
            this.btnInventoryUpdate.Text = "Update Inventory";
            this.btnInventoryUpdate.UseVisualStyleBackColor = true;
            this.btnInventoryUpdate.Click += new System.EventHandler(this.BtnInventoryUpdate_Click);
            // 
            // btnInventoryMainmenu
            // 
            this.btnInventoryMainmenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryMainmenu.Location = new System.Drawing.Point(869, 298);
            this.btnInventoryMainmenu.Name = "btnInventoryMainmenu";
            this.btnInventoryMainmenu.Size = new System.Drawing.Size(154, 52);
            this.btnInventoryMainmenu.TabIndex = 8;
            this.btnInventoryMainmenu.Text = "Main Menu";
            this.btnInventoryMainmenu.UseVisualStyleBackColor = true;
            this.btnInventoryMainmenu.Click += new System.EventHandler(this.BtnInventoryMainmenu_Click);
            // 
            // InventoryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 494);
            this.Controls.Add(this.btnInventoryMainmenu);
            this.Controls.Add(this.btnInventoryUpdate);
            this.Controls.Add(this.btnInventoryMenuView);
            this.Controls.Add(this.pnlViewInventory);
            this.Controls.Add(this.pnlUpdateInventory);
            this.Name = "InventoryMenu";
            this.Text = "InventoryMenu";
            this.Load += new System.EventHandler(this.InventoryMenu_Load);
            this.pnlViewInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryMenuItemView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryMenuViewTitle)).EndInit();
            this.pnlUpdateInventory.ResumeLayout(false);
            this.pnlUpdateInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateInventoryTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtUpdateInventoryName;
        private System.Windows.Forms.Panel pnlViewInventory;
        private System.Windows.Forms.Button btnInventoryMenuViewReport;
        private System.Windows.Forms.Panel pnlUpdateInventory;
        private System.Windows.Forms.Button btnInventoryMenuView;
        private System.Windows.Forms.Button btnInventoryUpdate;
        private System.Windows.Forms.Button btnInventoryMainmenu;
        private System.Windows.Forms.PictureBox picInventoryMenuViewTitle;
        private System.Windows.Forms.Label lblUpdateInventoryPriceToBiz;
        private System.Windows.Forms.Label lblUpdateInventoryName;
        private System.Windows.Forms.TextBox txtUpdateInventoryPriceToBiz;
        private System.Windows.Forms.PictureBox picUpdateInventoryTitle;
        private System.Windows.Forms.Button btnUpdateInventoryAddNewItem;
        private System.Windows.Forms.TextBox txtUpdateInventoryPrice;
        private System.Windows.Forms.Label lblUpdateInventoryPrice;
        private System.Windows.Forms.DataGridView dgvInventoryMenuItemView;
    }
}