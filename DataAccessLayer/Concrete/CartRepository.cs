using DataAccessLayer.Abstract.BaseRepository;
using DataAccessLayer.Abstract.EntityRepository;
using DataAccessLayer.Context;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(DataContext context) : base(context)
        {
        }
    }
}
