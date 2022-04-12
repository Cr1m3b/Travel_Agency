using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Travel_Agency.Controllers.WebAPIControllers
{
    public class EmailController : ApiController
    {
        public void Post(Email emailaddress)
        {
            Email email = new Email()
            {
                To = emailaddress.To,

                Subject = emailaddress.Subject,
                Body = emailaddress.Body

            };  
            email.SendMail();   
        }
    }
}
