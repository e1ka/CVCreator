using CVCreator.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CVCreator.DAL
{
    public class CVCreatorDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<WorkExp> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public CVCreatorDbContext()
            :base("CVCreatorContext")
        {
          // Database.SetInitializer<CVCreatorDbContext>(new DropCreateDatabaseAlways<CVCreatorDbContext>());
                     Database.SetInitializer(new CVCreatorDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}