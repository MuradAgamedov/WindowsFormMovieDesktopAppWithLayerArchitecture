using FilmApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApp.Entities.Concrete
{
    public class Film : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public int Raiting { get; set; }

    }
}
