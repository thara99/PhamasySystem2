using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhamasySystem2.Identity;
using PhamasySystem2.Model;

namespace PhamasySystem2.Controllers
{
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private IIdentity _identity;

        private IdentityContext _identityContext;
        public IdentityController(IdentityContext identityContext)
        {
            _identityContext = identityContext;
        }


        public IdentityController(IIdentity identity)
        {
            _identity = identity;
        }

        [Route("api/[controller]/{id}")]
        public IActionResult GetIdentity(Guid id)
        {
            var identity = _identity.getIdentity(id);

            if (identity != null)
            {
                return Ok(_identity.getIdentity(id));
            }
            return NotFound($"Customer with ID: {id} was not found");

        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddMedicine(UserId userId)
        {
            _identity.AddIdentity(userId);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +
                userId.IId, userId);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult CheckIdentity(int id,String UserName,String password,UserId userId)
        {
            var exixtingIdentity = _identityContext.IdentityUser.Find(userId.IId);

            if (exixtingIdentity.UserName == userId.UserName && exixtingIdentity.Password == userId.Password)
            {
                return Ok("Login Successfull");

            }
            return NotFound("Invalid Credencials");



        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetIdentities()
        {
            return Ok(_identity.GetIdentities());
        }



    }
}