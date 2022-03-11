using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixClone.Models
{
    public class Movie
    {
        public int page { get; set; }
        public List<MovieDetails> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }

        public Movie()
        {

        }
    }
}
