using FilmApp.Entities.Concrete;
using FilmApp.DataAccess.Abstract;
using FilmApp.Business.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace FilmApp.Business.Concrete
{
    public class FilmManager : IFilmService
    {
        private readonly IFilmDal _filmDal;

        public FilmManager(IFilmDal filmDal)
        {
            _filmDal = filmDal;
        }

        public List<Film> GetAllMovies()
        {
            return _filmDal.LoadAll();
        }

        public List<Film> GetMoviesByTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return _filmDal.LoadAll();

            return _filmDal.LoadAll(f => f.Title.ToLower().Contains(title.ToLower()));
        }

        public void AddMovie(Film film)
        {
            _filmDal.Add(film);
        }

        public void UpdateMovie(Film film)
        {
            _filmDal.Update(film);
        }

        public void DeleteMovie(Film film)
        {
            _filmDal.Delete(film);
        }
    }
}
