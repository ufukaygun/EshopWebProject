using DataAccessLayer.Abstract.BaseRepository;
using DataAccessLayer.Abstract.EntityRepository;
using DataAccessLayer.Context;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        // DataContext'i CategoryRepository'ye enjekte eden constructor

        // Özel metodlar burada tanımlanabilir
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
 