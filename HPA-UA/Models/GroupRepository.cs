using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;

namespace HPA_UA.Models
{
    public class GroupRepository : IGroupRepository
    {
        private PrincipalContext thisOU =
           new PrincipalContext(ContextType.Domain, "ht.stadt.hamburg.de", "OU=UBEPortal,OU=Sharepoint Berechtigungen,OU=Berechtigungsgruppen,OU=Gruppen,DC=ht,DC=stadt,DC=hamburg,DC=de");
       
        public Group Find(string key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAll()
        {

            GroupPrincipal findAllGroups = new GroupPrincipal(thisOU, "*");
            PrincipalSearcher ps = new PrincipalSearcher(findAllGroups);
            return ps.FindAll().Select(@group => @group.SamAccountName);
        }
    }
}