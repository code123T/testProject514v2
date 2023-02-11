using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRS.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public TEntity AddItem(TEntity item);
        public List<TEntity> GetItem();
        public TEntity GetItemById(int id);
        public TEntity UpdateItem(TEntity item);
        public void DeleteItem(int id);

    }
}
