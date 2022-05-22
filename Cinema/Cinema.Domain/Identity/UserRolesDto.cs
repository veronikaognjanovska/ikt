using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Identity
{
    public class UserRolesDto
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsSelected { get; set; }
    }
}
