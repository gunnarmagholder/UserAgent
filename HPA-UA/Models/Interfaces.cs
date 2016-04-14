using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPA_UA.Models
{
    public interface IGroup
    {
        IEnumerable<UserAccount> Members();
    }
}
