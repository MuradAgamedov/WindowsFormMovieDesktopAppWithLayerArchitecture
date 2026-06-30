using FilmApp.DataAccess.Abstract;
using FilmApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FilmApp.DataAccess.Concrete.Nhibernate
{
    public class NFilmDal : IFilmDal
    {
        public void Add(Film entity)
        {
            throw new NotImplementedException();
        }

     

        public void Delete(Film entity)
        {
            throw new NotImplementedException();
        }

      

        public List<Film> LoadAll(Expression<Func<Film, bool>> filter = null)
        {
            List<Film> filmler = new List<Film> {

                new Film { Id = 1, Title = "The Shawshank Redemption", Year = 1994, Duration = 142, Raiting = 9 },
            };
            return filmler;
        }

        

        public Film LoadOne(Expression<Func<Film, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Film entity)
        {
            throw new NotImplementedException();
        }

     
    }
}
