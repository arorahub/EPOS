namespace EPOS
{
    partial class frmNewUser
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
            this.txtNewFirstName = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewUserid = new System.Windows.Forms.TextBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.btnNewUserMainMenu = new System.Windows.Forms.Button();
            this.txtNewLastName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewFirstName
            // 
            this.txtNewFirstName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewFirstName.Location = new System.Drawing.Point(109, 119);
            this.txtNewFirstName.Multiline = true;
            this.txtNewFirstName.Name = "txtNewFirstName";
            this.txtNewFirstName.Size = new System.Drawing.Size(279, 33);
            this.txtNewFirstName.TabIndex = 1;
            this.txtNewFirstName.Text = "First Name";
            this.txtNewFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewFirstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtNewFirstName_MouseClick);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(109, 197);
            this.txtNewPass.Multiline = true;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(279, 33);
            this.txtNewPass.TabIndex = 2;
            this.txtNewPass.Text = "Password";
            this.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNewUserid
            // 
            this.txtNewUserid.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUserid.Location = new System.Drawing.Point(109, 81);
            this.txtNewUserid.Multiline = true;
            this.txtNewUserid.Name = "txtNewUserid";
            this.txtNewUserid.Size = new System.Drawing.Size(103, 33);
            this.txtNewUserid.TabIndex = 3;
            this.txtNewUserid.Text = "User ID";
            this.txtNewUserid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.Location = new System.Drawing.Point(57, 326);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(169, 35);
            this.btnNewUser.TabIndex = 6;
            this.btnNewUser.Text = "Create Account";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(109, 234);
            this.txtRole.Multiline = true;
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(279, 33);
            this.txtRole.TabIndex = 7;
            this.txtRole.Text = "Role";
            this.txtRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayRate.Location = new System.Drawing.Point(109, 273);
            this.txtPayRate.Multiline = true;
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(279, 33);
            this.txtPayRate.TabIndex = 8;
            this.txtPayRate.Text = "Pay Rate";
            this.txtPayRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNewUserMainMenu
            // 
            this.btnNewUserMainMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUserMainMenu.Location = new System.Drawing.Point(232, 326);
            this.btnNewUserMainMenu.Name = "btnNewUserMainMenu";
            this.btnNewUserMainMenu.Size = new System.Drawing.Size(175, 35);
            this.btnNewUserMainMenu.TabIndex = 9;
            this.btnNewUserMainMenu.Text = "Main Menu";
            this.btnNewUserMainMenu.UseVisualStyleBackColor = true;
            this.btnNewUserMainMenu.Click += new System.EventHandler(this.BtnNewUserMainMenu_Click);
            // 
            // txtNewLastName
            // 
            this.txtNewLastName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewLastName.Location = new System.Drawing.Point(109, 158);
            this.txtNewLastName.Multiline = true;
            this.txtNewLastName.Name = "txtNewLastName";
            this.txtNewLastName.Size = new System.Drawing.Size(279, 33);
            this.txtNewLastName.TabIndex = 10;
            this.txtNewLastName.Text = "Last Name";
            this.txtNewLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EPOS.Properties.Resources.New_User__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(42, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "PayRate";
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(442, 365);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewLastName);
            this.Controls.Add(this.btnNewUserMainMenu);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.txtNewUserid);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtNewFirstName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmNewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.FrmNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNewFirstName;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewUserid;
        private System.Windows.Forms.Button btnNewUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.Button btnNewUserMainMenu;
        private System.Windows.Forms.TextBox txtNewLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}