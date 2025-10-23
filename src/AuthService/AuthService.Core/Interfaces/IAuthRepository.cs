using AuthService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Core.Interfaces
{
    public interface IAuthRepository
    {
        Task<User?> GetByEmailAsync(string email);
        Task AddAsync(User user);
    }
}
