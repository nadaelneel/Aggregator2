using Deopartments.Application.Features.Query.GetAll;
using Grpc.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deopartments.Application.Service
{
    public class DepartmentsService : DepartmentItem.DepartmentItemBase
    {
        private readonly IMediator _mediator;

        public DepartmentsService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public override async Task<GetAllDepartmentResponse> ListDepartment(GetAllDepartmentRequest request, ServerCallContext context)
        {
            var response = new GetAllDepartmentResponse();

            var departments =  await _mediator.Send(new GetAllQuery());

            foreach(var department in departments)
            {
                response.Departments.Add(new ReadDepartmentResponse()
                {
                    Id = department.Id,
                    Name = department.Name,
                });
            }
            return response;
        }
    }
}
