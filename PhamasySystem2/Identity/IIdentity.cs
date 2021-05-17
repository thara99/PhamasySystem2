using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhamasySystem2.Identity;
using PhamasySystem2.Model;

namespace PhamasySystem2.Identity
{
    public interface IIdentity
    {

        UserId CheckIdentity(Guid id,String UserName,String Password);

        UserId getIdentity(Guid id);

        List<UserId> GetIdentities();

        UserId AddIdentity(UserId userId);

    }
}
