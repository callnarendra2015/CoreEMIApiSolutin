using CoreEMIApi.DAL.Interfaces;
using CoreEMIApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEMIApi.DAL.Repositories
{
    public class RoleRepository
    {
        private readonly IRoleRepository _ctx;
        public RoleRepository(IRoleRepository ctx)
        {
            _ctx = ctx;
        }

        //public async Task<Role> CreateRoleAsync(Role book)
        //{
        //    //_ctx.Roles.Add(book);
        //    //await _ctx.SaveChangesAsync();
        //    return book;
        // }

        //public async Task<List<Role>> GetAllRolesAsync()
        //{
        //    //return await _ctx.GetAllRolesAsync.ToListAsync();
        //}

        //public async Task<Role> GetRoleByIdAsync(int id)
        //{
        //    //return await _ctx.Roles.FirstOrDefaultAsync(role => role.RoleId== id);
        //}
    }
}
