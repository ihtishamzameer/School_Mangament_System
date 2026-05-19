using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Domain.Entities
{
    // Stores student performance per subject per exam
    public class Marks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MarkId { get; set; }

        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }

        public double ObtainedMarks { get; set; }
        public double TotalMarks { get; set; }

        // Navigation Properties (FIXED)
        public Student? Student { get; set; }
        public Subject? Subject { get; set; }
        public Exams? Exam { get; set; }
    }
}