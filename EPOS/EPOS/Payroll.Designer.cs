namespace EPOS
{
    partial class Payroll
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
            this.cboName = new System.Windows.Forms.ComboBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHourlyPay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculatePay = new System.Windows.Forms.Button();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboName
            // 
            this.cboName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(136, 93);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(200, 27);
            this.cboName.TabIndex = 0;
            this.cboName.SelectedIndexChanged += new System.EventHandler(this.CboName_SelectedIndexChanged);
            // 
            // txtPayRate
            // 
            this.txtPayRate.Enabled = false;
            this.txtPayRate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayRate.Location = new System.Drawing.Point(136, 126);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(59, 27);
            this.txtPayRate.TabIndex = 1;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWorked.Location = new System.Drawing.Point(136, 159);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(59, 27);
            this.txtHoursWorked.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::EPOS.Properties.Resources.Payroll;
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 19);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Employee Name";
            // 
            // lblHourlyPay
            // 
            this.lblHourlyPay.AutoSize = true;
            this.lblHourlyPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyPay.Location = new System.Drawing.Point(64, 129);
            this.lblHourlyPay.Name = "lblHourlyPay";
            this.lblHourlyPay.Size = new System.Drawing.Size(62, 19);
            this.lblHourlyPay.TabIndex = 6;
            this.lblHourlyPay.Text = "Payrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hours worked ";
            // 
            // btnCalculatePay
            // 
            this.btnCalculatePay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePay.Location = new System.Drawing.Point(25, 225);
            this.btnCalculatePay.Name = "btnCalculatePay";
            this.btnCalculatePay.Size = new System.Drawing.Size(127, 37);
            this.btnCalculatePay.TabIndex = 8;
            this.btnCalculatePay.Text = "Run";
            this.btnCalculatePay.UseVisualStyleBackColor = true;
            this.btnCalculatePay.Click += new System.EventHandler(this.BtnCalculatePay_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Enabled = false;
            this.lblPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(21, 195);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(109, 19);
            this.lblPay.TabIndex = 10;
            this.lblPay.Text = "Check Amount";
            // 
            // txtPay
            // 
            this.txtPay.Enabled = false;
            this.txtPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPay.Location = new System.Drawing.Point(136, 192);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(59, 27);
            this.txtPay.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(348, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.btnCalculatePay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHourlyPay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.cboName);
            this.Name = "Payroll";
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Payroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHourlyPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculatePay;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Button button1;
    }
}