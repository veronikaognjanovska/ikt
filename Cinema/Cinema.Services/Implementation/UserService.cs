using Cinema.Domain.identity;
using Cinema.Repository.Interface;
using Cinema.Services.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserService> _logger;
        public UserService(ILogger<UserService> logger, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _logger = logger;
        }


        public List<ApplicationUser> GetAllUsers()
        {
            _logger.LogInformation("GetAllUsers was called!");
            return this._userRepository.GetAll().ToList();
        }
    }
}
