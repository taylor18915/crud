using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRUDHW2.Data;

namespace CRUDHW2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CRUDHW2.Data.Automobiles> Automobiles { get; set; }
        public DbSet<CRUDHW2.Data.Manufacturers> Manufacturers { get; set; }

    }
}
