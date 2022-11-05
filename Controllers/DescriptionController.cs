using HNGStage1Task;
using HNGStage1Task.Model;
using Microsoft.AspNetCore.Mvc;

namespace HNGStage1Task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DescriptionController : ControllerBase
    {
        private static TaskDescription desc = new TaskDescription();





        [HttpGet(Name = "GetDescription")]
        public IActionResult Get()
        {
            return Ok(desc);
        }


    }
}