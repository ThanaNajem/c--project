using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMSYS
{
    class Message
    {
        String   MESSAGE_BODY;
        PatientView PATIENT_ID;
        UserUtil FROM_USER, TO_USER;
        DateTime MESSAGE_DATE;

         
        
        public void setMESSAGE_BODY(String MESSAGE_BODY)
        {
            this.MESSAGE_BODY = MESSAGE_BODY;
        }

        public void setFROM_USER(UserUtil FROM_USER)
        {
            this.FROM_USER = FROM_USER;
        }

        public void setTO_USER(UserUtil TO_USER)
        {
            this.TO_USER = TO_USER;
        }

        public void setPATIENT_ID(PatientView PATIENT_ID)
        {
            this.PATIENT_ID = PATIENT_ID;
        }
        public Message(PatientView PATIENT_ID) {
            this.PATIENT_ID = PATIENT_ID;
        
        }

        public void setMESSAGE_DATE(DateTime MESSAGE_DATE)
        {
            this.MESSAGE_DATE = MESSAGE_DATE;
        }

        public String getMESSAGE_BODY()
        {
            return MESSAGE_BODY;
        }

        public UserUtil getFROM_USER()
        {
            return FROM_USER;
        }

        public UserUtil getTO_USER()
        {
            return TO_USER;
        }

        public PatientView getPATIENT_ID()
        {
            return PATIENT_ID;
        }

        public DateTime getMESSAGE_DATE()
        {
            return MESSAGE_DATE;
        }

        public Message( String MESSAGE_BODY, UserUtil FROM_USER, UserUtil TO_USER, PatientView PATIENT_ID/*, DateTime MESSAGE_DATE*/)
        {
          
            this.MESSAGE_BODY = MESSAGE_BODY;
            this.FROM_USER = FROM_USER;
            this.TO_USER = TO_USER;
            this.PATIENT_ID = PATIENT_ID;
           // this.MESSAGE_DATE = MESSAGE_DATE;
        }

        public Message(String MESSAGE_BODY) {
            this.MESSAGE_BODY = MESSAGE_BODY;
        
        }
    }
}
