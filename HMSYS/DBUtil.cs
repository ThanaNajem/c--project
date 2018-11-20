using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace HMSYS
{
    class DBUtil
    {

        internal static DataTable GetAllUsersView()
        {
            SqlConnection conn = getConnection();
            string get_users = "SELECT [ID] as Id,[USER_NAME] as UserName,[PASSWORD] as Password,[USER_TYPE] as UserType,[FIRST_NAME] as FirstName,[FATHER_NAME] as Father_name,[MOBILE] as Mobile,[SPECIALIZATION] as Specialization FROM [HOSPITAL_SYSTEM].[dbo].[USERS]";
            /* "'AND  MESSAGE_DATE='" + user.getDate().Date.ToString("yyyy-MM-dd HH:mm:ss") +*/
            SqlDataAdapter sda = new SqlDataAdapter(get_users, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        
        }
       
        internal static DataTable GetAllPatiantInfoView() {

            SqlConnection conn = getConnection();
            string get_users = "SELECT [ID] as id,[FIRST_NAME]as firstName,[FATHER_NAME]as fathername,[MOBILE]as mobile,[EMAIL] as email,[USER_ID]as userId FROM [HOSPITAL_SYSTEM].[dbo].[PATIENT_INFO]";
            /* "'AND  MESSAGE_DATE='" + user.getDate().Date.ToString("yyyy-MM-dd HH:mm:ss") +*/
            SqlDataAdapter sda = new SqlDataAdapter(get_users, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        
        }
      internal static DataTable   GetAllMessagesForThisUser(int user_Type){
       
        SqlConnection conn = getConnection();
        string get_users = "SELECT [ID] As userId,[MESSAGE_BODY] as MESSAGE_BODY,[MESSAGE_DATE]as MESSAGE_DATE,[FROM_USER]as FROM_USER,[TO_USER]as TO_USER ,[PATIENT_ID] as PATIENT_ID FROM [HOSPITAL_SYSTEM].[dbo].[MESSAGES] where  TO_USER="+user_Type+";";
                /* "'AND  MESSAGE_DATE='" + user.getDate().Date.ToString("yyyy-MM-dd HH:mm:ss") +*/
            SqlDataAdapter sda = new SqlDataAdapter(get_users, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        
        }

        internal static DataTable GetAllUsersMessages()
        {
            SqlConnection conn = getConnection();
            string get_users = "SELECT [ID] As userId,[MESSAGE_BODY] as MESSAGE_BODY,[MESSAGE_DATE]as MESSAGE_DATE,[FROM_USER]as FROM_USER,[TO_USER]as TO_USER ,[PATIENT_ID] as PATIENT_ID FROM [HOSPITAL_SYSTEM].[dbo].[MESSAGES]";
                /* "'AND  MESSAGE_DATE='" + user.getDate().Date.ToString("yyyy-MM-dd HH:mm:ss") +*/
            SqlDataAdapter sda = new SqlDataAdapter(get_users, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        }

        public static SqlConnection getConnection()
        {

            SqlConnection conn = new SqlConnection("user id=sa;" +
                                        "password=yaraby1313;server=localhost;" + "database=HOSPITAL_SYSTEM; ");

            return conn;

        }
        int countUsersDeleted = 0;
        /*   public static int getNoOfDeletedUser() {
              int  noOfDeletedUser = 0;
               SqlConnection conn = getConnection();
               conn.Open();
               //Be careful :: edit add user after ask my lecture about insertion statement 
               // Convert.ToInt32(user.getUser_id()) + "," +
               string query = "SELECT NoRepresentOfUserDeleted FROM NoOfUserDeleted where id =1;";
               SqlCommand cmd = new SqlCommand(query, conn);
              SqlDataReader dr = cmd.ExecuteReader ();
               //  MessageBox.Show("Inserting Data Successfully");

               if(dr.Read()){
                   noOfDeletedUser= dr.GetInt32(0);
               }
               conn.Close();
               //don't return add befor confirm adding operation quickly

               return noOfDeletedUser;

        
        
           }
           */
        /*      public static void UpdatetNoOfDeleteUser(int noOfDeletedUser) {
                 // bool res = false;
                  SqlConnection conn = getConnection();

                  string query = "UPDATE NoOfUserDeleted SET NoRepresentOfUserDeleted="+noOfDeletedUser+  "WHERE id=1;";
                  SqlCommand cmd = new SqlCommand(query, conn);
                  /*  cmd.CommandText = "DELETE FROM USERS WHERE ID=@userId;";
                    SqlParameter idparam = new SqlParameter("@userId", System.Data.SqlDbType.Int, 0);
                    idparam.Value = deleteUser.getUser_id();
                    cmd.Parameters.Add(idparam);*/
        /* conn.Open();
         //    cmd.Prepare();
         if (cmd.ExecuteNonQuery() == 1)
         {
            // res = true;
             MessageBox.Show("Update successfully");
         }
         conn.Close();
        // return res;

        
     }
         * */

       public static bool isPatientValid( PatientView PatientIDCheck ){
           SqlConnection conn = getConnection();
           conn.Open();  
           int id = Convert.ToInt32(PatientIDCheck.getPatientID());
           String query = "SELECT ID FROM PATIENT_INFO  where ID = " + id + ";";
           SqlCommand cmd = new SqlCommand(query, conn);
           SqlDataReader dr = cmd.ExecuteReader();
           bool isValidId = false;
           if (dr.Read())
           {
               isValidId = true;


           }
            
           dr.Close();
           conn.Close();

           return isValidId;

       }
       public static bool addPatient(PatientView patientUser)
       {

           SqlConnection conn = getConnection();
           conn.Open();
           //Be careful :: edit add user after ask my lecture about insertion statement 
           // Convert.ToInt32(user.getUser_id()) + "," +
           String query = "INSERT INTO PATIENT_INFO (ID,FIRST_NAME,FATHER_NAME,MOBILE,EMAIL,USER_ID)VALUES (" + Convert.ToInt32(patientUser.getPatientID()) + ",'" + patientUser.getFirstName() + "','" + patientUser.getFamilyName() + "'," + patientUser.getMobile() + ",'" + patientUser.getEmail() + "'," + Convert.ToInt32(patientUser.getUser_id()) + ");";
               
           SqlCommand cmd = new SqlCommand(query, conn);
           bool isUserAdd = cmd.ExecuteNonQuery() == 1;
           //  MessageBox.Show("Inserting Data Successfully");


           conn.Close();
           //don't return add befor confirm adding operation quickly

           return isUserAdd;

           //  
       
       }
        public static UserUtil login(UserUtil user)
        {
            String id = user.getUser_id();
            int int_id = Convert.ToInt32(id);
            String pass = user.getUser_pass();
            UserUtil res = null;
            //DB name : Currency_Exchange
            //MainDB : sa
            //password : yaraby1313

            SqlConnection conn = getConnection();
            //conn.setAutoCommit(false);
            SqlCommand cmd = conn.CreateCommand();
            String cmd_1 = "";
            cmd.CommandText = "select ID,USER_NAME,PASSWORD,USER_TYPE from USERS where ID = " + id + "and PASSWORD= " + pass + ";";

            // OpenSqlConnection();
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string name = dr.GetString(1);



                int user_int_type = dr.GetInt32(3);
                String user_type = user_int_type + "";
                res = new UserUtil(id, pass, name, user_type);
            }

            return res;
        }
        /*  public static void resetId(String tblName,int lastResetAsLastRow) {
              String sqlQuery = "DBCC CHECKIDENT ('" + tblName + "', RESEED, " + lastResetAsLastRow + ");";
        
          }*/
        internal static bool addUsers(UserUtil user)
        {

            SqlConnection conn = getConnection();
            conn.Open();
            //Be careful :: edit add user after ask my lecture about insertion statement 
            // Convert.ToInt32(user.getUser_id()) + "," +
            string query = "insert into USERS( USER_NAME,PASSWORD,USER_TYPE,FIRST_NAME,FATHER_NAME,MOBILE,Specialization)" + "values ('" + user.getUser_name() + "','" + user.getUser_pass() + "'," + Convert.ToInt32(user.getUser_type())  +",'" + user.getFirstName() + "','" + user.getFamilyName() + "'," + user.getMobile() + ",'" + user.getSpecialization() + "');";
            SqlCommand cmd = new SqlCommand(query, conn);
            bool isUserAdd = cmd.ExecuteNonQuery() == 1;
            //  MessageBox.Show("Inserting Data Successfully");


            conn.Close();
            //don't return add befor confirm adding operation quickly

            return isUserAdd;

        }

        /*  public static bool UpdateUserDetail(UserUtil UpdateUserDetail)
          {

              bool res = false;
              SqlConnection conn = getConnection();

              string query = "Update USER_DETAILS SET USER_ID="+UpdateUserDetail.getUser_id()+" , FIRST_NAME='"+UpdateUserDetail.getFirstName()+"',FATHER_NAME='"+UpdateUserDetail.getFamilyName()+"',MOBILE="+UpdateUserDetail.getMobile()+";";
              SqlCommand cmd = new SqlCommand(query, conn);
              conn.Open(); 
              if (cmd.ExecuteNonQuery() == 1)
               {
                 res = true;
                 MessageBox.Show("UpdateUserDetail successfully");
               }
               conn.Close();
             return res;

           }//..ما رح نعمل اب ديت لشيء مش موجود
         * */
        /*
         * 
         * // new new new 
         * 
         * public static bool UpdateUser(UserUtil UpdateUser)
           {
               bool res = false;
               SqlConnection conn = getConnection();
               String query_1 = "BEGIN TRANSACTION;UPDATE USERS SET USERS.PASSWORD = '" + UpdateUser.getUser_pass()
                   + "', USERS.USER_NAME='" + UpdateUser.getUser_name() + "' ,USERS.USER_TYPE="
                   + Convert.ToInt32(UpdateUser.getUser_type()) + "FROM USERS T1, USERS_DETAILS T2"
                   + "WHERE T1.ID = T2.USER_ID"
                   + "and T1.ID = +'" + UpdateUser.getUser_id() + "'; 
         * 
         * 
         * UPDATE USERS_DETAILS"
                   + "SET USERS_DETAILS.USER_ID=" + UpdateUser.getUser_id() + " , USERS_DETAILS.FIRST_NAME='"
                   + UpdateUser.getFirstName() + "',USERS_DETAILS.FATHER_NAME='" + UpdateUser.getFamilyName() +
                   "',USERS_DETAILS.MOBILE='" + UpdateUser.getMobile()
                   + "'" + "FROM USERS T1, USERS_DETAILS T2"
                   + "WHERE T1.ID = T2.USER_ID"
                   + "and T1.ID = '" + UpdateUser.getUser_id() + "'; COMMIT;";
               SqlCommand cmd = new SqlCommand(query_1, conn);
               conn.Open();
               if (cmd.ExecuteNonQuery() == 1)
               {
                   res = true;
                   MessageBox.Show("UpdateUser successfully");
               }
               conn.Close();
               return res;
           }

           */
        //UPDATE im SET mf_item_number = gm.SKU --etc FROM item_master im JOIN group_master gm ON im.sku = gm.sku
        public static bool UpdateUserInfo(UserUtil UpdateUser) {

            bool res = false;
            SqlConnection conn = getConnection();
            conn.Open();
           if(!((UpdateUser.getUser_id().Length==0)||UpdateUser.getUser_id()==null))
           {int id = Convert.ToInt32(UpdateUser.getUser_id());
            String query = " UPDATE USERS SET PASSWORD = '" + UpdateUser.getUser_pass()
                   + "', USER_NAME='" + UpdateUser.getUser_name() + "' ,USER_TYPE="
                   + Convert.ToInt32(UpdateUser.getUser_type())+
             " , FIRST_NAME='"
                   + UpdateUser.getFirstName() + "',FATHER_NAME='" + UpdateUser.getFamilyName() +
                   "',MOBILE='" + UpdateUser.getMobile()
                   + "'" + "FROM USERS "
                   
                   + "WHERE ID = " + UpdateUser.getUser_id() + "; ";
            SqlCommand cmd = new SqlCommand(query, conn);
           bool isUserUpdate= cmd.ExecuteNonQuery()==1;
           if (isUserUpdate)
           {
               res = true;
               MessageBox.Show("This User is successfuly updated");
           }
           else {
               res = false;
               MessageBox.Show("This User isn't successfuly updated");
           }
        }
            else{
                MessageBox.Show("please enter valid id");
           
           }
            
           return res;
        }

        public static bool UpdatePatientInfo(PatientView UpdatePatient)
        {//   و كمان اعملي انه الاي دي ممنوع يتعدل يعني دس انيبيل للتيكست بوكس اعمل اب ديت لشيء موجود اجري تعديل ع الكود 

            bool res = false;
            SqlConnection conn = getConnection();
            conn.Open();
            if (!((UpdatePatient.getPatientID().Length == 0) || UpdatePatient.getPatientID() == null))
            {
                int id = Convert.ToInt32(UpdatePatient.getPatientID());
                String query = "UPDATE PATIENT_INFO SET FIRST_NAME='"+UpdatePatient.getFirstName()+"',FATHER_NAME='"+UpdatePatient.getFamilyName()+"',MOBILE="+UpdatePatient.getMobile()+",EMAIL='"+UpdatePatient.getEmail()+"',USER_ID="+UpdatePatient.getUser_id()+"where ID="+UpdatePatient.getPatientID()+";";
                SqlCommand cmd = new SqlCommand(query, conn);
                bool isUserUpdate = cmd.ExecuteNonQuery() == 1;
                if (isUserUpdate)
                {
                    res = true;
                    MessageBox.Show("This Patient is successfuly updated");
                }
                
                else
                {
                    res = false;
                    MessageBox.Show("This Patient isn't successfuly updated");
                }  MessageBox.Show(isUserUpdate+"");
            }
            else
            {
                MessageBox.Show("please enter valid id");

            }
            
            return res;
        }
/*
       public static bool ExecuteSqlTransaction(UserUtil UpdateUser)
        {
bool res = false;

            using (SqlConnection connection = getConnection())
            {
                
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                
                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection 
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;


                try
                {
                    command.CommandText =
                     " UPDATE USERS SET USERS.PASSWORD = '" + UpdateUser.getUser_pass()
                   + "', USERS.USER_NAME='" + UpdateUser.getUser_name() + "' ,USERS.USER_TYPE="
                   + Convert.ToInt32(UpdateUser.getUser_type()) + "FROM USERS T1, USERS_DETAILS T2"
                   + "WHERE T1.ID = T2.USER_ID"
                   + "and T1.ID = +" + UpdateUser.getUser_id() + ";";
                    command.ExecuteNonQuery();
                    command.Dispose();
                    SqlCommand command1 = connection.CreateCommand();
                    SqlTransaction transaction1;
                    transaction1 = connection.BeginTransaction("SampleTransaction");
                    command1.Connection = connection;
                    command1.Transaction = transaction ;
                    command1.CommandText =
                     "  UPDATE USERS_DETAILS"
                   + "SET USERS_DETAILS.USER_ID=" + UpdateUser.getUser_id() + " , USERS_DETAILS.FIRST_NAME='"
                   + UpdateUser.getFirstName() + "',USERS_DETAILS.FATHER_NAME='" + UpdateUser.getFamilyName() +
                   "',USERS_DETAILS.MOBILE='" + UpdateUser.getMobile()
                   + "'" + "FROM USERS T1, USERS_DETAILS T2"
                   + "WHERE T1.ID = T2.USER_ID"
                   + "and T1.ID = " + UpdateUser.getUser_id() + ";";
           
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    res = true;
                    MessageBox.Show("Both records are updateen to database.");
                    return res;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    // Attempt to roll back the transaction. 
                    try
                    {
                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred 
                        // on the server that would cause the rollback to fail, such as 
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
            return res;
        }
        */
        public static int getLastIdInUserDetailTbl()
        {
            SqlConnection conn = getConnection();
            conn.Open();

            String query = "SELECT TOP 1 ID FROM USERS_DETAILS ORDER BY ID DESC;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            int lastId = -1;
            if (dr.Read())
            {
                lastId = dr.GetInt32(0);


            }
            dr.Close();
            conn.Close();
            return lastId;
        }


        public static int getLastIdInUserTbl()
        {
            SqlConnection conn = getConnection();
            conn.Open();

            String query = "SELECT TOP 1 ID FROM USERS ORDER BY ID DESC;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            int lastId = -1;
            if (dr.Read())
            {
                lastId = dr.GetInt32(0);


            }
            dr.Close();
            conn.Close();

            return lastId;
        }
        public static bool deletePatientFromTblPatientr(PatientView deletePatient)
        {
            bool res = false;
            SqlConnection conn = getConnection();
            // SqlCommand cmd = conn.CreateCommand();
            // cmd.CommandText = "DELETE FROM USERS WHERE ID="+deleteUser.getUser_id()+";";
            string query = "DELETE FROM  PATIENT_INFO WHERE ID=" + deletePatient.getPatientID() + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
            /*  cmd.CommandText = "DELETE FROM USERS WHERE ID=@userId;";
              SqlParameter idparam = new SqlParameter("@userId", System.Data.SqlDbType.Int, 0);
              idparam.Value = deleteUser.getUser_id();
              cmd.Parameters.Add(idparam);*/
            conn.Open();
            //    cmd.Prepare();
            if (cmd.ExecuteNonQuery() == 1)
            {
                res = true;

            }
            conn.Close();
            return res;
        }
        
        public static bool deleteUserFromTblUser(UserUtil deleteUser)
        {
            bool res = false;
            SqlConnection conn = getConnection();
            // SqlCommand cmd = conn.CreateCommand();
            // cmd.CommandText = "DELETE FROM USERS WHERE ID="+deleteUser.getUser_id()+";";
            string query = "DELETE FROM USERS WHERE ID=" + deleteUser.getUser_id() + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
            /*  cmd.CommandText = "DELETE FROM USERS WHERE ID=@userId;";
              SqlParameter idparam = new SqlParameter("@userId", System.Data.SqlDbType.Int, 0);
              idparam.Value = deleteUser.getUser_id();
              cmd.Parameters.Add(idparam);*/
            conn.Open();
            //    cmd.Prepare();
            if (cmd.ExecuteNonQuery() == 1)
            {
                res = true;

            }
            conn.Close();
            return res;

            /* conn.Open();
           
             // Convert.ToInt32(user.getUser_id()) + "," +
             string query = "DELETE FROM USERS WHERE ID=@userId;";
             SqlCommand cmd = new SqlCommand(query, conn);
  //           ....

             
 //cmd.CommandText = "DELETE FROM excludes WHERE word = @word";
         cmd.Parameters.AddWithValue("@userId", ID);  
         cmd.ExecuteNonQuery();
                



             cmd.ExecuteNonQuery();
             //  MessageBox.Show("Inserting Data Successfully");
             MessageBox.Show(cmd.ExecuteNonQuery() + "");
             bool isUserAdd = cmd.ExecuteNonQuery() == 1;
             conn.Close();
             //don't return add befor confirm adding operation quickly

             return isUserAdd;
             */

        }
        
        public static bool IsUserValid(UserUtil user)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            int id = Convert.ToInt32(user.getUser_id());
            String query = "SELECT ID FROM USERS  where ID = " + id + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            bool isValidId = false;
            if (dr.Read())
            {
                isValidId = true;

               
            }
           
            dr.Close();
            conn.Close();

            return isValidId;


        }

        public static Message getMessageInfo(UserUtil user)
        {int TO_USER=0;
            
            Message message = null;
            SqlConnection conn = getConnection();
            conn.Open();
            /*MESSAGE_DATE,*/ //this is taken from query statement 
            String query = "SELECT MESSAGE_BODY,TO_USER FROM MESSAGES WHERE PATIENT_ID='" + Convert.ToInt32(user.getUser_id()) + "'AND FROM_USER='" + user.getFromUser() + "'AND TO_USER='" + user.getToUser() + "';";/* "'AND  MESSAGE_DATE='" + user.getDate().Date.ToString("yyyy-MM-dd HH:mm:ss") +*/
           
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

           /* List<Message> ListOfAllMessagesBtnThem = null;
             ListOfAllMessagesBtnThem=   new List<Message>();
            */
           String MESSAGE_BODY=""; /*DateTime MESSAGE_DATE=new DateTime();*/
            if (dr.Read()) {
              MESSAGE_BODY=  dr.GetString(0);
             // DateTime MESSAGE_DATE = dr.GetDateTime(1)/*.Date.ToString("yyyy-MM-dd")*/;
        
               TO_USER= dr.GetInt32(1);
             
          //  DateTime MESSAGE_DATE_INDate=Convert.ToDateTime(MESSAGE_DATE);
            message = new Message(MESSAGE_BODY);
               
                // ListOfAllMessagesBtnThem.Add(message);
            }
            return message;
             // return ListOfAllMessagesBtnThem;
        }
        public static bool insertMessageInfo(Message message ){
            SqlConnection conn = getConnection();
            bool isUserAdd = false;
            //Be careful :: edit add user after ask my lecture about insertion statement 
            // Convert.ToInt32(user.getUser_id()) + "," +
           // MessageBox.Show( message.getPATIENT_ID().getUser_id() + "");
            /*.Date.ToString("yyyy-MM-dd HH:mm:ss")*/
            String query = "INSERT INTO [MESSAGES] (MESSAGE_BODY,MESSAGE_DATE,FROM_USER,TO_USER,PATIENT_ID)VALUES ('" 
                + message.getMESSAGE_BODY() + "','" +
                message.getMESSAGE_DATE().Date.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                message.getFROM_USER().getUser_type() + "','" +
                message.getTO_USER().getUser_type() + "','" + 
                message.getPATIENT_ID().getPatientID() + "');";

          
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);


            isUserAdd = cmd.ExecuteNonQuery() == 1;
            //  MessageBox.Show("Inserting Data Successfully");


            conn.Close();
            //don't return add befor confirm adding operation quickly
            
            return isUserAdd;

    
    }
        public static UserUtil getUserTypeById(UserUtil user) {
            UserUtil UserWithUserType = null;
            SqlConnection conn = getConnection();
            conn.Open();
            String query = "SELECT USER_TYPE FROM USERS WHERE ID=" + user.getUser_id()+"AND PASSWORD="+user.getUser_pass() ;
        SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int userType = dr.GetInt32(0);
                UserWithUserType = new UserUtil(userType);

            }
            return UserWithUserType;
        }
public static PatientView getAllInfoPatient(PatientView patient)
    {
    
        PatientView patientInfo = null;
            SqlConnection conn = getConnection();
            conn.Open();
            int id = Convert.ToInt32(patient.getPatientID());
            String query = " SELECT * FROM PATIENT_INFO where ID="+id+";";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
           
            if (dr.Read())
            {
            int parient_id=dr.GetInt32(0);
                String First_name = dr.GetString(1);
                String Father_name = dr.GetString(2);
                String mobile = dr.GetString(3) + "";
                String email = dr.GetString(4);
               int user_id = dr.GetInt32(5);
         
                patientInfo = new PatientView (parient_id+"", First_name, Father_name, mobile, email, user_id+"");



            }
           /* else {

                user = null;
            }*/
            dr.Close();
            conn.Close();

            return patientInfo;



       
    }

        public static UserUtil getAllInfoUser(UserUtil user)
        {

            UserUtil users = null;
            SqlConnection conn = getConnection();
            conn.Open();
            int id = Convert.ToInt32(user.getUser_id());
            String query = " SELECT * FROM USERS where ID="+id+";";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
           // bool isValidId = false;
            if (dr.Read())
            {
            
                String user_name = dr.GetString(1);
                String password = dr.GetString(2);
                String userType = dr.GetInt32(3) + "";
                String first_name = dr.GetString(4);
                String father_name = dr.GetString(5);
                String mobileno = dr.GetString(6) + "";
                String specialization = dr.GetString(7);
                users = new UserUtil(id+"", user_name, password, userType, first_name, father_name, mobileno, specialization);



            }
           /* else {

                user = null;
            }*/
            dr.Close();
            conn.Close();

            return users;



        }
    }
}
