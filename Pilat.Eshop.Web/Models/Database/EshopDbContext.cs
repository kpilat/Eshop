using Microsoft.EntityFrameworkCore;
using Pilat.Eshop.Web.Models.Entity;
using System;

namespace Pilat.Eshop.Web.Models.Database
{
	public class EshopDbContext : DbContext
	{
		public DbSet<CarouselItem> CarouselItems { get; set; }
		public DbSet<Product> Products { get; set; }

		public EshopDbContext(DbContextOptions options) : base(options)
		{

		}
	}
}