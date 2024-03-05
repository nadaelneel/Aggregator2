using MediatR;


namespace Deopartments.Application.Features.Query
{
    public class GetOneQuery : IRequest<DepertmentDto>
    {
        public int Id { get; set; }
    }
}
