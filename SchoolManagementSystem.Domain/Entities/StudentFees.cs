using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    //Represents fee obligation per student.
    public class StudentFees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentFeeId { get; set; }
        public int StudentId { get; set; }
        public int FeeTypeId { get; set; }
        public double TotalAmount { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; } //(Pending/Paid/Partial)

        public Student Student { get; set; } = new Student();

        public FeeTypes FeeType { get; set; } = new FeeTypes();

        public ICollection<Payments> Payments { get; set; } = new List<Payments>();
    }
}
