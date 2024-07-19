using AuthenticationDemo.Data;
using AuthenticationDemo.Interface;
using AuthenticationDemo.Module;

namespace AuthenticationDemo.Repository
{
    public class StateRepository : IState
    {
        private readonly ApplicationDbContext _context;

        public StateRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddState(State state)
        {
            try
            {
                _context.states.Add(state);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteState(int Id)
        {
            try
            {
                var state = _context.states.Find(Id);
                _context.states.Remove(state);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<State> GetAllStates()
        {
            try
            {
               return _context.states.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public State GetStateById(int Id)
        {
            try
            {
                return _context.states.Find(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateState(State state)
        {
            try
            {
                _context.states.Update(state);
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
