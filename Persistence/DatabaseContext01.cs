namespace Persistence
{
	public class DatabaseContext01 : Microsoft.EntityFrameworkCore.DbContext
	{
		public DatabaseContext01
			(Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext01> options) : base(options: options)
		{
			Database.EnsureCreated();
		}

		// **********
		public Microsoft.EntityFrameworkCore.DbSet<Domain.Culture01>? Cultures { get; set; }
		// **********
	}
}
