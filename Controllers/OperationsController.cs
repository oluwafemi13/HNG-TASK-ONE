using HNGStage1Task.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HNGStage1Task.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class OperationsController : ControllerBase
    {
        private static Operation op;
        private static TaskDescription description;




            [HttpPost("Operation")]
            [ProducesResponseType((int)HttpStatusCode.OK)]
            [ProducesResponseType((int)HttpStatusCode.NotFound)]
            public string Operation([FromBody] Operation operation)
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
                    return final;

                case OperationType.Subtraction:
                    op.result = op.x - op.y;
                    final = string.Join(" ", op.SlackUsername, op.result, OperationType.Addition);
                    return final;

                case OperationType.Multiplication:
                    op.result = op.x * op.y;
                    final = string.Join(" ", op.SlackUsername, op.result, OperationType.Addition);
                    return final;
                    default:
                    throw new ArgumentOutOfRangeException();
            }
            


                //return final;
            }
        }
    
}
