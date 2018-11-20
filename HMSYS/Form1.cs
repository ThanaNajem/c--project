using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMSYS
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            lbl_Incorrect_Login.Text = "";
            String user_id = txt_ID.Text.Trim();
            String user_password = txt_Password.Text.Trim();
            bool is_id_Valid = UserUtil.ValidateString(user_id, lbl_err_ID);

            bool is_pass_Valid = UserUtil.ValidateString(user_password, lbl_err_password);
            if (is_id_Valid && is_pass_Valid)
            {
                UserUtil user = new UserUtil(user_id, user_password);
                UserUtil user_1 = DBUtil.login(user);
                if (user_1 == null)
                    lbl_Incorrect_Login.Text = "Incorrect user name or password";
                else if (user_1 != null && user_1.getUser_type().Equals("1"))
                {
                    Home home = new Home(user);
                    home.Show();
                    txt_ID.Text = "";
                    txt_Password.Text = "";
                    /*Admin admin = new Admin(user_1, this);
                    admin.Show();
                    
                    this.ActiveControl = txt_id;
                    */
                    this.Hide();
                }

                else if (user_1 != null && user_1.getUser_type().Equals("2"))
                {
                    Home home = new Home(user);
                    home.Show();
                    txt_ID.Text = "";
                    txt_Password.Text = "";
                    /*Admin admin = new Admin(user_1, this);
                    admin.Show();
                    
                    this.ActiveControl = txt_id;
                    */
                    this.Hide();
                }
                else if (user_1 != null && user_1.getUser_type().Equals("3"))
                {
                    Home home = new Home(user);
                    home.Show();
                    txt_ID.Text = "";
                    txt_Password.Text = "";
                    /*Admin admin = new Admin(user_1, this);
                    admin.Show();
                    
                    this.ActiveControl = txt_id;
                    */
                    this.Hide();
                }
                else if (user_1 != null && user_1.getUser_type().Equals("4"))
                {
                    Home home = new Home(user);
                    home.Show();
                    txt_ID.Text = "";
                    txt_Password.Text = "";
                    /*Admin admin = new Admin(user_1, this);
                    admin.Show();
                    
                    this.ActiveControl = txt_id;
                    */
                    this.Hide();
                }


            } 
            
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }

        private void lbl_err_ID_Click(object sender, EventArgs e)
        {

        }

        private void lbl_err_userName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Incorrect_Login_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ID_Click(object sender, EventArgs e)
        {

        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
           
        }
      
        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_login_Click(null, null);
            }
        }

      

        
    }
}
