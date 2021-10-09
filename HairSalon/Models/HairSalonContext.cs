Using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
	public class HairSalonContext : AddDbContext
	{
		public DbSet<Stylist> Stylists { get; set; }

		public HairSalonContext(DbContextOptions options) : base(options) { }
	}
}