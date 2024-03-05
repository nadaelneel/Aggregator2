using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.Application.Feature.Command.Post;
using User.Application.Feature.Query;

namespace User.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<ActionResult<List<GetAllUserDots>>> GetAll()
        {
            var Users = await mediator.Send(new GetAllUserQuery());
            return Ok(Users);
        }
     
    }
    }
