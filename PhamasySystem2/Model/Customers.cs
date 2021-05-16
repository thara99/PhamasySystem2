using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhamasySystem2.Model
{
    public class Customers
    {
        [Key]
        public Guid CId { get; set; }

        public String CName { get; set; }

        public String PNum { get; set; }

        public String Address { get; set; }

        public String NIC { get; set; }

        public String AllergyMedicines { get; set; }

        public int Age { get; set; }

    }
}
