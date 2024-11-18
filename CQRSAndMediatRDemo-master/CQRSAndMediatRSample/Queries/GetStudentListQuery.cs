using CQRSDomain.Models;
using MediatR;

namespace CQRSService.Features.Queries
{
    public class GetStudentListQuery :  IRequest<List<StudentDetails>>
    {
    }
}
