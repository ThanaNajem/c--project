using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMSYS
{
  public  class UserUtil
    {
        String user_pass = null;
        String user_name = null;
        String user_type = "";int fromUser;
        String FirstName = null, FamilyName = null, Mobile = null;
        int toUser;
public UserUtil(int userType){
    this.user_type = userType+"";
    
    }

public UserUtil(int user_id, int fromUser, int toUser)
{
    this.user_id = user_id+"";
    this.fromUser = fromUser ;
   this.toUser = toUser;
    
}

String specialization;
        public UserUtil(String user_id, String Username, String Password, String userType, String FirstName, String FamilyName, String Mobile, String specialization)
        {this.specialization=specialization;
 this.user_id =  user_id;
 user_pass = Password;

           user_type =  userType;
         this.FirstName =    FirstName;
            this.FamilyName =    FamilyName;
            this.Mobile = Mobile;
            this.user_name = Username;

        }  String user_id = null;
        
        
      
        int countOfDeletedUser;
        public UserUtil(String id) {
            this.user_id = id;
          
        
        }
        public void setUser_id(String user_id)
        {
            this.user_id = user_id;
        }

        public void setUser_pass(String user_pass)
        {
            this.user_pass = user_pass;
        }
        public int getFromUser()
        {
            return fromUser;

        }
        public int getToUser()
        {

            return toUser;
        }

        public void setUser_name(String user_name)
        {
            this.user_name = user_name;
        }

        public void setUser_type(String user_type)
        {
            this.user_type = user_type;
        }

        public void setFirstName(String FirstName)
        {
            this.FirstName = FirstName;
        }

        public void setFamilyName(String FamilyName)
        {
            this.FamilyName = FamilyName;
        }

        public void setSpecialization(String Specialization)
        {
            this.specialization = Specialization;
        }
        public void setMobile(String Mobile)
        {
            this.Mobile = Mobile;
        }
        

        public String getSpecialization() {
            return specialization;
        }
        public String getUser_id()
        {
            return user_id;
        }
        public String getUser_pass()
        {
            return user_pass;
        }

        public String getUser_name()
        {
            return user_name;
        }

        public String getUser_type()
        {
            return user_type;
        }

        public String getFirstName()
        {
            return FirstName;
        }

        public String getFamilyName()
        {
            return FamilyName;
        }

        public String getMobile()
        {
            return Mobile;
        }

      
        public UserUtil()
        {

            user_id = null;
            user_pass = null;
            user_name = null;
            user_type = "";
           
        }
        public UserUtil(String id, String pass)
        {

            user_id = id;
            user_pass = pass;


        }
        public UserUtil(String id, String pass, String name, String type)
        {

            user_id = id;
            user_pass = pass;
            user_name = name;
            user_type = type;
            
        }

        internal static bool validatePassword(string pass, string confirm, Label lbl_passError)
        {
            bool isValid = true;
            if (pass.Equals(confirm))
            {
                isValid = true;
                lbl_passError.Text = "";

            }
            else
            {
                lbl_passError.Text = "MisMatch";
                isValid = false;
            }
            return isValid;
        }
        public static bool ValidateString(String test, Label lbl)
        {
            bool isvalid = true;
            if (test.Length == 0)
            {
                lbl.Text = "Invalid";
                return false;
            }
            else
            {
                lbl.Text = "";
            }
            return isvalid;

        }
    }
}
