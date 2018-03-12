using CRUD_Generic.Core.Data;
using CRUD_Generic.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Generic.DAL
{
    public class Class1 : BaseRepository<User>
    {
        public Class1(IDbContext context) : base(context)
        {
        }
    }
}
