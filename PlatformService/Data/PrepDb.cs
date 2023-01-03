using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrePopulation(IApplicationBuilder app, bool isProd)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>()!, isProd); // Null forgiven operator
            }
        }

        private static void SeedData(AppDbContext context, bool isProd)
        {

            if (isProd)
            {
                Console.WriteLine("--> Attempt to apply migrations...");
                try
                {
                    context.Database.Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"--> Could not run migrations: {ex.Message}");
                }
            }

            if (!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding data");
                context.Platforms.AddRange(
                  new Platform() { Name = "DotNet", Publisher = "Microsoft", Cost = "Free" },
                  new Platform() { Name = "SQL Server", Publisher = "Microsoft", Cost = "Free" },
                  new Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing foundation", Cost = "Free" }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}