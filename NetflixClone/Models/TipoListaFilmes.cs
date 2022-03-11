using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixClone.Models
{
    public class TipoListaFilmes
    {
        public string Slug { get; set; }
        public string Title { get; set; }
        public Movie ListaFilmes { get; set; }
    }
}
