using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet]
        public string Explode(string sample)
        {
            return string.Join("", sample.Select(exploded => new string(exploded, int.Parse(exploded.ToString()))));

        }

    }
}
