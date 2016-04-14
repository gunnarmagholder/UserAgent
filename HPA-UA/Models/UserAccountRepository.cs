using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;

namespace HPA_UA.Models
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private PrincipalContext thisOU =
            new PrincipalContext(ContextType.Domain, "ht.stadt.hamburg.de", "OU=Standard,OU=Benutzer,DC=ht,DC=stadt,DC=hamburg,DC=de");


        public UserAccountRepository()
        {
            
        }
        public UserAccount Find(string key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserAccount> GetPage(string sortField, int start, int Number)
        {
            List<UserAccount> resultSet = new List<UserAccount>();
            UserPrincipalEx findAllUsers = new UserPrincipalEx(thisOU);
            PrincipalSearcher ps = new PrincipalSearcher(findAllUsers);
            ((DirectorySearcher)ps.GetUnderlyingSearcher()).PageSize = 0;
            ((DirectorySearcher)ps.GetUnderlyingSearcher()).Sort = new SortOption(sortField, SortDirection.Ascending);
            ((DirectorySearcher)ps.GetUnderlyingSearcher()).VirtualListView = new DirectoryVirtualListView(1,10,0);
            PrincipalSearchResult<Principal> result = ps.FindAll();
            foreach (UserPrincipalEx user in result)
            {
                string firstName = user.GivenName;
                string lastName = user.Surname;
                string orgKennzeichen = user.ExtensionAttribute8;
                string samAccountName = user.SamAccountName;
                UserAccount _user = new UserAccount()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    OrgKennzeichen = orgKennzeichen,
                    SAMAccountName = samAccountName
                };
                resultSet.Add(_user);
            }
            return resultSet;
        }

        public IEnumerable<UserAccount> GetAll()
        {
            UserPrincipalEx findAllUsers = new UserPrincipalEx(thisOU);
            PrincipalSearcher ps = new PrincipalSearcher(findAllUsers);
            foreach (UserPrincipalEx user in ps.FindAll())
            {
                string firstName = user.GivenName;
                string lastName = user.Surname;
                string orgKennzeichen = user.ExtensionAttribute8;
                string samAccountName = user.SamAccountName;
                UserAccount _user = new UserAccount()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    OrgKennzeichen = orgKennzeichen,
                    SAMAccountName = samAccountName
                };
                yield return _user;
            }
        }

    }

}