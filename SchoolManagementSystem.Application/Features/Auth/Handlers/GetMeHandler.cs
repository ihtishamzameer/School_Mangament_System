using MediatR;
using Microsoft.AspNetCore.Http;
using SchoolManagementSystem.Application.Features.Auth.Queries;
using System.Security.Claims;


namespace SchoolManagementSystem.Application.Features.Auth.Handlers
{
    public class GetMeHandler : IRequestHandler<GetMeQuery, object>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetMeHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Task<object> Handle(GetMeQuery request, CancellationToken cancellationToken)
        {
            var user = _httpContextAccessor.HttpContext!.User;

            var result = new
            {
                Id = user.FindFirst(ClaimTypes.NameIdentifier)?.Value,
                Username = user.Identity?.Name,
                Roles = user.FindAll(ClaimTypes.Role).Select(r => r.Value)
            };

            return Task.FromResult<object>(result);
        }
    }
}
