using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HPA_UA.Models;

namespace HPA_UA.Controllers
{
    [Authorize]
    public class UserAccountController : ApiController
    {
        IUserAccountRepository _users = new UserAccountRepository();
        [Authorize]
        public IEnumerable<UserAccount> Get()
        {
            return _users.GetAll();
        }
        [Authorize]
        public IEnumerable<UserAccount> Get(string SortOrder, int start, int number)
        {
            return _users.GetPage(SortOrder, start, number);
        } 
    }
}
