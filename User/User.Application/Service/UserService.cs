using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Infrastracture.Interface;
using User.Infrastracture.Reposatories;
using UserApp.Data;
using UserApp.Infrastracture.Context;

namespace UserApp.Application.Service
{
    public class UserService : UserItem.UserItemBase
    {
        #region fildes
        private readonly UserReposatory _Repo;
        private readonly IUniteOfWork uniteOfWork;

        #endregion
        #region constractor
        public UserService(UserReposatory repo , IUniteOfWork uniteOfWork)
        {
            _Repo = repo;
            this.uniteOfWork = uniteOfWork;
        }
        #endregion
        #region Methods
        //public override async Task<createUserResponse> createUser(createUserRequest request, ServerCallContext context)
        //{
        //    if (request.Name == string.Empty || request.DepartemntId ==0 )
        //        throw new RpcException(new Status(StatusCode.InvalidArgument, "You must suppply a valid object"));

        //    var User = new Users
        //    {
        //        Name = request.Name,
        //        DepartmentId = request.DepartemntId,
        //    };

        //    await _Repo.AddAsync(User);
        //    uniteOfWork.Commit();
        //    return await Task.FromResult(new createUserResponse
        //    {
        //        Id = User.Id
        //    });
        //}
        public override async Task<GetAllUserResponse> ListUser(GetAllUserRequest request, ServerCallContext context)
        {
            var response = new GetAllUserResponse();
            var Items = await _Repo.GetAllAsync();

            foreach (var item in Items)
            {
                response.Users.Add(new ReadUserResponse
                {
                    Id = item.Id,
                    Name = item.Name,
                    
                });
            }

            return await Task.FromResult(response);
        }

        //public override async Task<UpdateUserResponse> UpdateUser(UpdateUserRequest request, ServerCallContext context)
        //{
        //    if (request.Id <= 0 || request.Name == string.Empty  || request.DepartemntId ==0)
        //        throw new RpcException(new Status(StatusCode.InvalidArgument, "You must suppply a valid object"));

        //    var User = await _Repo.GetByIdAsync(request.Id);

        //    if (User == null)
        //        throw new RpcException(new Status(StatusCode.NotFound, $"No Task with Id {request.Id}"));

        //    User.Name = request.Name;
        //    User.DepartmentId = request.DepartemntId;
        //     uniteOfWork.Commit();

        //    return await Task.FromResult(new UpdateUserResponse
        //    {
        //        Id = User.Id
        //    });
        //}

        public override async Task<ReadUserResponse> ReadToDo(ReadUserRequest request, ServerCallContext context)
        {
            var response = new ReadUserResponse();
            var item =  await _Repo.GetByIdAsync(request.Id);
            response.Id = item.Id;
            response.Name = item.Name;
            return await Task.FromResult(response);
        }
        //public override async Task<DeleteUserResponse> DeleteUser(DeleteUserRequest request, ServerCallContext context)
        //{
        //    if (request.Id <= 0)
        //        throw new RpcException(new Status(StatusCode.InvalidArgument, "resouce index must be greater than 0"));

        //    var User = await _Repo.GetByIdAsync( request.Id);

        //    if (User == null)
        //        throw new RpcException(new Status(StatusCode.NotFound, $"No Task with Id {request.Id}"));

        //    await _Repo.DeleteAsync(User);

        //    uniteOfWork.Commit();

        //    return await Task.FromResult(new DeleteUserResponse
        //    {
        //        Id = User.Id
        //    });
        //}
        #endregion
    }
}
