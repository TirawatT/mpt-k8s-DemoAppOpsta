using Microsoft.AspNetCore.Mvc;

namespace DemoAppOpsta.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class WindowsAutenController : ControllerBase
    {
        /// <summary>
        /// Get Active Directory Authentication
        /// <para>run on IIS => return <domain>\<user></para>
        /// <para>Kestrel (Cross-platform)</para>
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetAccountId")]
        public IActionResult GetAccountId()
        {
            var res = new
            {
                IsAuthenticated = User?.Identity?.IsAuthenticated,
                Name = User?.Identity?.Name,
            };
            return Ok(res);
        }

    }
}
