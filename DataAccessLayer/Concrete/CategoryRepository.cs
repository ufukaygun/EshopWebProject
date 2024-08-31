using DataAccessLayer.Abstract.BaseRepository;
using DataAccessLayer.Abstract.EntityRepository;
using DataAccessLayer.Context;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class CategoryRepository : GenericRepository<Category>,ICategoryRepository
    {
        // DataContext'i CategoryRepository'ye enjekte eden constructor

        // Özel metodlar burada tanımlanabilir

        private DataContext _context;
        public CategoryRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        
    }
}
