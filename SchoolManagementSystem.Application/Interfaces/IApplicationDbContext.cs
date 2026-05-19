using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        // =========================
        // CORE SCHOOL MODULE
        // =========================
        DbSet<Student> Students { get; }
        DbSet<Teacher> Teachers { get; }
        DbSet<Class> Classes { get; }
        DbSet<Subject> Subjects { get; }

        // =========================
        // AUTH MODULE (BASIC)
        // =========================
        DbSet<Users> Users { get; }
        DbSet<Roles> Roles { get; }
        DbSet<UserRoles> UserRoles { get; }

        // =========================
        // SAVE
        // =========================
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}