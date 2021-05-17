using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhamasySystem2.Model;

namespace PhamasySystem2.Identity
{
    public class SqlIdentityData : IIdentity
    {

        private IdentityContext _identityContext;
        public SqlIdentityData(IdentityContext identityContext)
        {
            _identityContext = identityContext;
        }

        public UserId AddIdentity(UserId userId)
        {
            userId.IId = Guid.NewGuid();
            _identityContext.IdentityUser.Add(userId);
            _identityContext.SaveChanges();
            return userId;
        }
 

        public UserId CheckIdentity(Guid id, string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public List<UserId> GetIdentities()
        {
            return _identityContext.IdentityUser.ToList();
        }


        public UserId getIdentity(Guid id)
        {
            var identity = _identityContext.IdentityUser.Find(id);
            return identity;
        }
    }
}
