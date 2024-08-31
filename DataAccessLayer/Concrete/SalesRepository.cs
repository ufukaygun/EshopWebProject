using DataAccessLayer.Abstract.BaseRepository;
using DataAccessLayer.Abstract.EntityRepository;
using DataAccessLayer.Context;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class SalesRepository : GenericRepository<Sales>, ISalesRepository
    {
        public SalesRepository(DataContext context) : base(context)
        {
        }
    }
}
