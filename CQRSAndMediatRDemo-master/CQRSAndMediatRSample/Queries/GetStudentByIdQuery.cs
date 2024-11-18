using CQRSDomain.Models;
using MediatR;

namespace CQRSService.Features.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
