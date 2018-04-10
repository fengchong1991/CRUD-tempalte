using CRUD_Generic.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Generic.Service
{
    public interface IUserService
    {
        string GetUserFullName();

        IEnumerable<User> GetUsers();
    }
}
