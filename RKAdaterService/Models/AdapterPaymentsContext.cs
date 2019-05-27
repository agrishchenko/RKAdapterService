using Microsoft.EntityFrameworkCore;

namespace RKAdapterService.Models
{
	public class AdapterPaymentsContext: DbContext
	{
		public AdapterPaymentsContext(DbContextOptions<AdapterPaymentsContext> options)
		: base(options)
		{
		
			Database.Migrate();
		}

		public AdapterPaymentsContext()
		: base()
		{
			

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Payment>()
				.HasKey(c => new { c.ExternalId, c.UserId });
		}


		public DbSet<Payment> PaymentItems { get; set; }

	}
}
