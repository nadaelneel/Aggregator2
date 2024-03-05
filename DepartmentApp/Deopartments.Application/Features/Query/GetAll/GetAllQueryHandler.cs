using AutoMapper;
using Departments.Infrastracture.Reposatories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deopartments.Application.Features.Query.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQuery, List<DepertmentDto>>
    {
        private readonly DepartmentReposatory _reposatory;
        private readonly IMapper _mapper;
         public GetAllQueryHandler(DepartmentReposatory reposatory, IMapper mapper)
        {
            _reposatory = reposatory;
            _mapper = mapper;
        }

        public async Task<List<DepertmentDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
           // var department = await _reposatory.GetAllAsync();
            var department =  _reposatory.GetAll().ToList();
            return _mapper.Map<List<DepertmentDto>>(department);
        }
    }
}
