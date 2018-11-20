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
    public partial class MessageView : Form
    {
        UserUtil user;
        String userType;
        bool isGet;
        public MessageView(UserUtil user)
        {
            InitializeComponent();
            isGet = true;
            dataGridView1.Visible = true;
            btn_Send.Enabled = false;
            cbo_ToUser.SelectedIndex = -1;
            userType = Home.UserType;
           // MessageBox.Show(userType);
            if (userType.Equals("admin"))
            {
                user_Type = 1;

            }
            else if (userType.Equals("doctor"))
            {
                user_Type = 2;
            }
            else if (userType.Equals("reciption"))
            {

                user_Type = 4;
            }
            else if (userType.Equals("nurse"))
            {

                user_Type = 3;
            }
           // txt_FromUser.Text = userType.ToString();
            txt_FromUser.Enabled = true;
            this.user = user;
           // txt_FromUser.Enabled = false;
        }
        public MessageView(UserUtil user,bool isGet)
        {
            InitializeComponent();
            //حطي هنا نتيجة الداتاجرد فيو لكل البيشنت اي ديو بعدها بوخذ بيشنت معين و بحطه في التيكست
            this.isGet = false;
            //dataGridView1.Visible = false;

            btn_Send.Enabled = true;
            btn_Get_Message.Enabled = false;
            cbo_ToUser.SelectedIndex = -1;
            userType = Home.UserType;
            if (userType.Equals("admin"))
            {
                user_Type = 1;

            }
            else if (userType.Equals("doctor"))
            {
                user_Type = 2;
            }
            else if (userType.Equals("reciption"))
            {

                user_Type = 4;
            }
            else if (userType.Equals("nurse"))
            {

                user_Type = 3;
            }
             txt_FromUser.Text = userType.ToString();
             txt_FromUser.Enabled = false;

            this.user = user;

            //
           DataTable dt_allpatient =DBUtil.GetAllPatiantInfoView();
           dataGridView1.DataSource = dt_allpatient;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtp_MessageDate.Value.Date+"");
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            isSendOrGetMessage = btn_Send.Text;
            bool isPatient_idValid = UserUtil.ValidateString(txt_PATIENT_ID.Text, lbl_err_PATIENT_ID);
         //bool isToUserValid = UserUtil.ValidateString(txt_ToUser.Text, lbl_err_ToUser);
            bool isFromUserValid = UserUtil.ValidateString(txt_FromUser.Text, lbl_err_FromUser);
            bool isMessageBodyValid = UserUtil.ValidateString(txt_MessageBody.Text, lbl_err_MessageBody);
            if (isPatient_idValid 
             //عدلي هنا   && isToUserValid
                
                && isFromUserValid && isMessageBodyValid)
            {


                if (txt_FromUser.Text.Equals("nurse")) { user_Type = 3; }
                else if (txt_FromUser.Text.Equals("admin")) { user_Type = 1; }
                else if (txt_FromUser.Text.Equals("doctor")) { user_Type = 2; }
                else if (txt_FromUser.Text.Equals("reciption")) { user_Type = 4; }
               
              
                Message message = new Message(txt_MessageBody.Text, new UserUtil(user_Type), new UserUtil(Convert.ToInt32 (cbo_ToUser.SelectedValue.ToString())), new PatientView(txt_PATIENT_ID.Text)/*, dtp_MessageDate.Value*/);
                
                bool isMessageInfoInserted = DBUtil.insertMessageInfo(message);
                if (isMessageInfoInserted)
                {
                    MessageBox.Show("MessageInfo is Sended sucessfully");

                    DataTable dt = new DataTable();
                    if (userType.Equals("admin"))
                    {
                        user_Type = 1;
                        dt = DBUtil.GetAllPatiantInfoView();

                    }
                    else if (userType.Equals("doctor"))
                    {
                        user_Type = 2;
                        dt = DBUtil.GetAllPatiantInfoView();
                    }
                    else if (userType.Equals("reciption"))
                    {

                        user_Type = 4;
                        dt = DBUtil.GetAllPatiantInfoView();
                    }
                    else if (userType.Equals("nurse"))
                    {

                        user_Type = 3;
                        dt = DBUtil.GetAllPatiantInfoView();
                    }




                    dataGridView1.DataSource = dt;
        
                    
                    
                    txt_MessageBody.Text = "";
                    txt_PATIENT_ID.Text = "";
                //عدلي هنا    txt_ToUser.Text = "";
      
                }
                else
                {
                    MessageBox.Show("MessageInfo isn't Sended sucessfully");

                }
            }
            else
            {MessageBox.Show("please full required inf");
            
            txt_MessageBody.Text = "";
            
            
            lbl_err_ToUser.Text = "";
            lbl_MessageBody.Text = "";
            } 
        }
        String isSendOrGetMessage;
        private void btn_New_Click(object sender, EventArgs e)
        {
            //if (isSendOrGetMessage.Equals(btn_Send.Text))
            //{
                txt_MessageBody.Text = "";
                txt_PATIENT_ID.Text = "";
                
                lbl_err_PATIENT_ID.Text = "";
                lbl_err_MessageBody.Text = "";
                lbl_err_ToUser.Text = "";
           // }

            
        }
      
        /*
         DataSet ds2;

private void searchBtn_Click(object sender, EventArgs e)
{
SqlConnection conn = new SqlConnection();
conn.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
conn.Open();

SqlDataAdapter daSearch = new SqlDataAdapter("SELECT cName FROM ComDet", conn);
ds2 = new DataSet();
daSearch.Fill(ds2, "daSearch");
ListU.ValueMember = "cName";
ListU.DataSource = ds2.Tables["daSearch"];
ListU.DropDownStyle = ComboBoxStyle.DropDownList;
ListU.Enabled = true;
} 
         */







 int user_Type;
        private void btn_Get_Message_Click(object sender, EventArgs e)
        {//هنا رح اعدل انه يستقبل المريض الواحد ن اكثر من يوزر تايب من خلال كمبوبوكس
            isSendOrGetMessage = btn_Get_Message.Text;
            bool isPatient_idValid = UserUtil.ValidateString(txt_PATIENT_ID.Text,lbl_err_PATIENT_ID);
            /* bool isToUserValid = UserUtil.ValidateString(txt_ToUser.Text, lbl_err_ToUser);
            bool isFromUserValid = UserUtil.ValidateString(txt_FromUser.Text,lbl_err_FromUser);
            bool isMessageBodyValid = UserUtil.ValidateString(txt_MessageBody.Text,lbl_err_MessageBody);
            */
            if (isPatient_idValid)
            {
                
                UserUtil user = new UserUtil(Convert.ToInt32(txt_PATIENT_ID.Text), user_Type,(cbo_ToUser.SelectedIndex+2));

             bool isPATIENT_IDValid=DBUtil.isPatientValid(new PatientView(txt_PATIENT_ID.Text));
             if (isPATIENT_IDValid)
             {
                
              Message  getMessageInfo = DBUtil.getMessageInfo(user);
                 if (getMessageInfo != null)
                 {
                     
                     txt_MessageBody.Text = getMessageInfo.getMESSAGE_BODY().ToString();

                     /*
                       List<KeyValuePair<int,string>> orgList = new List<KeyValuePair<int,string>>();
                       orgList.Add(new KeyValuePair<int,string>(1,"admin"));
                       orgList.Add(new KeyValuePair<int,string>(2,"doctor"));
                       orgList.Add(new KeyValuePair<int,string>(3,"nurse"));
                       orgList.Add(new KeyValuePair<int,string>(4,"reciption"));
                       cbo_ToUser.DisplayMember="Value";
                       cbo_ToUser.ValueMember = "key";
                        List<KeyValuePair<int,string>> editList = new List<KeyValuePair<int,string>>();
                       editList.RemoveAt(user_Type-1);
                       cbo_ToUser.DataSource = new BindingSource(editList, null);
                     */
                     //عدلي هنا txt_ToUser.Text = getMessageInfo.getTO_USER().getUser_type();
                     // MessageBox.Show(txt_ToUser.Text);
                     // dtp_MessageDate.Text = getMessageInfo.getMESSAGE_DATE().ToString();

                     //    MessageBox.Show( cbo_ToUser.SelectedValue.ToString());
                    // txt_MessageBody.Text = "";
                    /* for (int i = 0; i < getMessageInfo.Count;i++ )
                     {
                         String noOfMessage = "message no. "+(i+1)+" ";
                         txt_MessageBody.Text +=noOfMessage+": "+ getMessageInfo[i].getMESSAGE_BODY() + System.Environment.NewLine;

                     }*/
                    
                 }
                 else
                 {
                     MessageBox.Show("There is no message btn them");

                 }
             }
             //   DBUtil.getAllInfoMessage();
             else {
                 MessageBox.Show("This user isn't valid");
             }


            }
            else {
                MessageBox.Show("please enter valid id");
            }


        }

        private void txt_PATIENT_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
            
        }

        private void txt_FromUser_TextChanged(object sender, EventArgs e)
        {
             cbo_ToUser.Enabled = (txt_PATIENT_ID.Text == "");
            if (cbo_ToUser.Enabled)
             {
                List<KeyValuePair<int, string>> orgList = new List<KeyValuePair<int, string>>();
                orgList.Add(new KeyValuePair<int, string>(1, "admin"));
                orgList.Add(new KeyValuePair<int, string>(2, "doctor"));
                orgList.Add(new KeyValuePair<int, string>(3, "nurse"));
                orgList.Add(new KeyValuePair<int, string>(4, "reciption"));
                cbo_ToUser.DisplayMember = "Value";
                cbo_ToUser.ValueMember = "key";
                List<KeyValuePair<int, string>> editList = new List<KeyValuePair<int, string>>(orgList);
                editList.RemoveAt(user_Type - 1);
                cbo_ToUser.DataSource = new BindingSource(editList, null);
                 
            }      
            
        }

        private void MessageView_Load(object sender, EventArgs e)
        { 


             DataTable dt=new DataTable();
           if(isGet) {
                  if (userType.Equals("admin"))
            {
                user_Type = 1;
                dt = DBUtil.GetAllMessagesForThisUser(user_Type);

            }
            else if (userType.Equals("doctor"))
            {
                user_Type = 2;
                  dt = DBUtil.GetAllMessagesForThisUser(user_Type);
            }
            else if (userType.Equals("reciption"))
            {

                user_Type = 4;
                  dt = DBUtil.GetAllMessagesForThisUser(user_Type);
            }
            else if (userType.Equals("nurse"))
            {

                user_Type = 3;
                  dt = DBUtil.GetAllMessagesForThisUser(user_Type);
            }
                


             
            dataGridView1.DataSource = dt;}

           else if (!isGet){
               dt = DBUtil.GetAllPatiantInfoView();
               dataGridView1.DataSource = dt;
           }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_err_FromUser.Text = "";
            lbl_err_MessageBody.Text = "";
            lbl_err_PATIENT_ID.Text = "";
            lbl_err_ToUser.Text = "";
            
            if(isGet){
            cbo_ToUser.Enabled = false;
            
           // id_selected_lbl.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_MessageBody.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        
           string fromuserint  = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
          
           if (fromuserint.Equals("1"))
           {
               
               txt_FromUser.Text = "admin";
               
           }
           else if (fromuserint.Equals("2"))
           {
               
               txt_FromUser.Text = "doctor";
               
           }
           else if (fromuserint.Equals("4"))
           {

               txt_FromUser.Text = "reciption";
              
           }
           else if (fromuserint.Equals("3"))
           {
               
               txt_FromUser.Text = "nurse";
              
           }

           List<KeyValuePair<int, string>> orgList = new List<KeyValuePair<int, string>>();
           orgList.Add(new KeyValuePair<int, string>(1, "admin"));
           orgList.Add(new KeyValuePair<int, string>(2, "doctor"));
           orgList.Add(new KeyValuePair<int, string>(3, "nurse"));
           orgList.Add(new KeyValuePair<int, string>(4, "reciption"));
           cbo_ToUser.DisplayMember = "Value";
           cbo_ToUser.ValueMember = "key";
           List<KeyValuePair<int, string>> editList = new List<KeyValuePair<int, string>>(orgList);
           editList.RemoveAt(Convert.ToInt32( fromuserint)- 1);
         cbo_ToUser.DataSource = new BindingSource(editList, null);
          // cbo_ToUser.SelectedItem = userType;
            int cbo_ToUser_int_value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()) - 1;
         
            txt_PATIENT_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
    
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("1"))
         {
             cbo_ToUser.SelectedIndex = cbo_ToUser.FindStringExact("admin");
             //cbo_ToUser.Text= "admin";

         }
            else if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("2"))
         {
             cbo_ToUser.SelectedIndex = cbo_ToUser.FindStringExact("doctor");
            // cbo_ToUser.Text = "doctor";

         }
            else if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("4"))
         {
             cbo_ToUser.SelectedIndex = cbo_ToUser.FindStringExact("reciption");

            // cbo_ToUser.Text = "reciption";

         }
            else if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("3"))
         {
             cbo_ToUser.SelectedIndex = cbo_ToUser.FindStringExact("nurse");

            // cbo_ToUser.Text = "nurse";

         }
       
          // cbo_ToUser.SelectedItem = userType; //= Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString())-1;
           
           
           // cbo_ToUser.Enabled = true;
        }
        else {//in send side
    cbo_ToUser.Enabled = true;
    txt_FromUser.Text= userType;
    txt_PATIENT_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

    txt_FromUser.Enabled = false;
                
    if (user_Type==1)
    {

        txt_FromUser.Text = "admin";

    }
    else if (user_Type == 2)
    {

        txt_FromUser.Text = "doctor";

    }
    else if (user_Type == 4)
    {

        txt_FromUser.Text = "reciption";

    }
    else if (user_Type ==3)
    {

        txt_FromUser.Text = "nurse";

    }
    List<KeyValuePair<int, string>> orgList = new List<KeyValuePair<int, string>>();
    orgList.Add(new KeyValuePair<int, string>(1, "admin"));
    orgList.Add(new KeyValuePair<int, string>(2, "doctor"));
    orgList.Add(new KeyValuePair<int, string>(3, "nurse"));
    orgList.Add(new KeyValuePair<int, string>(4, "reciption"));
    cbo_ToUser.DisplayMember = "Value";
    cbo_ToUser.ValueMember = "key";
    List<KeyValuePair<int, string>> editList = new List<KeyValuePair<int, string>>(orgList);
    editList.RemoveAt(user_Type - 1);
    cbo_ToUser.DataSource = new BindingSource(editList, null);

    
    
            
            }
           
        }

        

        
    }
}
