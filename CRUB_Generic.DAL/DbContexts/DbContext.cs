using CRUD_Generic.Core.Data;
using CRUD_Generic.DAL.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Generic.DAL.CRUDDbContext
{
    public class CRUDDbContext : System.Data.Entity.DbContext, IDbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }


        public CRUDDbContext() : base("name=DbConnectionString")
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
