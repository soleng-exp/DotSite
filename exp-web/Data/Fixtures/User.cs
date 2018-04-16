using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace exp_web.Data.Fixtures
{
    public class User
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UserContext(
                serviceProvider.GetRequiredService<DbContextOptions<UserContext>>()))
            {
                if (context.Users.Any())
                {
                    return; // DB has been seeded
                }

                context.Users.AddRange(
                    new Models.User()
                    {
                        Birthday = new DateTime(2001, 11, 01),
                        CreatedAt = DateTime.Now,
                        Username = "John"
                    },
                    new Models.User()
                    {
                        Birthday = new DateTime(1995, 10, 10),
                        CreatedAt = DateTime.Now,
                        Username = "Soleng"
                    },
                    new Models.User()
                    {
                        Birthday = new DateTime(1972, 05, 24),
                        CreatedAt = DateTime.Now,
                        Username = "Admin"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}