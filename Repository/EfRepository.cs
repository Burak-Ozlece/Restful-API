using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YoutubeWebApi.Data;

namespace YoutubeWebApi.Repository
{
    public class EfRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<T> _dbSet;

        public EfRepository(DatabaseContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public T Add(T entity)
        {
            var result = new T();
            _dbSet.Add(entity);
            _context.SaveChanges();
            result = entity;
            return result;
        }

        public T Delete(T entity)
        {
            var result = new T();
            _dbSet.Remove(entity);
            _context.SaveChanges();
            result = entity;
            return result;
        }

        public List<T> GetAll()
        {
            var result = new List<T>();
            var list = _dbSet.ToList();
            if(list != null)
            {
                result = list;
            }else{
                result = null;
            }
            return result;
        }

        public T GetById(int Id)
        {
            var result = new T();
            result = _dbSet.Find(Id);
            return result;
        }

        public T UpdateById(T entity, int Id)
        {
            var result = new T();
            var model = GetById(Id);

            if(model == null)
            {
                return null;
            }
            _context.Entry(model).CurrentValues.SetValues(entity);
            _context.SaveChanges();
            result = model;
            return result;
        }
    }
}