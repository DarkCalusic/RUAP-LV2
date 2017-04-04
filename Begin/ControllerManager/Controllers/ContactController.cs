using ControllerManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControllerManager.Controllers
{
    public class ContactController : ApiController
    {
        public int Id;
        public string Name; 
        public Contact[] Get()
        {
        return new Contact[]
        {
            new Contact
            {
                Id = 1,
                Name = "Glenn Block"
            },
            new Contact
            {
                Id = 2,
                Name = "Dan Roth"
            }
        };
    }
}
}
