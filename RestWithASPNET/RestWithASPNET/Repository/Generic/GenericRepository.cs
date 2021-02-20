using Microsoft.EntityFrameworkCore;
using RestWithASPNET.Model.Base;
using RestWithASPNET.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNET.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MySQLContext _context;
        private DbSet<T> dataset;

        public GenericRepository(MySQLContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindByID(long id)
        {
            return dataset.SingleOrDefault(x => x.Id.Equals(id));
        }

        public T Create(T entity)
        {
            try
            {
                dataset.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

            return entity;
        }

        public T Update(T entity)
        {
            var result = FindByID(entity.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(entity).CurrentValues.SetValues(entity);
                    _context.SaveChanges();
                    return entity;
                }
                catch (Exception)
                {
                    throw;
                }
            } else
            {
                return null;
            }
        }

        public void Delete(long id)
        {
            var result = FindByID(id);
            if (result != null)
            {
                dataset.Remove(result);
                _context.SaveChanges();
            }
        }
        public bool Exists(long id)
        {
            return dataset.Any(p => p.Id.Equals(id));
        }
    }
}
