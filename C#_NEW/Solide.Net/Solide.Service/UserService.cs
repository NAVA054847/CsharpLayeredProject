using Solide.Data;
using Solide.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solide.Service
{
    public  class UserService
    {

        UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUser();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public User AddUser(User user)
        {
            if (_userRepository.GetUserByEmail(user.Email) != null)
            {
                throw new Exception("User Exist");
            }
            return _userRepository.AddUser(user);
        }

        public User UpdateUser(  int id ,User user)
        {
            return _userRepository.UpdadeUser(id ,user);
        }
        public User DeleteUser(int id)
        {
            return  _userRepository.Delete(id);
        }

    }
}
