using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhamasySystem2.Model
{
    public class UserId
    {

        [Key]
        public Guid IId { get; set; }

        public String UserName { get; set; }

        public String Password { get; set; }

        public String Type { get; set; }

    }
}
