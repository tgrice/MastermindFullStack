using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MM.Core;

namespace MM.WebApi.Controllers
{
    public class GameController : ApiController
    {
        // GET api/game/5
        public string Get(int id)
        {
            var codeGen = new CodeGenerator(); // or whatever

            var guess = Request.GetQueryNameValuePairs().First(nvp => nvp.Key == "guess");
            return "BBBB";
        }

    }
}
