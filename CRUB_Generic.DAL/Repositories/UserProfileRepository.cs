using CRUD_Generic.Core.Data;
using CRUD_Generic.DAL;
using CRUD_Generic.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUB_Generic.DAL.Repositories
{
    public class UserProfileRepository : BaseRepository<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(IDbContext context) : base(context)
        {


        }

        public string GetFullName()
        {
            return null;
        }
    }
}
