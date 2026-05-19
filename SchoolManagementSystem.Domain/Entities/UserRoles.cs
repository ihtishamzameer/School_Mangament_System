using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    //A user can potentially have multiple roles (e.g., Admin + Teacher in MVP systems).
    public class UserRoles
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public Users User { get; set; }
        public Roles Role { get; set; }
    }
}
