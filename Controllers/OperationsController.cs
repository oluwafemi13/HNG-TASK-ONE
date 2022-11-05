using HNGStage1Task.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HNGStage1Task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class OperationsController : ControllerBase
    {
        private static Operation op;
        private static TaskDescription description;




            [HttpPost("Operation")]
            [ProducesResponseType((int)HttpStatusCode.OK)]
            [ProducesResponseType((int)HttpStatusCode.NotFound)]
            public ActionResult<string> Operation([FromBody] Operation operation)
            {

            op = new Operation()
            {
                operations = OperationType.Addition,
                x = 5,
                y = 6,
                

            };
            
                string final = "";


            switch (operation.operations)
            {
                case OperationType.Addition:
                    op.result = op.x + op.y;
                    final = string.Join(" ",op.SlackUsername, op.result, OperationType.Addition);
                    return Ok(final);

                case OperationType.Subtraction:
                    op.result = op.x - op.y;
                    final = string.Join(" ", op.SlackUsername, op.result, OperationType.Addition);
                    return Ok(final);

                case OperationType.Multiplication:
                    op.result = op.x * op.y;
                    final = string.Join(" ", op.SlackUsername, op.result, OperationType.Addition);
                    return Ok(final);
                    default:
                    return NotFound();
            }
            


                return Ok(final);
            }
        }
    
}
