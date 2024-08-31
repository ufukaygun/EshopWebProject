using BusinessLayer.Concrete;
using DataAccessLayer.Abstract.BaseRepository;
using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        Category Get(int id);
        List<Category> GetAll();
        void Create(Category category);
        void Delete(int id);
        Category Update(Category category);

    }
}
