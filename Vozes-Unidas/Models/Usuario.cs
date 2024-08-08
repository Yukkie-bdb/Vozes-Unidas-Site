using Microsoft.AspNetCore.Identity;

namespace Vozes_Unidas.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
        public char Tipo { get; set; }
    }
}
