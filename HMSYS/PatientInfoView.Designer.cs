namespace HMSYS
{
    partial class PatientInfoView
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_fatherName = new System.Windows.Forms.Label();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_fatherName = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_err_id = new System.Windows.Forms.Label();
            this.lbl_err_firstName = new System.Windows.Forms.Label();
            this.lbl_err_fatherName = new System.Windows.Forms.Label();
            this.lbl_err_mobile = new System.Windows.Forms.Label();
            this.lbl_err_email = new System.Windows.Forms.Label();
            this.lbl_err_userID = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_GetMessage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_id.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_id.Location = new System.Drawing.Point(27, 27);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(84, 18);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_firstName.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_firstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_firstName.Location = new System.Drawing.Point(21, 69);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(90, 20);
            this.lbl_firstName.TabIndex = 1;
            this.lbl_firstName.Text = "First name";
            this.lbl_firstName.Click += new System.EventHandler(this.lbl_firstName_Click);
            // 
            // lbl_fatherName
            // 
            this.lbl_fatherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_fatherName.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_fatherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_fatherName.Location = new System.Drawing.Point(21, 120);
            this.lbl_fatherName.Name = "lbl_fatherName";
            this.lbl_fatherName.Size = new System.Drawing.Size(90, 20);
            this.lbl_fatherName.TabIndex = 2;
            this.lbl_fatherName.Text = "Father name";
            this.lbl_fatherName.Click += new System.EventHandler(this.lbl_fatherName_Click);
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_mobile.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_mobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_mobile.Location = new System.Drawing.Point(21, 168);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(90, 20);
            this.lbl_mobile.TabIndex = 3;
            this.lbl_mobile.Text = "Mobile";
            // 
            // lbl_email
            // 
            this.lbl_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_email.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_email.Location = new System.Drawing.Point(21, 217);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(90, 20);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Email";
            // 
            // lbl_userName
            // 
            this.lbl_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_userName.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_userName.Location = new System.Drawing.Point(21, 267);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(90, 20);
            this.lbl_userName.TabIndex = 5;
            this.lbl_userName.Text = "User id";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_id.Location = new System.Drawing.Point(130, 25);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(136, 27);
            this.txt_id.TabIndex = 6;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // txt_firstName
            // 
            this.txt_firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_firstName.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_firstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_firstName.Location = new System.Drawing.Point(130, 69);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(136, 27);
            this.txt_firstName.TabIndex = 7;
            // 
            // txt_fatherName
            // 
            this.txt_fatherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_fatherName.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_fatherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_fatherName.Location = new System.Drawing.Point(130, 121);
            this.txt_fatherName.Name = "txt_fatherName";
            this.txt_fatherName.Size = new System.Drawing.Size(136, 27);
            this.txt_fatherName.TabIndex = 8;
            // 
            // txt_mobile
            // 
            this.txt_mobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_mobile.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_mobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_mobile.Location = new System.Drawing.Point(130, 168);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(136, 27);
            this.txt_mobile.TabIndex = 9;
            this.txt_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobile_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_email.Location = new System.Drawing.Point(130, 213);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(136, 27);
            this.txt_email.TabIndex = 10;
            // 
            // txt_userID
            // 
            this.txt_userID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_userID.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_userID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_userID.Location = new System.Drawing.Point(130, 267);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(136, 27);
            this.txt_userID.TabIndex = 11;
            this.txt_userID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_userID_KeyPress);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Add.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Add.Location = new System.Drawing.Point(351, 22);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 23);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_err_id
            // 
            this.lbl_err_id.AutoSize = true;
            this.lbl_err_id.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_err_id.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_id.Location = new System.Drawing.Point(272, 25);
            this.lbl_err_id.Name = "lbl_err_id";
            this.lbl_err_id.Size = new System.Drawing.Size(0, 19);
            this.lbl_err_id.TabIndex = 13;
            // 
            // lbl_err_firstName
            // 
            this.lbl_err_firstName.AutoSize = true;
            this.lbl_err_firstName.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_err_firstName.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_firstName.Location = new System.Drawing.Point(272, 69);
            this.lbl_err_firstName.Name = "lbl_err_firstName";
            this.lbl_err_firstName.Size = new System.Drawing.Size(0, 19);
            this.lbl_err_firstName.TabIndex = 14;
            // 
            // lbl_err_fatherName
            // 
            this.lbl_err_fatherName.AutoSize = true;
            this.lbl_err_fatherName.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_err_fatherName.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_fatherName.Location = new System.Drawing.Point(272, 121);
            this.lbl_err_fatherName.Name = "lbl_err_fatherName";
            this.lbl_err_fatherName.Size = new System.Drawing.Size(0, 19);
            this.lbl_err_fatherName.TabIndex = 15;
            // 
            // lbl_err_mobile
            // 
            this.lbl_err_mobile.AutoSize = true;
            this.lbl_err_mobile.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_err_mobile.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_mobile.Location = new System.Drawing.Point(256, 175);
            this.lbl_err_mobile.Name = "lbl_err_mobile";
            this.lbl_err_mobile.Size = new System.Drawing.Size(0, 19);
            this.lbl_err_mobile.TabIndex = 16;
            // 
            // lbl_err_email
            // 
            this.lbl_err_email.AutoSize = true;
            this.lbl_err_email.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_err_email.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_email.Location = new System.Drawing.Point(272, 213);
            this.lbl_err_email.Name = "lbl_err_email";
            this.lbl_err_email.Size = new System.Drawing.Size(0, 19);
            this.lbl_err_email.TabIndex = 17;
            // 
            // lbl_err_userID
            // 
            this.lbl_err_userID.AutoSize = true;
            this.lbl_err_userID.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_err_userID.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_userID.Location = new System.Drawing.Point(272, 267);
            this.lbl_err_userID.Name = "lbl_err_userID";
            this.lbl_err_userID.Size = new System.Drawing.Size(0, 19);
            this.lbl_err_userID.TabIndex = 18;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Edit.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Edit.Location = new System.Drawing.Point(351, 80);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 23);
            this.btn_Edit.TabIndex = 19;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Delete.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Delete.Location = new System.Drawing.Point(351, 51);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 23);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Select.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Select.Location = new System.Drawing.Point(351, 109);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(100, 23);
            this.btn_Select.TabIndex = 21;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_GetMessage
            // 
            this.btn_GetMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_GetMessage.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_GetMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_GetMessage.Location = new System.Drawing.Point(351, 151);
            this.btn_GetMessage.Name = "btn_GetMessage";
            this.btn_GetMessage.Size = new System.Drawing.Size(100, 23);
            this.btn_GetMessage.TabIndex = 22;
            this.btn_GetMessage.Text = "Get message";
            this.btn_GetMessage.UseVisualStyleBackColor = false;
            this.btn_GetMessage.Click += new System.EventHandler(this.btn_GetMessage_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(530, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(279, 216);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_new.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_new.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_new.Location = new System.Drawing.Point(351, 190);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(100, 23);
            this.btn_new.TabIndex = 24;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // PatientInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(821, 345);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_GetMessage);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.lbl_err_userID);
            this.Controls.Add(this.lbl_err_email);
            this.Controls.Add(this.lbl_err_mobile);
            this.Controls.Add(this.lbl_err_fatherName);
            this.Controls.Add(this.lbl_err_firstName);
            this.Controls.Add(this.lbl_err_id);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.txt_fatherName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_mobile);
            this.Controls.Add(this.lbl_fatherName);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.lbl_id);
            this.Name = "PatientInfoView";
            this.Text = "PatientInfoView";
            this.Load += new System.EventHandler(this.PatientInfoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_fatherName;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_fatherName;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_err_id;
        private System.Windows.Forms.Label lbl_err_firstName;
        private System.Windows.Forms.Label lbl_err_fatherName;
        private System.Windows.Forms.Label lbl_err_mobile;
        private System.Windows.Forms.Label lbl_err_email;
        private System.Windows.Forms.Label lbl_err_userID;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_GetMessage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_new;
    }
}