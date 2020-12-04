using CoreEMIApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEMIApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        public UserProfileController(UserManager<ApplicationUser> userManager)
        { 
            _userManager = userManager;
        }

        

        [HttpGet]
        [Authorize]
        //GET : /api/UserProfile
        public async Task<Object> GetUserProfile()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);
            var role = await _userManager.GetRolesAsync(user);

            return new
            {
                user.FullName,
                user.Email,
                user.UserName,
                role = role
            };
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        [Route("ForAdmin")]
        public string GetForAdmin()
        {
            return "Web method for Admin";
        }

        //[HttpGet]
        //[Authorize]
        ////GET : /api/UserProfile/isLoggedIn

        //public async Task<string> isLoggedIn()
        //{
        //    string userId = User.Claims.First(c => c.Type == "UserID").Value;
        //    var user = await _userManager.FindByIdAsync(userId);
        //    return userId;
        //}

        [HttpGet]
        [Authorize(Roles = "User")]
        [Route("ForUserr")]
        public string GetUser()
        {
            return "Web method for User";
        }

        [HttpGet]
        [Authorize(Roles = "Admin,User")]
        [Route("ForAdminOrUser")]
        public string GetForAdminOrUser()
        {
            return "Web method for Admin or User";
        }

    }
}
