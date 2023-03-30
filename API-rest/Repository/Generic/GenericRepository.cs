using API_rest.Model;
using API_rest.Model.Base;
using API_rest.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_rest.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySqlContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(MySqlContext mySqlContext)
        {
            _context = mySqlContext;
            _dbSet = _context.Set<T>();
        }

        public List<T> FindAll()
        {
            return _dbSet.ToList();

        }

        public T FindByID(long id)
        {
            return _dbSet.SingleOrDefault(p => p.Id.Equals(id));
        }

        public T Create(T item)
        {
            try
            {
                _dbSet.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T Update(T item)
        {
            var result = _dbSet.SingleOrDefault(p => p.Id.Equals(item.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                return null;
            }
        }

        public void Delete(long id)
        {
            var result = _dbSet.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _dbSet.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _dbSet.Any(p => p.Id.Equals(id));
        }
    }
}
