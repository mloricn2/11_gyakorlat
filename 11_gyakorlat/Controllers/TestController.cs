using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _11_gyakorlat.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("corvinus/szerverido")]
        public IActionResult M1()
        {
            string pontosIdő = DateTime.Now.ToShortTimeString();
            return(Ok(pontosIdő));

            return new ContentResult
            {
                ContentType = System.Net.Mime.MediaTypeNames.Text.Plain, //"text/plain"
                Content = pontosIdő
            };
        }
    }
}
