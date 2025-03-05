using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace RedVine.Pages
{
    public class ProfileModel : PageModel
    {
        public string ProfilePicture { get; set; } = "/images/default-profile.png"; // Mock Profile Pic
        public string UserName { get; set; } = "John Doe";
        public string Email { get; set; } = "johndoe@example.com";
        public DateTime DOB { get; set; } = new DateTime(1998, 5, 21);
        public int LikedItems { get; set; } = 20;
        public int PrivatePosts { get; set; } = 5;
        public int BlockedUsers { get; set; } = 2;

        public void OnGet()
        {
            // No functionality for now, just mock data.
        }
    }
}
