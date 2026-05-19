using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    //Defines categories of fees.
    public class FeeTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeeTypeId { get; set; }
        public string Name { get; set; } = string.Empty; //tuition,transport,exam

        public ICollection<StudentFees> StudentFees { get; set; } = new List<StudentFees>();

    }
}
