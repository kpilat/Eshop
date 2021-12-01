using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Pilat.Eshop.Web.Models.Database;
using Pilat.Eshop.Web.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilat.Eshop.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();
                
            using(var scope = host.Services.CreateScope())
            {
                if (scope.ServiceProvider.GetRequiredService<IWebHostEnvironment>().IsDevelopment())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<EshopDbContext>();
                    DatabaseInit dbInit = new DatabaseInit();
                    dbInit.Initialization(dbContext);
                    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
                    using (Task task = dbInit.EnsureRoleCreated(roleManager))
                    {
                        task.Wait();
                    }
                    using (Task task = dbInit.EnsureAdminCreated(userManager))
                    {
                        task.Wait();
                    }
                    using (Task task = dbInit.EnsureManagerCreated(userManager))
                    {
                        task.Wait();
                    }
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
