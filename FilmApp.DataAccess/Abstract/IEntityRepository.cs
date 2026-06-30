using FilmApp.Entities.Abstract;
using FilmApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FilmApp.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        public List<T> LoadAll(Expression<Func<T, bool>> filter = null);
        public T LoadOne(Expression<Func<T, bool>> filter);
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
