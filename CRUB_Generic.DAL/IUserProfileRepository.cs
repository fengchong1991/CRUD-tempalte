using CRUD_Generic.Core.Data;
using CRUD_Generic.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUB_Generic.DAL
{
    public interface IUserProfileRepository: IRepository<UserProfile>
    {
        string GetFullName();
    }
}
