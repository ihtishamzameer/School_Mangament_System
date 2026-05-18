using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Student> Students { get; }
        DbSet<Teacher> Teachers { get; }
        DbSet<Classes> Classes { get; }
        DbSet<Subject> Subjects { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
