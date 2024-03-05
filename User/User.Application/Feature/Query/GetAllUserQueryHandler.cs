using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Infrastracture.Interface;
using User.Infrastracture.Reposatories;
using UserApp.Data;

namespace User.Application.Feature.Query
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, List<GetAllUserDots>>
    {
        //private readonly IManger<Users> manger;
        private readonly UserReposatory _userReposatory;
        private readonly IMapper mapper;

        public GetAllUserQueryHandler(UserReposatory userReposatory, IMapper mapper)
        {
            _userReposatory = userReposatory;
            this.mapper = mapper;
        }

        public async Task<List<GetAllUserDots>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users = await _userReposatory.GetAllAsync();

            var result = mapper.Map<List<GetAllUserDots>>(users);

            return result;
        }
    }
}
