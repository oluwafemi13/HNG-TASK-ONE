using HNGStage1Task.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HNGStage1Task.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    [Produces("application/json")]
    public class OperationsController : ControllerBase
    {
        private static Operation op;
        private static TaskDescription description;




            [HttpPost("{operation}")]
            //[HttpPost("[action]/{x}/{y}/{operation}")]
            [ProducesResponseType((int)HttpStatusCode.OK)]
            [ProducesResponseType((int)HttpStatusCode.NotFound)]
            public IActionResult Operation([FromBody] string operation)
            {
                
            
                int result = 0;
                int x = 5;
                int y = 6;
                
                if (operation is null)
                {
                      return NotFound();

                }
                else if (operation == "Addition".ToLower())
                {
                     result = x + y;
                     string final = string.Join(',', description.SlackUsername, result,OperationType.Addition);

                    return Ok(final);
                }
                else if (operation == "Subtraction".ToLower())
                {
                result = x - y;
                string final = string.Join(',', description.SlackUsername, result, OperationType.Subtraction);

                return Ok(final);
                }
                else if (operation == "Multiplication".ToLower())
                {
                result = x * y;
                string final = string.Join(',', description.SlackUsername, result, OperationType.Addition);

                return Ok(final);
                }

                return Ok(operation);



            }
        }
    
}
