

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Movies.Identity.Models;

namespace WebApp.Movies.Identity
{
    public class WebStoreIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public WebStoreIdentityDbContext(DbContextOptions<WebStoreIdentityDbContext> options) : base(options)
        {
        }
    }
}
