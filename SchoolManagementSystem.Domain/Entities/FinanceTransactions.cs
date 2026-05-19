using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    //Tracks all money movement (fees, salaries, expenses).
    public class FinanceTransactions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        public string Type { get; set; } //(Income/Expense)
        public double Amount { get; set; }
        public string Description { get; set; }
        public DateOnly Date { get; set; }
        public int RelatedPaymentId { get; set; } //(nullable FK → Payments)
    }
}
