using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Templete_Design_Pattern.DAL.Entites;

namespace Templete_Design_Pattern.DAL
{
    public class Context:IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GSJF6OR;initial catalog=UpSchoolTemplateDb;integrated security=true");
        }


    }
}
