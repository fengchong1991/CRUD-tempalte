using CRUB_Generic.DAL.Mappings;
using CRUD_Generic.Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CRUB_Generic.DAL.DbContext
{
    public class DbContext : System.Data.Entity.DbContext, IDbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }


        public DbContext() : base("name=DbConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new UserProfileMapping());


            base.OnModelCreating(modelBuilder);
        }

    }
}
