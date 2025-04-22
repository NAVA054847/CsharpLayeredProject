using NAVA_CHAYA.Entities;
using Solide.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solide.Data
{
    public class UserRepository
    {

       private readonly DataContext _context;
        public UserRepository() 
        {
            _context=new DataContext();
        } 

        public List<User> GetAllUser() { 

            return _context.Users.ToList();
        }
        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }

        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User UpdadeUser( int id,User user)
        {
            User user2 = _context.Users.First(u => u.Id == id);

            user2.Id = user.Id;
            user2.Name = user.Name;
            user2.Email = user.Email;

            _context.SaveChanges();

            return user2;
        }





        public User Delete(int id)
        {
            User user2 = _context.Users.First(u => u.Id == id);
            _context.Remove(user2);
            _context.SaveChanges();
            return user2;
      
        }

    }
}
