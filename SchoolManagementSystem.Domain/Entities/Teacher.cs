using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    //Same pattern as Students—role specialization of Users.
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        public int UserId { get; set; }
        public string Department { get; set; } = string.Empty;
        public DateOnly JoiningDate { get; set; }

        public ICollection<TeacherSubjects> TeacherSubjects { get; set; } = new List<TeacherSubjects>();
        public ICollection<ClassSchedules> ClassSchedules { get; set; } = new List<ClassSchedules>();
        public ICollection<TeacherSalaries> TeacherSalaries { get; set; } = new List<TeacherSalaries>();

    }
}
