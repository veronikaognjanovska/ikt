using Cinema.Domain.identity;
using Cinema.Repository.Implementation;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Services.Interface
{
    public interface IUserService
    {
        public List<ApplicationUser> GetAllUsers();
    }
}
