namespace EPOS
{
    partial class Email
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
            this.txtSubj = new System.Windows.Forms.RichTextBox();
            this.txtRecipientEmail = new System.Windows.Forms.TextBox();
            this.txtEmailBody = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnEmailMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSubj
            // 
            this.txtSubj.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubj.Location = new System.Drawing.Point(10, 110);
            this.txtSubj.Name = "txtSubj";
            this.txtSubj.Size = new System.Drawing.Size(362, 30);
            this.txtSubj.TabIndex = 12;
            this.txtSubj.Text = "Subject";
            // 
            // txtRecipientEmail
            // 
            this.txtRecipientEmail.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipientEmail.Location = new System.Drawing.Point(10, 74);
            this.txtRecipientEmail.Multiline = true;
            this.txtRecipientEmail.Name = "txtRecipientEmail";
            this.txtRecipientEmail.Size = new System.Drawing.Size(362, 30);
            this.txtRecipientEmail.TabIndex = 11;
            this.txtRecipientEmail.Text = "Recipient Email";
            // 
            // txtEmailBody
            // 
            this.txtEmailBody.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmailBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailBody.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailBody.Location = new System.Drawing.Point(12, 146);
            this.txtEmailBody.Name = "txtEmailBody";
            this.txtEmailBody.Size = new System.Drawing.Size(360, 293);
            this.txtEmailBody.TabIndex = 10;
            this.txtEmailBody.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EPOS.Properties.Resources.Send_Email;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 53);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(10, 445);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(362, 67);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // btnEmailMainMenu
            // 
            this.btnEmailMainMenu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailMainMenu.Location = new System.Drawing.Point(10, 518);
            this.btnEmailMainMenu.Name = "btnEmailMainMenu";
            this.btnEmailMainMenu.Size = new System.Drawing.Size(362, 67);
            this.btnEmailMainMenu.TabIndex = 15;
            this.btnEmailMainMenu.Text = "Main Menu";
            this.btnEmailMainMenu.UseVisualStyleBackColor = true;
            this.btnEmailMainMenu.Click += new System.EventHandler(this.BtnEmailMainMenu_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(376, 587);
            this.Controls.Add(this.btnEmailMainMenu);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSubj);
            this.Controls.Add(this.txtRecipientEmail);
            this.Controls.Add(this.txtEmailBody);
            this.Name = "Email";
            this.Text = "Email";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtSubj;
        private System.Windows.Forms.TextBox txtRecipientEmail;
        private System.Windows.Forms.RichTextBox txtEmailBody;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnEmailMainMenu;
    }
}