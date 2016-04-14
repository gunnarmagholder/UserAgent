using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HPA_UA.Models
{
    public interface IUserAccountRepository
    {
        IEnumerable<UserAccount> GetAll();
        UserAccount Find(string key);
        IEnumerable<UserAccount> GetPage(string sortField, int start, int Number);
    }

    public interface IGroupRepository
    {
        IEnumerable<string> GetAll();
        Group Find(string key);
         
    }   
}