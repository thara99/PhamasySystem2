﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PhamasySystem2.Model
{
    public class IdentityContext: DbContext
    {

        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {
        }

        public DbSet<UserId> IdentityUser { get; set; }

    }
}
