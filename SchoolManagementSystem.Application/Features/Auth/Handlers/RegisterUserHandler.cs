using BCrypt.Net;
using MediatR;
using SchoolManagementSystem.Application.Features.Auth.Commands;
using SchoolManagementSystem.Application.Interfaces;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Application.Features.Auth.Handlers
{

    public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public RegisterUserHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Users
            {
                Username = request.Username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password)
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync(cancellationToken);

            return user.Id;
        }
    }
}
