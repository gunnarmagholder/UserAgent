using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;

namespace HPA_UA.Models
{
    public class Group : IGroup
    {
       
        public Group(string _grpName)
        {
            
        }
        public string GroupName { get; set; }

        public IEnumerable<UserAccount> Members()
        {
            throw new NotImplementedException();
        }
    }
}