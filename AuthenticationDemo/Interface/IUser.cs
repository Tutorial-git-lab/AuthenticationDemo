using AuthenticationDemo.Model;

namespace AuthenticationDemo.Interface
{
    public interface IUser
    {
        bool AddUser(User user);

        bool UpdateUser(User user); 

        bool DeleteUser(int Id);

        List<User> GetAllUser();

        User GetUserById(int Id);

        User Authenticate(Login login);
    }
}
