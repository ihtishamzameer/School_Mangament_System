using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    //Payroll tracking for teachers.
    public class TeacherSalaries
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalaryId { get; set; }
        public int TeacherId { get; set; }

        public int Month { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; } //(Paid/Pending)


        public Teacher Teacher { get; set; } = new Teacher();

        public DateTime PaidOn { get; set; }
    }
}
