using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhamasySystem2.Model
{
    public class Medicines
    {
        [Key]
        public Guid Id { get; set; }


        public String Name { get; set; }


        public String CompanyName { get; set; }

    
        public String Disease { get; set; }

  
        public double Amount { get; set; }

    }
}
