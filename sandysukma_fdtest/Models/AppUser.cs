using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace sandysukma_fdtest.Models
{
    public class AppUser : IdentityUser
    {
        public bool IsEmailVerified { get; set; } = false;
    }
}
