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
        DbSet<Attendance> Attendances { get; }
        DbSet<AuditLogs> auditLogs { get;   }
        DbSet<ClassSchedules> classSchedules { get;   }
        DbSet<DateSheets> dateSheets { get;   }
        DbSet<Exams> exams { get;   }
        DbSet<FeeTypes> FeeTypes { get;   }
        DbSet<FinanceTransactions> financeTransactions { get;   }
        DbSet<Marks> Marks { get;   }
        DbSet<Payments> Payments { get;   }
        DbSet<Roles> Roles { get;   }
        DbSet<StudentFees> StudentFees { get;   }
        DbSet<TeacherSalaries> TeacherSalaries { get;   }
        DbSet<TeacherSubjects> TeacherSubjects { get;   }
        DbSet<UserRoles> UserRoles { get;   }
        DbSet<Users> Users { get;   }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
