﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreEMIApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        [Column(TypeName = "nvarchar(150)")]
        public string FullName { get; set; }
    }
}
