namespace EPOS
{
    partial class frmMainLogin
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
            this.txtLoginIDUser = new System.Windows.Forms.TextBox();
            this.txtLoginPassUser = new System.Windows.Forms.TextBox();
            this.btnLoginUser = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoginIDUser
            // 
            this.txtLoginIDUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginIDUser.Location = new System.Drawing.Point(-1, 215);
            this.txtLoginIDUser.Name = "txtLoginIDUser";
            this.txtLoginIDUser.Size = new System.Drawing.Size(100, 26);
            this.txtLoginIDUser.TabIndex = 0;
            this.txtLoginIDUser.Text = "ID";
            this.txtLoginIDUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLoginIDUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtLoginIDUser_MouseClick);
            // 
            // txtLoginPassUser
            // 
            this.txtLoginPassUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassUser.Location = new System.Drawing.Point(225, 215);
            this.txtLoginPassUser.Name = "txtLoginPassUser";
            this.txtLoginPassUser.PasswordChar = '*';
            this.txtLoginPassUser.Size = new System.Drawing.Size(100, 26);
            this.txtLoginPassUser.TabIndex = 1;
            this.txtLoginPassUser.Text = "Password";
            this.txtLoginPassUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLoginPassUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtLoginPassUser_MouseClick);
            // 
            // btnLoginUser
            // 
            this.btnLoginUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginUser.Location = new System.Drawing.Point(-1, 247);
            this.btnLoginUser.Name = "btnLoginUser";
            this.btnLoginUser.Size = new System.Drawing.Size(100, 38);
            this.btnLoginUser.TabIndex = 3;
            this.btnLoginUser.Text = "Login";
            this.btnLoginUser.UseVisualStyleBackColor = true;
            this.btnLoginUser.Click += new System.EventHandler(this.BtnLoginUser_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.Location = new System.Drawing.Point(225, 247);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(100, 38);
            this.btnNewUser.TabIndex = 4;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EPOS.Properties.Resources.EPOS__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 206);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(325, 286);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnLoginUser);
            this.Controls.Add(this.txtLoginPassUser);
            this.Controls.Add(this.txtLoginIDUser);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "frmMainLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPOS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginIDUser;
        private System.Windows.Forms.TextBox txtLoginPassUser;
        private System.Windows.Forms.Button btnLoginUser;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

