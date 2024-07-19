using AuthenticationDemo.Model;

namespace AuthenticationDemo.Interface
{
    public interface IUserRole
    {
        bool AddUserRole(UserRole userrole);

        bool UpdateUserRole(UserRole userrole);

        bool DeleteUserRole(int Id);

        List<UserRole> GetAllUserRoles();

        UserRole GetUserRoleById(int id);
    }
}
