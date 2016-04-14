using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.DirectoryServices.AccountManagement;
namespace HPA_UA.Models
{
    [DirectoryRdnPrefix("CN")]
    [DirectoryObjectClass("Person")]
    public class UserPrincipalEx : UserPrincipal
    {
        public UserPrincipalEx(PrincipalContext context) : base(context) { }
        public UserPrincipalEx(PrincipalContext context,
                     string samAccountName,
                     string password,
                     bool enabled) : base(context, samAccountName, password, enabled)
        { }
        [DirectoryProperty("extensionAttribute8")]
        public string ExtensionAttribute8
        {
            get
            {
                if (ExtensionGet("extensionAttribute8").Length != 1)
                    return string.Empty;

                return (string)ExtensionGet("extensionAttribute8")[0];
            }
            set { ExtensionSet("extensionAttribute8", value); }
        }
    }
}