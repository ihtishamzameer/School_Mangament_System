using System;
using System.Collections.Generic;
using BCrypt.Net;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Api.JWT;
using SchoolManagementSystem.Application.Features.Auth.Commands;
using SchoolManagementSystem.Application.Interfaces;
namespace SchoolManagementSystem.Application.Features.Auth.Handlers
{

    public class LoginUserHandler : IRequestHandler<LoginUserCommand, string>
    {
        private readonly IApplicationDbContext _context;
        private readonly JwtTokenService _tokenService;

        public LoginUserHandler(IApplicationDbContext context, JwtTokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var username = request.Username.Trim().ToLower();

            var user = await _context.Users
                .FirstOrDefaultAsync(x => x.Username.ToLower() == username, cancellationToken);

            if (user == null)
                throw new Exception("Invalid username or password");

            var password = request.Password.Trim();

            var isValid = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);

            if (!isValid)
                throw new Exception("Invalid username or password");

            var token = _tokenService.GenerateToken(user, new List<string>());

            return token;
        }
    }
}
