using AuthenticationDemo.Data;
using AuthenticationDemo.Interface;
using AuthenticationDemo.Model;
using Microsoft.AspNetCore.Http.HttpResults;

namespace AuthenticationDemo.Repository
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
           _context = context;
        }
        public bool AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public User Authenticate(Login login)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == login.UserId && x.Password == login.Password);
            return user;
        }

        public bool DeleteUser(int Id)
        {
            try
            {
                var user = _context.Users.Find(Id);
                _context.Users.Remove(user);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public List<User> GetAllUser()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public User GetUserById(int Id)
        {
            try
            {
                return _context.Users.Find(Id);

            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
