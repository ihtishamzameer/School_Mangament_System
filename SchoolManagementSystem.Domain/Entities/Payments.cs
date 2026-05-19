using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    //Allows partial/full payments tracking.
    public class Payments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }
        public int StudentFeeId { get; set; }
        public double PaidAmount { get; set; }
        public DateOnly PaymentDate { get; set; }
        public string Method { get; set; } //(Cash/Bank/EasyPaisa)


        public StudentFees StudentFee { get; set; } = new StudentFees();

        public decimal Amount { get; set; }
        public DateTime PaidOn { get; set; }
    }
}
