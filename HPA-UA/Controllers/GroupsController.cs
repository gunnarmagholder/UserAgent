using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HPA_UA.Models;

namespace HPA_UA.Controllers
{
    public class GroupsController : ApiController
    {
        IGroupRepository _groups = new GroupRepository();
        public IEnumerable<string> Get()
        {
            return _groups.GetAll();
        }
    }
}
