using Deopartments.Application.Features.Query.GetAll;
using Departments.Data;
using Departments.Infrastracture.Interfaces;
using Departments.Infrastracture.Reposatories;
using Grpc.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deopartments.Application.Service
{
    public class DepartmentService : DepartmentItem.DepartmentItemBase
    {
        #region fildes
        private readonly DepartmentReposatory _Repo;
        private readonly IMediator _mediator;
        private readonly IUniteOfWork uniteOfWork;
        
        #endregion
        #region constractor
        public DepartmentService(
            DepartmentReposatory repo, 
            IUniteOfWork uniteOfWork,
            IMediator mediator
            )
        {
            _Repo = repo;
            this.uniteOfWork = uniteOfWork;
            this._mediator = mediator;
           
        }
        #endregion
        #region Methods
        public override async Task<GetAllDepartmentResponse> ListDepartment(GetAllDepartmentRequest request, ServerCallContext context)
        {
            var response = new GetAllDepartmentResponse();
            //var Items =  await _Repo.GetAllAsync();
            var Items =await  _mediator.Send(new GetAllQuery());

            foreach (var item in Items)
            {
                response.Departments.Add(new ReadDepartmentResponse
                {
                    Id = item.Id,
                    Name = item.Name,

                });
            }

            return await Task.FromResult(response);
        }
        public override async Task<ReadDepartmentResponse> ReadToDo(ReadDepartmentRequest request, ServerCallContext context)
        {
            var response = new ReadDepartmentResponse();
            var item = await _Repo.GetByIdAsync(request.Id);
            response.Id = item.Id;
            response.Name = item.Name;
            return await Task.FromResult(response);
        }
       
        #endregion
    }
}
