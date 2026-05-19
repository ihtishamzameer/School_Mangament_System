using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    //Exam schedule structure.
    public class DateSheets
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DateSheetId { get; set; }
        public int ExamId { get; set; }
        public int SubjectId { get; set; }
        public DateOnly ExamDate { get; set; }
        public TimeOnly StartTime { get; set; }

        public Exams Exam { get; set; } = new Exams();

        public int ClassId { get; set; }
        public Classes Class { get; set; } = new Classes();
    }
}
