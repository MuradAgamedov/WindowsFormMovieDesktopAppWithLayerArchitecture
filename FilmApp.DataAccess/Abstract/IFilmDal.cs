using FilmApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApp.DataAccess.Abstract
{
    public interface IFilmDal : IEntityRepository<Film>
    {


    }
}
