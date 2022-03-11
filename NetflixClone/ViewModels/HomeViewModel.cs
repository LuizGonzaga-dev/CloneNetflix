using NetflixClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixClone.ViewModels
{
    public class HomeViewModel
    {
        public List<TipoListaFilmes> AllMoviesAndCategories { get; set; }
        public HomeViewModel(List<TipoListaFilmes> allMoviesAndCategories)
        {
            AllMoviesAndCategories = allMoviesAndCategories;
        }
    }
}
