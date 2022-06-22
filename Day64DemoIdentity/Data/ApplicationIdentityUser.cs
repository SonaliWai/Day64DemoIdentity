using Microsoft.AspNetCore.Identity;

namespace Day64DemoIdentity.Data
{
    public class ApplicationIdentityUser : IdentityUser
    {
        public int Age { get; set; }
    }
}

