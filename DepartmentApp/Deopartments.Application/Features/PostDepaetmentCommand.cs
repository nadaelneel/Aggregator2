using Azure.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deopartments.Application.Features
{
    public class PostDepaetmentCommand : IRequest
    {
        public string Name { get; set; }

    }
}
