using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HPA_UA.Models
{
    public class UserAccount
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SAMAccountName { get; set; }
        public string OrgKennzeichen { get; set; }
    }

}