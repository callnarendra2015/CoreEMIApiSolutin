using CoreEMIApi.DAL.Interfaces;
using CoreEMIApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEMIApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        private readonly IRoleRepository _roles;
        public RoleController(IRoleRepository roles)
        {
            _roles = roles;
        }

        [HttpGet]
        // GET: api/Books
        public async Task<IActionResult> GetAllRoles()
        {
            return Ok(await _roles.GetAllRolesAsync());
        }

        [HttpGet]
        [Route("{id}")]
        // GET: api/Books/1
        public async Task<IActionResult> GetRoleById(int id)
        {
            if (id == 0)
            {
                return BadRequest("invalid Entry");
            }
            return Ok(await _roles.GetRoleByIdAsync(id));
        }

        [HttpPost]
        ///api/books
        public async Task<IActionResult> CreateRole([FromBody] Role role)
        {
            if (role == null)
            {
                return BadRequest("invalid Entry");
            }

            return Ok(await _roles.CreateRoleAsync(role));
        }

        // GET: api/GetRoleDetails
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Role>>> GetRoleDetails()
        //{
        //    var data = _context.Roles.ToList();
        //    return data;
        //}
        //[HttpGet]
        //public async Task<Role> GetRoleDetails()
        //{
        //    var role = _context.Roles.ToList();
        //    //var role = await _context.GetRolesAsync(user);
        //    //return data;

        //}
    }
}
