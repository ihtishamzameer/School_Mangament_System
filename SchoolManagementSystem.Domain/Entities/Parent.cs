using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    public class Parent
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
