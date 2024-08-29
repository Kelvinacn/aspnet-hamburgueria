using Hamburgueria.DATA.Models;
using Microsoft.EntityFrameworkCore;


namespace Hamburgueria.DATA.Context
{
    public class LoginContext : DbContext
    {
        public DbSet<Login> Login { get; set; }

        public LoginContext(DbContextOptions<LoginContext> options) :
            base(options)
        {
        }

    }
}
