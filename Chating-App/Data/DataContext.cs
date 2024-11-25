using ChatingApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChatingApp.Data
{
	public class DataContext : DbContext
	{
		public DbSet<AppUser> Users { get; set; }
		public DataContext(DbContextOptions options) : base(options)
		{
		}
	}
}