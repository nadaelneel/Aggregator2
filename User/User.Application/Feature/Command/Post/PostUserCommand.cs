using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Application.Feature.Command.Post
{
    public class PostUserCommand : IRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }


    }
}
