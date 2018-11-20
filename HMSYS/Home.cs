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
    public partial class Home : Form
    {
        UserUtil user;
        public Home(UserUtil user)
        {
            this.user = user;
            InitializeComponent();
            UserUtil userWithType = DBUtil.getUserTypeById(user);
            getUserLevel(userWithType);

        }
      /*  public Home( UserUtil user) 
        {
            InitializeComponent();
       UserUtil userWithType=    DBUtil.getUserTypeById(user);
        getUserLevel(userWithType);

        }*/


        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersView userView = new UsersView(user);
           
            userView.Show();
          //  this.Hide();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Login form = new frm_Login();
            form.Show();
            this.Hide();
        }

        private void patientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //isGet = true;
            PatientInfoView PatientInfoView = new PatientInfoView(user);
             
            PatientInfoView.Show();

           // this.Hide();
        }

        private void patientInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // isGet = true;
            PatientInfoView PatientInfoView = new PatientInfoView(user);

            PatientInfoView.Show();
            //this.Hide();
        
        }
       
        private void patientInfoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
          //  isGet = true;
            PatientInfoView PatientInfoView = new PatientInfoView(user);

            PatientInfoView.Show();
           // this.Hide();
        }
        public void getUserLevel(UserUtil userWithType)
        {
            int userType = Convert.ToInt32(userWithType.getUser_type());
            switch (userType)
            {
                case 1:
                    mDoctor.Enabled = false;
                    mReciptionist.Enabled = false;
                    Mnurse.Enabled = false;
                    ; break;
                case 2:
                    mReciptionist.Enabled = false;
                    Mnurse.Enabled = false;
                    mAdmin.Enabled = false;
                    ; break;
                case 3:
                    mReciptionist.Enabled = false;
                    mDoctor.Enabled = false;
                    mAdmin.Enabled = false;
                    ; break;
                case 4:
                    Mnurse.Enabled = false;
                    mDoctor.Enabled = false;
                    mAdmin.Enabled = false;
                    ; break;


            }
        }
        public static String UserType;
        private void mAdmin_Click(object sender, EventArgs e)
        {
            UserType=mAdmin.Text;
           
           
        }

        private void mDoctor_Click(object sender, EventArgs e)
        {
            UserType = mDoctor.Text;
        }

        private void mReciptionist_Click(object sender, EventArgs e)
        {
            UserType = mReciptionist.Text;
        }

        private void Mnurse_Click(object sender, EventArgs e)
        {
            UserType = Mnurse.Text;
        }

        private void getMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isGet = true;
            MessageView messageView = new MessageView(user);
            messageView.Show();
           
        }
       public static bool isGet;
        private void sendAMessageToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            isGet = false;
            MessageView messageView = new MessageView(user, isGet);
            messageView.Show();
           
        }

        private void sendAMessageToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            isGet = false;
            MessageView messageView = new MessageView(user, isGet);
            messageView.Show();
         
        }

        private void sendAMessageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isGet = false;
            MessageView messageView = new MessageView(user, isGet);
            messageView.Show();
        }

        private void sendAMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isGet = false;
            MessageView messageView = new MessageView(user, isGet);
            messageView.Show();
        }

        private void getAMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isGet = true;
            MessageView messageView = new MessageView(user);
            messageView.Show();
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isGet = true;
            MessageView messageView = new MessageView(user);
            messageView.Show();
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            isGet = true;
            MessageView messageView = new MessageView(user);
            messageView.Show();
           
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PatientInfoView PatientInfoView = new PatientInfoView(user);

            PatientInfoView.Show();
        } 

         
    }
}
