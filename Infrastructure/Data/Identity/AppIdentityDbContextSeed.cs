using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Data.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Mirzohid",
                    Email = "mir@zo.hid",
                    UserName = "mir@zo.hid",
                    Address = new Address
                    {
                        FirstName = "Mirzohid",
                        LastName = "Mizamov",
                        Street = "Dorm 314",
                        City = "Nurato",
                        Province = "Navoiy",
                        ZipCode = "70010"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}