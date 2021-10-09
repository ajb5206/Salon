using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
	public class HairSalonContext : DbContext
	{
		public DbSet<Stylist> Stylists { get; set; }

		public HairSalonContext(DbContextOptions options) : base(options) { }
	}
}