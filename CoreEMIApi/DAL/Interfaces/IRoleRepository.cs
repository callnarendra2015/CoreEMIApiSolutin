using CoreEMIApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEMIApi.DAL.Interfaces
{
    public interface IRoleRepository
    {
        Task<List<Role>> GetAllRolesAsync();

        Task<Role> GetRoleByIdAsync(int id);

        Task<Role> CreateRoleAsync(Role role);

        //Task<Role> UpdateRoleAsync(Role role);

    }
}
