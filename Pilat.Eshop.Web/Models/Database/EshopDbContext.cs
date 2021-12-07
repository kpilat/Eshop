using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pilat.Eshop.Web.Models.Database.Configurations;
using Pilat.Eshop.Web.Models.Entity;
using Pilat.Eshop.Web.Models.Identity;
using System;

namespace Pilat.Eshop.Web.Models.Database
{
	public class EshopDbContext : IdentityDbContext<User, Role, int>
	{
		public DbSet<CarouselItem> CarouselItems { get; set; }
		public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }

		public EshopDbContext(DbContextOptions options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfiguration<Order>(new OrderConfiguration());
			foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
				entity.SetTableName(entity.GetTableName().Replace("AspNet", string.Empty));
            }
        }
	}
}