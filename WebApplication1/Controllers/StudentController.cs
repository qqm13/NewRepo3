using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMediator.Types;
using System.Threading.Tasks;
using WebApplication1.CQRS.CommandList;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly Mediator mediator;
        public StudentController(MyMediator.Types.Mediator mediator)
        {
        this.mediator = mediator;
        }

        

        [HttpGet("GetStudentsByGroup")]
        public async Task<IEnumerable<StudentDTO>> StudentsByGroup(int index)
        {
            var command = new GetStudentByGroupCommand { Index = index};

            var result = await mediator.SendAsync(command);

            return result;
        }
    }
}
