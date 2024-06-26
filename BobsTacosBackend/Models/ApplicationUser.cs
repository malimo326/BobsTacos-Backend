﻿using BobsTacosBackend.Enums;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace BobsTacosBackend.Models
{

    public class ApplicationUser : IdentityUser
        {
            public Role Role { get; set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
    }
    
}
