using BusinessLayer.Abstract;
using DataAccessLayer.Abstract.EntityRepository;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(Product product)
        {
            _productRepository.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public void Delete(int id)
        {
            var delete = _productRepository.GetByID(id);
            _productRepository.Delete(delete);
        }

        public Product Get(int id)
        {
            return _productRepository.GetByID(id);
        }

        public Product Update(Product product)
        {
            _productRepository.Update(product);
            return _productRepository.GetByID(product.Id);
        }

    }
}
