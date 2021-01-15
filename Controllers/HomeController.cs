using System; 
using System.Collections.Generic; 
using System.IO; 

using Microsoft.AspNetCore.Mvc; 

namespace api.Controllers
{ 
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    { 
        public IActionResult Index() 
        { 
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/html"); 
        }
    }
}