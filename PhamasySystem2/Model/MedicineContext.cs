using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PhamasySystem2.Model
{
    public class MedicineContext: DbContext
    {

        public MedicineContext(DbContextOptions<MedicineContext> options): base(options)
        {
        }
        //create medicine database adn table
        public DbSet<Medicines> Medicines { get; set; }

    }
}
