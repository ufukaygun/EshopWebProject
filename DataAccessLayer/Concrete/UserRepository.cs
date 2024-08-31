using DataAccessLayer.Abstract.BaseRepository;
using DataAccessLayer.Abstract.EntityRepository;
using DataAccessLayer.Context;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }
    }
}
