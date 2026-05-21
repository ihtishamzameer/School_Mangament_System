using MediatR;
using SchoolManagementSystem.Application.Dto_s;

namespace SchoolManagementSystem.Application.Features.Auth.Queries
{

    public class GetMeQuery : IRequest<UserDto>
    {
    }
}
