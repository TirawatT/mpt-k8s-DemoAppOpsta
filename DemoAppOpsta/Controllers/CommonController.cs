using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoAppOpsta.Controllers
{
    [ApiController]
    [AllowAnonymous]

    [Route("api/[controller]")]
    public class CommonController(IConfiguration _config) : ControllerBase
    {
        #region root path first page
        [HttpGet, Route("/")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public ContentResult FirstPage()
        {
            var html = @"
<h1>DemoAppOpsta</h1>
<a href=""/swagger/"">go to Swagger</a>
";
            return new ContentResult
            {
                ContentType = "text/html",
                Content = html
            };
        }
        #endregion
        //[HttpGet, Route("checkdb")]
        //public IActionResult CheckDb() => Ok(_repo.Common.GetDbInfo());
        [HttpGet, Route("GetConfig")]
        public IActionResult GetConfig(string key = "MyConfig1") => Ok(_config.GetValue<string>(key));


    }
}
