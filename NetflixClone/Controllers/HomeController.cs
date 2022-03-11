using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetflixClone.Models;
using NetflixClone.ViewModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace NetflixClone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public const string API_BASE = "https://api.themoviedb.org/3";
        public async Task<Movie> GetAllInformations(string endPoint)
        {
            var client = new RestClient(API_BASE + endPoint);

            client.Timeout = -1;

            var request = new RestRequest(Method.GET);

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var movie = JsonConvert.DeserializeObject<Movie>(response.Content);
                
                return movie;
            }

            return new Movie();
        }

        public const string API_KEY = "951a448ab9836ab78c768c6a46042d43";
        public async Task<IActionResult> Index()
        {
            var jesusCristo = new List<TipoListaFilmes>();

            jesusCristo.Add(new TipoListaFilmes {
                Slug = "originals",
                Title = "Originais do Netflix",
                ListaFilmes = await GetAllInformations("/discover/tv?with_network=213&language=pt-BR&api_key=" + API_KEY)
            });

            jesusCristo.Add(new TipoListaFilmes
            {
                Slug = "trending",
                Title = "Recomendados para você",
                ListaFilmes = await GetAllInformations("/trending/all/week?language=pt-BR&api_key=" + API_KEY)
            });

            jesusCristo.Add(new TipoListaFilmes
            {
                Slug = "toprated",
                Title = "Em alta",
                ListaFilmes = await GetAllInformations("/movie/top_rated?language=pt-BR&api_key=" + API_KEY)
            });

            jesusCristo.Add(new TipoListaFilmes
            {
                Slug = "action",
                Title = "Ação",
                ListaFilmes = await GetAllInformations("/discover/movie?with_genres=28&language=pt-BR&api_key=" + API_KEY)
            });

            jesusCristo.Add(new TipoListaFilmes
            {
                Slug = "comedy",
                Title = "Comédia",
                ListaFilmes = await GetAllInformations("/discover/movie?with_genres=35&language=pt-BR&api_key=" + API_KEY)
            });

            jesusCristo.Add(new TipoListaFilmes
            {
                Slug = "horror",
                Title = "Terror",
                ListaFilmes = await GetAllInformations("/discover/movie?with_genres=27&language=pt-BR&api_key=" + API_KEY)
            });

            jesusCristo.Add(new TipoListaFilmes
            {
                Slug = "romance",
                Title = "Romance",
                ListaFilmes = await GetAllInformations("/discover/movie?with_genres=10749&language=pt-BR&api_key=" + API_KEY)
            });

            jesusCristo.Add(new TipoListaFilmes
            {
                Slug = "documentary",
                Title = "Documentários",
                ListaFilmes = await GetAllInformations("/discover/movie?with_genres=99&language=pt-BR&api_key=" + API_KEY)
            });

            var vm = new HomeViewModel(jesusCristo);

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
