using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Application.Interfaces;
using SchoolManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        public DbSet<Student> Students => Set<Student>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
        public DbSet<Classes> Classes => Set<Classes>();
        public DbSet<Subject> Subjects => Set<Subject>();
        public DbSet<Attendance> Attendances => Set<Attendance>();
        public DbSet<AuditLogs> auditLogs => Set<AuditLogs>();
        public DbSet<ClassSchedules> classSchedules => Set<ClassSchedules>();
        public DbSet<DateSheets> dateSheets => Set<DateSheets>();
        public DbSet<Exams> exams => Set<Exams>();
        public DbSet<FeeTypes> FeeTypes => Set<FeeTypes>();
        public DbSet<FinanceTransactions> financeTransactions => Set<FinanceTransactions>();
        public DbSet<Marks> Marks => Set<Marks>();
        public DbSet<Payments> Payments => Set<Payments>();
        public DbSet<Roles> Roles => Set<Roles>();
        public DbSet<StudentFees> StudentFees => Set<StudentFees>();
        public DbSet<TeacherSalaries> TeacherSalaries => Set<TeacherSalaries>();
        public DbSet<TeacherSubjects> TeacherSubjects => Set<TeacherSubjects>();
        public DbSet<UserRoles> UserRoles => Set<UserRoles>();
        public DbSet<Users> Users => Set<Users>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRoles>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
