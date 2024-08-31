using BusinessLayer.Abstract;
using DataAccessLayer.Abstract.EntityRepository;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }

        public void Create(Category category)
        {
            _categoryRepository.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public void Delete(int id)
        {
            var delete = _categoryRepository.GetByID(id);
            _categoryRepository.Delete(delete);
        }

        public Category Get(int id)
        {
           return _categoryRepository.GetByID(id);
        }

        public Category Update(Category category)
        {
            _categoryRepository.Update(category);
            return _categoryRepository.GetByID(category.Id);
        }

       
    }
}
