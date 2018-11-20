using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HMSYS
{
    public partial class UsersView : Form
    {
        UserUtil user;
        int LastIdInUserTbl, LastIdInUserDetailTbl;
        public UsersView(UserUtil user)
        {
            this.user = user;
           // int NoOfDeletedUser = DBUtil.getNoOfDeletedUser();
            InitializeComponent();
           cbo_userType.SelectedIndex =0;
            cbo_specialization.SelectedIndex = 0;
            int LastId = DBUtil.getLastIdInUserTbl();
            if (LastId != -1)
           // { txt_User_ID.Text = (LastId + NoOfDeletedUser + 1) + ""; }
              { txt_User_ID.Text = (LastId  + 1) + ""; }
            else if (LastId == -1)
            {
             //   txt_User_ID.Text = 1000+1+NoOfDeletedUser+"";
                txt_User_ID.Text ="1000";
            }
            LastIdInUserTbl = Convert.ToInt32(txt_User_ID.Text);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
       //   int NoOfDeletedUser=  DBUtil.getNoOfDeletedUser();
           
            //في الاسطر السفلية ما تجيب البيانات مثل ما أنت عامل في الأسطر السفلية انما روح اعمل تحقق لشرط الاز فالد
            
           
            int id = Convert.ToInt32(txt_User_ID.Text);
            String strId = id + "";
            String Username = txt_Username.Text;
            String Password = txt_Password.Text;
            String userType = (cbo_userType.SelectedIndex+1)+"";
            String FirstName = txt_FirstName.Text;
            String FamilyName = txt_FamilyName.Text;
            String Mobile = txt_Mobile.Text;
            String specialization = cbo_specialization.SelectedItem.ToString();
            bool isIdValid = UserUtil.ValidateString(strId, lbl_err_id);
            bool isUsernameValid = UserUtil.ValidateString(Username, lbl_err_userName);
            bool isPasswordValid = UserUtil.ValidateString(Password, lbl_err_password);
            bool isuserTypeValid = UserUtil.ValidateString(userType, lbl_err_userType);
            bool isFirstNameValid = UserUtil.ValidateString(FirstName, lbl_err_FirstName);
            bool isFamilyNameValid = UserUtil.ValidateString(FamilyName, lbl_err_FamilyName);
            bool isMobileValid = UserUtil.ValidateString(Mobile, lbl_err_Mobile);
            bool isSpecializationValid = UserUtil.ValidateString(specialization, lbl_specialization);
            if (isSpecializationValid&&isIdValid && isUsernameValid && isPasswordValid && isuserTypeValid && isFirstNameValid && isFamilyNameValid && isMobileValid)
            {
               //make user object for adding usre details
                UserUtil user = new UserUtil( strId, Username, Password, userType, FirstName, FamilyName, Mobile, specialization);
             
         if(!DBUtil.IsUserValid(new UserUtil(user.getUser_id()))){
                bool isUsersAdd=  DBUtil.addUsers(user);
              if (isUsersAdd)
              {
              
                  
                      MessageBox.Show("Add new user is Success");
                      txt_Username.Text = "";
                      txt_Password.Text = "";
                      txt_FirstName.Text = "";
                      txt_FamilyName.Text = "";
                      txt_Mobile.Text = "";
                      int LastId_1 = DBUtil.getLastIdInUserTbl();
                      if (LastId_1 != -1)
{ //txt_User_ID.Text = (LastId_1 + NoOfDeletedUser + 1) + "";

txt_User_ID.Text = (LastId_1 + 1) + "";
                      
                      }
                      else if (LastId_1 == -1)
                      {
                         // txt_User_ID.Text = 1000+NoOfDeletedUser+1+"";
                          txt_User_ID.Text = "1000";
                      }
                      LastIdInUserTbl = Convert.ToInt32(txt_User_ID.Text);
        
                  }
              else if (isUsersAdd)
              {


                  MessageBox.Show("Add new user is not Successfully");
              }
            }
         else if(DBUtil.IsUserValid(new UserUtil(user.getUser_id()))){
             MessageBox.Show("This id is Valid");
             txt_Username.Text = "";
             txt_Password.Text = "";
             txt_FirstName.Text = "";
             txt_FamilyName.Text = "";
             txt_Mobile.Text = "";
                      
         }
            }
        }

        private void UsersView_Load(object sender, EventArgs e)
        {
            txt_Username.Focus();
        }

        private void txt_Mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                btn_Add_Click(this, null);
            }
        
        }

      /*  private void UsersView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home home = new Home(user);
            home.Show();
            this.Hide();
        }*/
        int countOfDeletedUser = 0;
        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txt_User_ID.Text);
            bool isdeleteUserValid = DBUtil.IsUserValid(new UserUtil (id+""));
            UserUtil deletedUser;
            deletedUser = new UserUtil(id+"");
            if (isdeleteUserValid)
            {
               bool isUserDeleted= DBUtil.deleteUserFromTblUser(deletedUser);
               if (isUserDeleted) {
                   MessageBox.Show("User is successfully Deleted");
               }
                else{
                    MessageBox.Show("User isn't successfully Deleted");
               }
        }
            else if (!isdeleteUserValid)
            {
                MessageBox.Show("This id isnot valid");
            
            }
        }

        private void txt_User_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                btn_Add_Click(this, null);
            }
        
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {

            
            

            String strId = txt_User_ID.Text;
            String Username = txt_Username.Text;
            String Password = txt_Password.Text;
            String userType = (cbo_userType.SelectedIndex+1)+"";
            String FirstName = txt_FirstName.Text;
            String FamilyName = txt_FamilyName.Text;
            String Mobile = txt_Mobile.Text;
            String specailization = cbo_specialization.SelectedItem.ToString();
            bool isIdValid = UserUtil.ValidateString(strId, lbl_err_id);
            bool isUsernameValid = UserUtil.ValidateString(Username, lbl_err_userName);
            bool isPasswordValid = UserUtil.ValidateString(Password, lbl_err_password);
            bool isuserTypeValid = UserUtil.ValidateString(userType, lbl_err_userType);
            bool isFirstNameValid = UserUtil.ValidateString(FirstName, lbl_err_FirstName);
            bool isFamilyNameValid = UserUtil.ValidateString(FamilyName, lbl_err_FamilyName);
            bool isMobileValid = UserUtil.ValidateString(Mobile, lbl_err_Mobile);
            bool isSpecailizationValid = UserUtil.ValidateString(specailization,lbl_specialization);
            if (isIdValid && isUsernameValid && isPasswordValid && isuserTypeValid && isFirstNameValid && isFamilyNameValid && isMobileValid)
            {
                //make user object for adding usre details
                UserUtil user = new UserUtil(strId, Username, Password, userType, FirstName, FamilyName, Mobile, specailization);
              bool isUserValid=  DBUtil.IsUserValid(user);
                //   DBUtil.resetId("USERS",LastIdInUserTbl);
               // bool isUsersAdd = DBUtil.addUsers(user);
              if (isUserValid)
              {
                  MessageBox.Show("User Valid");
                    //   DBUtil.resetId("USERS_DETAILS", LastIdInUserDetailTbl);
                  bool isUserUpdate = DBUtil.UpdateUserInfo(user);
                    if (isUserUpdate)
                    {
                        //bool isUserDetailUpdate = DBUtil.UpdateUserDetail(user);
                      //  if (isUserDetailUpdate)
                        MessageBox.Show("User Update Successfully");
                        DBUtil.GetAllPatiantInfoView();
                        txt_Username.Text = "";
                        txt_Password.Text = "";
                        txt_FirstName.Text = "";
                        txt_FamilyName.Text = "";
                        txt_Mobile.Text = "";
                        
                    }
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
          bool isValidFormatId=  UserUtil.ValidateString(txt_User_ID.Text,lbl_err_id);

          if (isValidFormatId)
          {
              UserUtil user =new  UserUtil(txt_User_ID.Text);
          bool isUserValid=    DBUtil.IsUserValid(user);
          if (isUserValid)
          {
         UserUtil userInfo=     DBUtil.getAllInfoUser(user);
         if (userInfo != null)
         {
             txt_Username.Text = userInfo.getUser_name();
             txt_Password.Text = userInfo.getUser_pass();
             cbo_userType.SelectedIndex = Convert.ToInt32(userInfo.getUser_type()) - 1;
             txt_FirstName.Text = userInfo.getFirstName();
             txt_FamilyName.Text = userInfo.getFamilyName();
             txt_Mobile.Text = userInfo.getMobile();
             cbo_specialization.SelectedItem = userInfo.getSpecialization();

         }
        
           } else
         {
             MessageBox.Show("Invalid user");
         }  
          }
           
        }

        private void UsersView_Load_1(object sender, EventArgs e)
        {
            DataTable dt = DBUtil. GetAllUsersView();
            dataGridView1.DataSource=dt;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_err_id.Text="";
lbl_err_userName.Text="";
lbl_err_password.Text="";
lbl_err_userType.Text="";
lbl_err_FirstName.Text="";
lbl_err_FamilyName.Text="";
lbl_err_Mobile.Text="";
lbl_specialization.Text="";
            txt_User_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            txt_Username.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            txt_Password.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            cbo_userType.SelectedIndex = Convert .ToInt32 (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString())-1;
          
            txt_FirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            txt_FamilyName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            
            txt_Mobile.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            cbo_specialization.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_FirstName.Text = "";
            txt_FamilyName.Text = "";
            txt_Mobile.Text = "";
        }
    }
}
