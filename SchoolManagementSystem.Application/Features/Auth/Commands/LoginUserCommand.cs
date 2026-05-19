using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Application.Features.Auth.Commands
{
    using MediatR;

    public class LoginUserCommand : IRequest<string>
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
