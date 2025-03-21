using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityApp.Models
{
    public class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Admin_123";

        public static async Task IdentityTestUser(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<IdentityContext>();
            if(context.Database.GetAppliedMigrations().Any())
            {
                context.Database.Migrate();
            }
            var userManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<UserManager<IdentityUser>>(); // ıdentity nin sunduğu usermanager sınıfı 

            var user = await userManager.FindByNameAsync(adminUser);

            if(user == null)
            {
                user = new IdentityUser{
                    UserName = adminUser,
                    Email = "admin@gmail.com",
                    PhoneNumber = "22222222222"
                };

                await userManager.CreateAsync(user, adminPassword); //şifre hash ile saklanır yani şifrelenir.
            }
        }
    }
}