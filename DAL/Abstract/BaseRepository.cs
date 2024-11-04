using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public class BaseRepository<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        protected SahafDBContext _dbContext;
        protected DbSet<TEntity> _tables;

        public BaseRepository()
        {
            _dbContext = new SahafDBContext();
            _tables = _dbContext.Set<TEntity>();

        }

        public void Add(TEntity entity)
        {
            _tables.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _tables.Remove(Find(id));
            _dbContext.SaveChanges();
        }

        public TEntity Find(int id)
        {
            return _tables.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _tables.ToList();
        }

        public void Update(TEntity entity)
        {
            _tables.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
