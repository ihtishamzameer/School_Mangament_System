using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Application.Dto_s;
using SchoolManagementSystem.Application.Features.Auth.Queries;
using SchoolManagementSystem.Application.Interfaces;
using System.Security.Claims;


namespace SchoolManagementSystem.Application.Features.Auth.Handlers
{
    public class GetMeHandler : IRequestHandler<GetMeQuery, UserDto>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IApplicationDbContext _applicationDbContext;

        public GetMeHandler(IHttpContextAccessor httpContextAccessor,IApplicationDbContext applicationDbContext)
        {
            _httpContextAccessor = httpContextAccessor;
            this._applicationDbContext = applicationDbContext;
        }

        public async Task<UserDto> Handle(GetMeQuery request, CancellationToken cancellationToken)
        {
            var userId = _httpContextAccessor.HttpContext?
                .User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var user = await _applicationDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == int.Parse(userId!), cancellationToken);

            return new UserDto
            {
                Id = user!.Id,
                Username = user.Username
            };
        }
    }
}
