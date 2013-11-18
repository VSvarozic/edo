using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EDO.UI.WebUI.Models.Registration
{
    public class BusinessContacts : IBusinessRegStep
    {
        // Руководитель
        public string Position { get; set; }        
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }

        // Контактное лицо
        public bool IsEqualDirector { get; set; }
        public string ContactPosition { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactSurname { get; set; }
        public string ContactLastName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMobilePhone { get; set; }
        public string ContactEmail { get; set; }

        // Идентификационные данные
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }
        public string PassPhrase { get; set; }
    }
}