using CRUD_Generic.Core.Data;
using CRUD_Generic.DAL.Repositories;
using CRUB_Generic.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Generic.DAL;
using CRUD_Generic.DAL.CRUDDbContext;

namespace CRUB_Generic.DAL.Repositories
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(IDbContext context) : base(context)
        {

        }
    }
}
