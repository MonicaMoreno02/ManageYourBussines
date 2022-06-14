using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.servicioEmail
{
    public class systemSupportMail: MasterServicoMail
    {
        public systemSupportMail()
        {
            senderMail = "muebles.sanjose236@gmail.com";
            password = "Samanta1323";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}