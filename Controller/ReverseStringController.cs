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
    public class ReverseStringController : ControllerBase
    {
        [HttpGet]
        //localhost:5000/api/ReverseString?word=Fernando
        public string ReverseWord(string word)
        {
            //Return the string in a reversed manner.
            return new string(word.ToArray().Reverse().ToArray());
        }
    }
}
