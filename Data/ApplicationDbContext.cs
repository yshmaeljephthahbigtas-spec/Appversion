using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

using lol.Models;

 

namespace lol.Data;

 

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)

{

    public DbSet<Product> Product { get; set; }

}