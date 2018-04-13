using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace exp_web.Controllers
{
    public class Home : Controller
    {
        
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public string Index()
        {
            return "home";
        }

        
        [Route("Home/Welcome")]
        [Route("Home/Welcome/{name}/{numTimes=1}")]
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        
        public async Task<string> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound().ToString();
            }
            
            return HtmlEncoder.Default.Encode($"Hello {id}");
        }
        
        public IActionResult Show()
        {
            return View();
        }
    }
}