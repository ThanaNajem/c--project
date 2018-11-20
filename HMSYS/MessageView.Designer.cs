namespace HMSYS
{
    partial class MessageView
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
            this.lbl_PATIENT_ID = new System.Windows.Forms.Label();
            this.txt_PATIENT_ID = new System.Windows.Forms.TextBox();
            this.lbl_ToUser = new System.Windows.Forms.Label();
            this.lbl_FromUser = new System.Windows.Forms.Label();
            this.txt_FromUser = new System.Windows.Forms.TextBox();
            this.lbl_MessageDate = new System.Windows.Forms.Label();
            this.lbl_MessageBody = new System.Windows.Forms.Label();
            this.txt_MessageBody = new System.Windows.Forms.TextBox();
            this.dtp_MessageDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Get_Message = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.lbl_err_PATIENT_ID = new System.Windows.Forms.Label();
            this.lbl_err_ToUser = new System.Windows.Forms.Label();
            this.lbl_err_FromUser = new System.Windows.Forms.Label();
            this.lbl_err_MessageBody = new System.Windows.Forms.Label();
            this.cbo_ToUser = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PATIENT_ID
            // 
            this.lbl_PATIENT_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_PATIENT_ID.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_PATIENT_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_PATIENT_ID.Location = new System.Drawing.Point(12, 24);
            this.lbl_PATIENT_ID.Name = "lbl_PATIENT_ID";
            this.lbl_PATIENT_ID.Size = new System.Drawing.Size(104, 19);
            this.lbl_PATIENT_ID.TabIndex = 0;
            this.lbl_PATIENT_ID.Text = "Patient_id";
            // 
            // txt_PATIENT_ID
            // 
            this.txt_PATIENT_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_PATIENT_ID.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_PATIENT_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_PATIENT_ID.Location = new System.Drawing.Point(122, 21);
            this.txt_PATIENT_ID.Name = "txt_PATIENT_ID";
            this.txt_PATIENT_ID.Size = new System.Drawing.Size(243, 27);
            this.txt_PATIENT_ID.TabIndex = 1;
            this.txt_PATIENT_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PATIENT_ID_KeyPress);
            // 
            // lbl_ToUser
            // 
            this.lbl_ToUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_ToUser.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_ToUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_ToUser.Location = new System.Drawing.Point(12, 120);
            this.lbl_ToUser.Name = "lbl_ToUser";
            this.lbl_ToUser.Size = new System.Drawing.Size(104, 19);
            this.lbl_ToUser.TabIndex = 2;
            this.lbl_ToUser.Text = "To user";
            // 
            // lbl_FromUser
            // 
            this.lbl_FromUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_FromUser.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_FromUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_FromUser.Location = new System.Drawing.Point(12, 77);
            this.lbl_FromUser.Name = "lbl_FromUser";
            this.lbl_FromUser.Size = new System.Drawing.Size(104, 19);
            this.lbl_FromUser.TabIndex = 4;
            this.lbl_FromUser.Text = "From user";
            // 
            // txt_FromUser
            // 
            this.txt_FromUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_FromUser.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_FromUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_FromUser.Location = new System.Drawing.Point(122, 77);
            this.txt_FromUser.Name = "txt_FromUser";
            this.txt_FromUser.Size = new System.Drawing.Size(243, 27);
            this.txt_FromUser.TabIndex = 5;
            this.txt_FromUser.TextChanged += new System.EventHandler(this.txt_FromUser_TextChanged);
            this.txt_FromUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PATIENT_ID_KeyPress);
            // 
            // lbl_MessageDate
            // 
            this.lbl_MessageDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_MessageDate.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_MessageDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_MessageDate.Location = new System.Drawing.Point(12, 170);
            this.lbl_MessageDate.Name = "lbl_MessageDate";
            this.lbl_MessageDate.Size = new System.Drawing.Size(104, 19);
            this.lbl_MessageDate.TabIndex = 6;
            this.lbl_MessageDate.Text = "Message date";
            // 
            // lbl_MessageBody
            // 
            this.lbl_MessageBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_MessageBody.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_MessageBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_MessageBody.Location = new System.Drawing.Point(12, 218);
            this.lbl_MessageBody.Name = "lbl_MessageBody";
            this.lbl_MessageBody.Size = new System.Drawing.Size(107, 19);
            this.lbl_MessageBody.TabIndex = 8;
            this.lbl_MessageBody.Text = "Message body";
            // 
            // txt_MessageBody
            // 
            this.txt_MessageBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_MessageBody.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_MessageBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_MessageBody.Location = new System.Drawing.Point(125, 209);
            this.txt_MessageBody.Multiline = true;
            this.txt_MessageBody.Name = "txt_MessageBody";
            this.txt_MessageBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_MessageBody.Size = new System.Drawing.Size(240, 136);
            this.txt_MessageBody.TabIndex = 9;
            // 
            // dtp_MessageDate
            // 
            this.dtp_MessageDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtp_MessageDate.CalendarMonthBackground = System.Drawing.Color.Cyan;
            this.dtp_MessageDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtp_MessageDate.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dtp_MessageDate.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dtp_MessageDate.Location = new System.Drawing.Point(122, 175);
            this.dtp_MessageDate.Name = "dtp_MessageDate";
            this.dtp_MessageDate.Size = new System.Drawing.Size(243, 27);
            this.dtp_MessageDate.TabIndex = 10;
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Send.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Send.Location = new System.Drawing.Point(454, 18);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(86, 23);
            this.btn_Send.TabIndex = 11;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Get_Message
            // 
            this.btn_Get_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Get_Message.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Get_Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Get_Message.Location = new System.Drawing.Point(454, 65);
            this.btn_Get_Message.Name = "btn_Get_Message";
            this.btn_Get_Message.Size = new System.Drawing.Size(86, 23);
            this.btn_Get_Message.TabIndex = 12;
            this.btn_Get_Message.Text = "Get Message";
            this.btn_Get_Message.UseVisualStyleBackColor = false;
            this.btn_Get_Message.Click += new System.EventHandler(this.btn_Get_Message_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_New.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_New.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_New.Location = new System.Drawing.Point(454, 112);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(86, 23);
            this.btn_New.TabIndex = 13;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // lbl_err_PATIENT_ID
            // 
            this.lbl_err_PATIENT_ID.AutoSize = true;
            this.lbl_err_PATIENT_ID.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_err_PATIENT_ID.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_PATIENT_ID.Location = new System.Drawing.Point(371, 23);
            this.lbl_err_PATIENT_ID.Name = "lbl_err_PATIENT_ID";
            this.lbl_err_PATIENT_ID.Size = new System.Drawing.Size(0, 19);
            this.lbl_err_PATIENT_ID.TabIndex = 14;
            // 
            // lbl_err_ToUser
            // 
            this.lbl_err_ToUser.AutoSize = true;
            this.lbl_err_ToUser.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_err_ToUser.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_ToUser.Location = new System.Drawing.Point(371, 124);
            this.lbl_err_ToUser.Name = "lbl_err_ToUser";
            this.lbl_err_ToUser.Size = new System.Drawing.Size(0, 19);
            this.lbl_err_ToUser.TabIndex = 15;
            // 
            // lbl_err_FromUser
            // 
            this.lbl_err_FromUser.AutoSize = true;
            this.lbl_err_FromUser.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_err_FromUser.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_FromUser.Location = new System.Drawing.Point(371, 77);
            this.lbl_err_FromUser.Name = "lbl_err_FromUser";
            this.lbl_err_FromUser.Size = new System.Drawing.Size(0, 19);
            this.lbl_err_FromUser.TabIndex = 16;
            // 
            // lbl_err_MessageBody
            // 
            this.lbl_err_MessageBody.AutoSize = true;
            this.lbl_err_MessageBody.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_err_MessageBody.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_MessageBody.Location = new System.Drawing.Point(371, 218);
            this.lbl_err_MessageBody.Name = "lbl_err_MessageBody";
            this.lbl_err_MessageBody.Size = new System.Drawing.Size(0, 19);
            this.lbl_err_MessageBody.TabIndex = 17;
            // 
            // cbo_ToUser
            // 
            this.cbo_ToUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbo_ToUser.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbo_ToUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbo_ToUser.FormattingEnabled = true;
            this.cbo_ToUser.Location = new System.Drawing.Point(122, 117);
            this.cbo_ToUser.Name = "cbo_ToUser";
            this.cbo_ToUser.Size = new System.Drawing.Size(243, 27);
            this.cbo_ToUser.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(565, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(333, 269);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // MessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(910, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbo_ToUser);
            this.Controls.Add(this.lbl_err_MessageBody);
            this.Controls.Add(this.lbl_err_FromUser);
            this.Controls.Add(this.lbl_err_ToUser);
            this.Controls.Add(this.lbl_err_PATIENT_ID);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Get_Message);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.dtp_MessageDate);
            this.Controls.Add(this.txt_MessageBody);
            this.Controls.Add(this.lbl_MessageBody);
            this.Controls.Add(this.lbl_MessageDate);
            this.Controls.Add(this.txt_FromUser);
            this.Controls.Add(this.lbl_FromUser);
            this.Controls.Add(this.lbl_ToUser);
            this.Controls.Add(this.txt_PATIENT_ID);
            this.Controls.Add(this.lbl_PATIENT_ID);
            this.Name = "MessageView";
            this.Text = "MessageView";
            this.Load += new System.EventHandler(this.MessageView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PATIENT_ID;
        private System.Windows.Forms.TextBox txt_PATIENT_ID;
        private System.Windows.Forms.Label lbl_ToUser;
        private System.Windows.Forms.Label lbl_FromUser;
        private System.Windows.Forms.TextBox txt_FromUser;
        private System.Windows.Forms.Label lbl_MessageDate;
        private System.Windows.Forms.Label lbl_MessageBody;
        private System.Windows.Forms.TextBox txt_MessageBody;
        private System.Windows.Forms.DateTimePicker dtp_MessageDate;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Get_Message;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Label lbl_err_PATIENT_ID;
        private System.Windows.Forms.Label lbl_err_ToUser;
        private System.Windows.Forms.Label lbl_err_FromUser;
        private System.Windows.Forms.Label lbl_err_MessageBody;
        private System.Windows.Forms.ComboBox cbo_ToUser;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}