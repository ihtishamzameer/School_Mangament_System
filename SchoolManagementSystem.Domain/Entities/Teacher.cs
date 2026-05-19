using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    //Same pattern as Students—role specialization of Users.
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
