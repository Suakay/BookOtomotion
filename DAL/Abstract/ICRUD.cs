using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface ICRUD<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Find(int id);
    }
}
