namespace HMSYS
{
    partial class frm_Login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_err_ID = new System.Windows.Forms.Label();
            this.lbl_err_password = new System.Windows.Forms.Label();
            this.lbl_Incorrect_Login = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_login.Location = new System.Drawing.Point(209, 168);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 38);
            this.btn_login.TabIndex = 26;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cancel.Location = new System.Drawing.Point(316, 168);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(92, 38);
            this.btn_cancel.TabIndex = 25;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_Password.Location = new System.Drawing.Point(160, 118);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(163, 27);
            this.txt_Password.TabIndex = 24;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_ID.Location = new System.Drawing.Point(163, 61);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(163, 27);
            this.txt_ID.TabIndex = 23;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            // 
            // lbl_Password
            // 
            this.lbl_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Password.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Password.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Password.Location = new System.Drawing.Point(64, 118);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(70, 27);
            this.lbl_Password.TabIndex = 22;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.Click += new System.EventHandler(this.lbl_Password_Click);
            // 
            // lbl_err_ID
            // 
            this.lbl_err_ID.AutoSize = true;
            this.lbl_err_ID.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err_ID.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_ID.Location = new System.Drawing.Point(332, 64);
            this.lbl_err_ID.Name = "lbl_err_ID";
            this.lbl_err_ID.Size = new System.Drawing.Size(0, 24);
            this.lbl_err_ID.TabIndex = 21;
            this.lbl_err_ID.Click += new System.EventHandler(this.lbl_err_ID_Click);
            // 
            // lbl_err_password
            // 
            this.lbl_err_password.AutoSize = true;
            this.lbl_err_password.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err_password.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_password.Location = new System.Drawing.Point(329, 118);
            this.lbl_err_password.Name = "lbl_err_password";
            this.lbl_err_password.Size = new System.Drawing.Size(0, 24);
            this.lbl_err_password.TabIndex = 20;
            this.lbl_err_password.Click += new System.EventHandler(this.lbl_err_userName_Click);
            // 
            // lbl_Incorrect_Login
            // 
            this.lbl_Incorrect_Login.AutoSize = true;
            this.lbl_Incorrect_Login.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lbl_Incorrect_Login.ForeColor = System.Drawing.Color.Red;
            this.lbl_Incorrect_Login.Location = new System.Drawing.Point(160, 217);
            this.lbl_Incorrect_Login.Name = "lbl_Incorrect_Login";
            this.lbl_Incorrect_Login.Size = new System.Drawing.Size(0, 24);
            this.lbl_Incorrect_Login.TabIndex = 19;
            this.lbl_Incorrect_Login.Click += new System.EventHandler(this.lbl_Incorrect_Login_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_ID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_ID.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_ID.Location = new System.Drawing.Point(64, 61);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(70, 27);
            this.lbl_ID.TabIndex = 18;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Click += new System.EventHandler(this.lbl_ID_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(455, 278);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_err_ID);
            this.Controls.Add(this.lbl_err_password);
            this.Controls.Add(this.lbl_Incorrect_Login);
            this.Controls.Add(this.lbl_ID);
            this.Name = "frm_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_err_ID;
        private System.Windows.Forms.Label lbl_err_password;
        private System.Windows.Forms.Label lbl_Incorrect_Login;
        private System.Windows.Forms.Label lbl_ID;

    }
}

