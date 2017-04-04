using ControllerManager.Models;
using ControllerManager.Services;
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
        private ContactRepository contactRepository;
        public int Id;
        public string Name;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        } 
        
        
        public Contact[] Get()
        {
            return this.contactRepository.GetAllContacts();
    }
}
}
