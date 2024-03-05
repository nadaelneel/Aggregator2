using Deopartments.Application.Features.Query.GetAll;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Departments.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator mediator;

        public DepartmentController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var departments = await mediator.Send(new GetAllQuery());
            return Ok(departments);
        }
    }
}
