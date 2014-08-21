using System.Linq;
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
            var fb = new Feedback();
            var guess = Request.GetQueryNameValuePairs().First(nvp => nvp.Key == "guess");
            var code = Request.GetQueryNameValuePairs().First(nvp => nvp.Key == "code");
            var feedbackString = fb.getFeedback(guess.Value, code.Value);
            return feedbackString;
            //return "BBBB";
        }
    }
}
