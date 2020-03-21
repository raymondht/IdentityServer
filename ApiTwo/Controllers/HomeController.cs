using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTwo.Controllers
{
    public class HomeController : Controller
    {
        public IHttpClientFactory _httpClientFactory { get; }

     

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            // retrieve access token

            // retrieve secret data

            return Ok(new
            {

            })
        }
    }
}
