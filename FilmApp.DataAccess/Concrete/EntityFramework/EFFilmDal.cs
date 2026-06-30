using FilmApp.DataAccess.Abstract;
using FilmApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FilmApp.DataAccess.Concrete.EntityFramework
{
    public class EFFilmDal : EFEntityRepositoryBase<Film, FilmAppContext>, IFilmDal
    {
       
    }
}
