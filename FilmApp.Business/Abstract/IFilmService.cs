using FilmApp.Entities.Concrete;
using System.Collections.Generic;

namespace FilmApp.Business.Abstract
{
    public interface IFilmService
    {
        List<Film> GetAllMovies();
        List<Film> GetMoviesByTitle(string title);
        void AddMovie(Film film);
        void UpdateMovie(Film film);
        void DeleteMovie(Film film);
    }
}
