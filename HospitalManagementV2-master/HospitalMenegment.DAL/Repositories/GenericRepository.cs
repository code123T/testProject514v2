using BookRS.DAL.Interfaces;
using HospitalManagement.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRS.DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _dbContext;
        private readonly DbSet<TEntity> _entities;
        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<TEntity>();
        }
        public TEntity AddItem(TEntity item)
        {
            _entities.Add(item);
            _dbContext.SaveChanges();
            return item;
        }

        public void DeleteItem(int id)
        {
            var dbItem = _entities.Find(id);
            _entities.Remove(dbItem);
            _dbContext.SaveChanges();
        }

        public TEntity GetItemById(int id)
        {
            var dbItem = _entities.Find(id);
            return dbItem;
        }

        public List<TEntity> GetItem()
        {
            var dbItem = _entities.ToList();
            return dbItem;
        }

        public TEntity UpdateItem(TEntity item)
        {
            _entities.Update(item);
            _dbContext.SaveChanges();
            return item;
        }
    }
}
