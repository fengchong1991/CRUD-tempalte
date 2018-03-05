using CRUD_Generic.Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUB_Generic.DAL.Mappings
{
    public class UserProfileMapping : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileMapping()
        {
            //key  
            HasKey(t => t.ID);
            //properties             
            Property(t => t.FirstName).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
            Property(t => t.LastName).HasMaxLength(100).HasColumnType("nvarchar");
            Property(t => t.Address).HasColumnType("nvarchar");
            Property(t => t.CreationDate).IsRequired();
            Property(t => t.ModeifiedDate).IsRequired();
            //table  
            ToTable("UserProfiles");
            //relation            
            HasRequired(t => t.User).WithRequiredDependent(u => u.UserProfile);
        }
    }
}
