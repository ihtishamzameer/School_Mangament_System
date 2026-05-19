using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    //Defines exam events per class.
    public class Exams
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamId { get; set; }

        public int ClassId { get; set; }

        public string Title { get; set; } = string.Empty;

        public DateTime ExamDate { get; set; }

        public ICollection<Marks> Marks { get; set; } = new List<Marks>();
        public ICollection<DateSheets> DateSheets { get; set; } = new List<DateSheets>();
    }
}
