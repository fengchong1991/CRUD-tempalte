using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUB_Generic.DAL.Repositories;
using CRUD_Generic.Core.Data;
using CRUD_Generic.DAL;

namespace CRUD_Generic.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<UserProfile> _userProfileRepository;


        public UserService(IRepository<User> userRepository, IRepository<UserProfile> userProfile)
        {
            _userRepository = userRepository;
            _userProfileRepository = userProfile;
        }

        public void DeleteUser(User user)
        {
            _userProfileRepository.Delete(user.UserProfile);
            _userRepository.Delete(user);
        }

        public User GetUser(long id)
        {
            return _userRepository.GetById(id);
        }

        public string GetUserFullName(long id)
        {
            return _userProfileRepository.
        }

        public IQueryable<User> GetUsers()
        {
            return _userRepository.Table;
        }

        public void InsertUser(User user)
        {
            _userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }
    }
}
