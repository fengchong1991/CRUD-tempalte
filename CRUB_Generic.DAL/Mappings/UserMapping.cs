using CRUD_Generic.Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUB_Generic.DAL.Mappings
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(t => t.ID);

            Property(t => t.UserName).IsRequired();
            Property(t => t.Email).IsRequired();
            Property(t => t.Password).IsRequired();
            Property(t => t.CreationDate).IsRequired();
            Property(t => t.ModeifiedDate).IsRequired();

            ToTable("Users");
 
        }
    }
}
