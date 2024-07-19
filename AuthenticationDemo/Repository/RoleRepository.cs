using AuthenticationDemo.Data;
using AuthenticationDemo.Interface;
using AuthenticationDemo.Model;

namespace AuthenticationDemo.Repository
{
    public class RoleRepository : IRole
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddRole(Role role)
        {
            try
            {
                _context.Roles.Add(role);
                _context.SaveChanges();
                return true;
                
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteRole(int Id)
        {
            try
            {
                var role = _context.Roles.Find(Id);
                _context.Roles.Remove(role);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        
        public List<Role> GetAllRoles()
        {
            try
            {
                return _context.Roles.ToList();
            }
            catch (Exception)
            {

                return null;
            }

        }

        public Role GetRoleById(int Id)
        {
            try
            {

                return _context.Roles.Find(Id);
            }
            catch(Exception)
            {
                return null;
            }
        }
        public bool UpdateRole(Role role)
        {
            try
            {
                _context.Roles.Update(role);
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
