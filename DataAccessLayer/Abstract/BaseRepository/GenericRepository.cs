﻿using DataAccessLayer.Context;
using EntityLayer.Entities;

namespace DataAccessLayer.Abstract.BaseRepository
{
    //Repository Design Pattren kullanıldı.CRUD işlemlerini tekrar etmememi ve Generic bir yapı üzerinde tutmamı sağlayacak
    // Repository Design Pattern kullanıldı. CRUD işlemlerini tekrar etmememi ve Generic bir yapı üzerinde tutmamı sağlayacak
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;

        // Constructor
        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
			_context.Update(entity);
			_context.SaveChanges();
		}
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        
    }
}
