using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ESchool.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Models.Person> People { get; set; }
        public DbSet<Models.JournalMain> JournalMains { get; set; }
        public DbSet<Models.JournaPresent> JournaPresents { get; set; }
        public DbSet<Models.JournalRait> JournalRaits { get; set; }
        public DbSet<Models.SchoolEvent> SchoolEvents { get; set; }
        public DbSet<Models.Student> Students { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }
    }
}
