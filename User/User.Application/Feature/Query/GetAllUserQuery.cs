using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Application.Feature.Query
{
    public class GetAllUserQuery : IRequest<List<GetAllUserDots>>
    {
    }
}
