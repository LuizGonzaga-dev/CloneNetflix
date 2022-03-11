using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixClone.API
{
    public class RequisicaoAPI
    {
        public const string API_KEY = "951a448ab9836ab78c768c6a46042d43";

        public const string API_BASE = "https://api.themoviedb.org/3";

        public RequisicaoAPI()
        {
           
        }

        public async Task<int> GetAllInformations(string endPoint)
        {
            var client = new RestClient(API_BASE + endPoint);

            client.Timeout = -1;

            var request = new RestRequest(Method.GET);

            var response = await client.ExecuteAsync(request);

            return 1;

        }
    }
}
