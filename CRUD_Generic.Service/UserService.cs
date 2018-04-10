using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUB_Generic.DAL;
using CRUB_Generic.DAL.Repositories;
using CRUD_Generic.Core.Data;
using CRUD_Generic.DAL;

namespace CRUD_Generic.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;


        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string GetUserFullName()
        {
            return "";
        }

        public IEnumerable<User> GetUsers()
        { 
            return _userRepository.GetAll();
        }
    }
}
