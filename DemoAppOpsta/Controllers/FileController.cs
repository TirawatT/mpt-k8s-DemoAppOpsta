using DemoAppOpsta.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoAppOpsta.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class FileController : ControllerBase
    {
        private readonly FileService _service;
        public FileController(FileService service)
        {
            _service = service;
        }

        [HttpGet, Route("ListFiles")]
        public IActionResult ListFiles(string path)
            => Ok(_service.ListFiles(path));
        [HttpGet, Route("ReadFile")]
        public IActionResult ReadFile(string path)
    => Ok(_service.ReadFile(path));

        [HttpPost, Route("WriteFile")]
        public IActionResult WriteFile(string path, string contents)
        {
            _service.WriteFile(path, contents);
            return Ok();
        }
    }
}
