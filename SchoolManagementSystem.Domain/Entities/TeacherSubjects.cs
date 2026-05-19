using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace SchoolManagementSystem.Domain.Entities
{
    // Mapping: Teacher teaches Subject in a Class
    public class TeacherSubjects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int TeacherId { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }

        // Navigation Properties (FIXED)
        public Teacher? Teacher { get; set; }
        public Classes? Class { get; set; }
        public Subject? Subject { get; set; }
    }
}