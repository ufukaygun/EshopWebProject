using EntityLayer.Entities;

namespace DataAccessLayer.Abstract.BaseRepository
{
    public interface IRepository<T> where T : class
    {
        //Burada metodları belirttik. GenericRepositoryde ise bu metodların içlerini doldurduk.
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetByID(int id);
        List<T> GetAll();
    }
}
