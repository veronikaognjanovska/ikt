﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Identity
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
    }
}
