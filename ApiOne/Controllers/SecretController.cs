using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiOne.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class SecretController : Controller
    {
        [Route("/secret")]
        [Authorize]
        public string Index()
        {
            return "scret message from ApiOne";
        }
    }
}