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
    public partial class PatientInfoView : Form
    {
        UserUtil user;
        public PatientInfoView(UserUtil user)
        {  InitializeComponent();
            this.user = user;
          
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool isValidFormatId = UserUtil.ValidateString(txt_id.Text, lbl_err_id);
            bool isValidFormatFirstName = UserUtil.ValidateString(txt_firstName.Text, lbl_err_firstName);
            bool isValidFormatFatherName = UserUtil.ValidateString( txt_fatherName.Text, lbl_err_fatherName);
            bool isValidFormatMobile = UserUtil.ValidateString(txt_mobile.Text, lbl_err_mobile);
            bool isValidFormatEmail = UserUtil.ValidateString(txt_email.Text, lbl_err_email)&&(txt_email.Text.Contains("@"));
            bool isValidFormatUserId = UserUtil.ValidateString(txt_userID.Text, lbl_err_userID);
            
            if(isValidFormatId){
                //بعد هذه الخطوة لازم اتأكد انه البيشنت اي دي موجود و الا لا 
               bool isUserValid= DBUtil.IsUserValid(new UserUtil(txt_userID.Text));
               bool isPatientValid = DBUtil.isPatientValid(new PatientView(txt_id.Text));
               if (isUserValid) {

                   if(!isPatientValid){
                       if (isValidFormatFirstName && isValidFormatFatherName && isValidFormatMobile && isValidFormatEmail && isValidFormatUserId)
                       {
                           String user_id = txt_id.Text;
                           String FirstName = txt_firstName.Text;
                           String FamilyName = txt_fatherName.Text;
                           String Mobile = txt_mobile.Text;
                           String email = txt_email.Text;
                           String userID = txt_userID.Text;
                           PatientView patientUser = new PatientView(user_id, FirstName, FamilyName, Mobile, email, userID);

                           bool isPatientAdded = DBUtil.addPatient(patientUser);
                           if (isPatientAdded)
                           {
                               txt_id.Text = "";
                               txt_firstName.Text = "";
                               txt_fatherName.Text = "";
                               txt_mobile.Text = "";
                               txt_email.Text = "";
                               txt_userID.Text = "";
                               lbl_err_email.Text = "";
                               lbl_err_id.Text = "";
                               lbl_err_userID.Text = "";
                               lbl_err_mobile.Text = "";
                               lbl_err_fatherName.Text = "";
                               lbl_err_firstName.Text = "";
                               MessageBox.Show("This patient info is successfully added");
                               DBUtil.GetAllPatiantInfoView();
                               txt_id.Text = "";
                               txt_firstName.Text = "";
                               txt_fatherName.Text = "";
                               txt_mobile.Text = "";
                               txt_email.Text = "";
                               txt_userID.Text = "";
                               
                           }
                           else
                           {
                               MessageBox.Show("This patient info isn't successfully added");

                           }
                       }
                      
                   
                   }
                   else if (isPatientValid){
                       MessageBox.Show("This patient valid");
                   }
              

               } else {
                MessageBox.Show("This userID is invalid change it , and try again");
               }
           
            }
            else{
                MessageBox.Show("Invalid id");
            
            }

        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
             
        }

        private void txt_userID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
            
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
             
        }

       /* private void PatientInfoView_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Home home = new Home(user);
            home.Show();
            this.Hide();
        }
        */
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool isIdValid=UserUtil.ValidateString(txt_id.Text,lbl_err_id);
            if (isIdValid)
            {
            bool isPatientValid=DBUtil.isPatientValid(new PatientView(txt_id.Text));
            if (isPatientValid)
            {
                bool isPatientDeleted = DBUtil.deletePatientFromTblPatientr(new PatientView(txt_id.Text));
                if (isPatientDeleted)
                {
                    txt_id.Text = "";
                    txt_firstName.Text = "";
                    txt_fatherName.Text = "";
                    txt_mobile.Text = "";
                    txt_email.Text = "";
                    txt_userID.Text = "";

                    MessageBox.Show("This patient is successfully deleted");
                    DBUtil.GetAllPatiantInfoView();
                }
                else
                {


                    MessageBox.Show("This patient isn't successfully deleted");

                }
            }
            else {

                MessageBox.Show("This patient Not valid In DB");
            }
            }
            else {

                MessageBox.Show("This Patient is invalid");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {bool isValidFormatId = UserUtil.ValidateString(txt_id.Text, lbl_err_id);
            bool isValidFormatFirstName = UserUtil.ValidateString(txt_firstName.Text, lbl_err_firstName);
            bool isValidFormatFatherName = UserUtil.ValidateString( txt_fatherName.Text, lbl_err_fatherName);
            bool isValidFormatMobile = UserUtil.ValidateString(txt_mobile.Text, lbl_err_mobile);
            bool isValidFormatEmail = UserUtil.ValidateString(txt_email.Text, lbl_err_email)&&(txt_email.Text.Contains("@"));
            bool isValidFormatUserId = UserUtil.ValidateString(txt_userID.Text, lbl_err_userID);

            if (isValidFormatId)
            {
                //بعد هذه الخطوة لازم اتأكد انه البيشنت اي دي موجود و الا لا 
                bool isUserValid = DBUtil.IsUserValid(new UserUtil(txt_userID.Text));
                bool isPatientValid = DBUtil.isPatientValid(new PatientView(txt_id.Text));
                if (isUserValid)
                {
                    String patient_id = txt_id.Text;
                    String FirstName = txt_firstName.Text;
                    String FamilyName = txt_fatherName.Text;
                    String Mobile = txt_mobile.Text;
                    String email = txt_email.Text;
                    String userID = txt_userID.Text;
                    PatientView patientUser = new PatientView(patient_id, FirstName, FamilyName, Mobile, email, userID);

                    bool isPatientUpdated = DBUtil.UpdatePatientInfo(patientUser);
                    if (isPatientUpdated)
                    {
                        txt_id.Text = "";
                        txt_firstName.Text = "";
                        txt_fatherName.Text = "";
                        txt_mobile.Text = "";
                        txt_email.Text = "";
                        txt_userID.Text = "";
                        MessageBox.Show("This patient info is successfully Updated");
                        DBUtil.GetAllPatiantInfoView();

                    }
                    else
                    {
                        MessageBox.Show("This patient info isn't successfully Updated");

                    }
                }
                else { MessageBox.Show("This user_id isn't valid"); }
            }
            else {
                MessageBox.Show("This patient has Invalid id");
            
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            bool isValidFormatId = UserUtil.ValidateString(txt_id.Text, lbl_err_id);

            if (isValidFormatId)
            {
                PatientView patient = new PatientView(txt_id.Text);
                bool isPatientValid = DBUtil.isPatientValid(patient);
                if (isPatientValid)
                {
                    PatientView patientInfo = DBUtil.getAllInfoPatient(patient);
                    if (patientInfo != null)
                    {
                        txt_id.Text = patientInfo.getPatientID();
                        txt_firstName.Text = patientInfo.getFirstName();
                        txt_fatherName.Text = patientInfo.getFamilyName();
                        txt_mobile.Text = patientInfo.getMobile();
                        txt_email.Text = patientInfo.getEmail();
                        txt_userID.Text = patientInfo.getUser_id();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid user");
                }
            }
            else {

                MessageBox.Show("please fill id");
            }
        }

        private void btn_GetMessage_Click(object sender, EventArgs e)
        {
            MessageView messageView = new MessageView(user);

            messageView.Show();
        }

        private void PatientInfoView_Load(object sender, EventArgs e)
        {
            DataTable dt = DBUtil.GetAllPatiantInfoView();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_firstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_fatherName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_mobile.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_userID.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void lbl_firstName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_fatherName_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_firstName.Text = "";
            txt_fatherName.Text = "";
            txt_mobile.Text = "";
            txt_email.Text = "";
            txt_userID.Text = "";
            lbl_err_email.Text = "";
            lbl_err_id.Text = "";
            lbl_err_userID.Text = "";
            lbl_err_mobile.Text = "";
            lbl_err_fatherName.Text = "";
            lbl_err_firstName.Text = "";
                               
        }

       

        

       

         

       
    }
}
