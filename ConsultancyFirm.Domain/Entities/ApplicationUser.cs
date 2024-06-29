using Microsoft.AspNetCore.Identity;

namespace ConsultancyFirm.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
