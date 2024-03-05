

using AutoMapper;
using Departments.Infrastracture.Reposatories;
using MediatR;

namespace Deopartments.Application.Features.Query
{
    public class GetOneQueryHandler : IRequestHandler<GetOneQuery, DepertmentDto>
    {
        private readonly DepartmentReposatory _departmentReposatory;
        private readonly IMapper _mapper;

        public GetOneQueryHandler(DepartmentReposatory departmentReposatory , IMapper mapper)
        {
            _departmentReposatory = departmentReposatory;
            _mapper = mapper;
        }
        public Task<DepertmentDto> Handle(GetOneQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
