using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        Product Get(int id);
        List<Product> GetAll();
        void Create(Product product);
        void Delete(int id);
        Product Update(Product product);
    }
}
