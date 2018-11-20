using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMSYS
{
    class PatientView
    {
        

        public PatientView(String id ){ 
        this.patiant_id=id;
        }
        
        
        
        
        String user_id = null;
    String patiant_id, email; String FirstName = null, FamilyName = null, Mobile = null;
private   System.Windows.Forms.TextBox txt_id;
        public PatientView(String ID, String FIRST_NAME, String FATHER_NAME, String MOBILE, String EMAIL, String USER_ID)
        {
           patiant_id = ID;
           this.FirstName = FIRST_NAME;
           this.FamilyName = FATHER_NAME;
           this.Mobile = MOBILE;
           this.email = EMAIL;
           this.user_id = USER_ID;
       
       }

 
         public String getUser_id()
        {
            return user_id;
        }
         public String getFamilyName()
        {
            return FamilyName;
        }

        public String getMobile()
        {
            return Mobile;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setPatientID(String patiant_id)
        {
            this.patiant_id = patiant_id;
        }

        public String getEmail()
        {
            return this.email;
        }
        public void setMobile(String Mobile)
        {
            this.Mobile = Mobile;
        }
       
        public String getPatientID()
        {
            return this.patiant_id;
        }
        public void setFirstName(String FirstName)
        {
            this.FirstName = FirstName;
        }

        public void setFamilyName(String FamilyName)
        {
            this.FamilyName = FamilyName;
        }
        public String getFirstName()
        {
            return FirstName;
        }
         

    }
}
