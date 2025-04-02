using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RedVine.Areas.Identity.Data;

// Add profile data for application users by adding properties to the RedVineUser class
public class RedVineUser : IdentityUser
{ 
    public string? Avatar { get; set;  }
    public string? Username { get; set; }
    [StringLength(500, ErrorMessage = "Descprtion must be 500 or less characters")]
    public string? Description { get; set; }
    public List<Guid>? Likes { get; set; } = [];
}

