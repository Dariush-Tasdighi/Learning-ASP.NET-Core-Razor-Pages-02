namespace Persistence
{
	public class DatabaseContext02 : Microsoft.EntityFrameworkCore.DbContext
	{
		public DatabaseContext02(Microsoft.EntityFrameworkCore
			.DbContextOptions<DatabaseContext02> options) : base(options: options)
		{
			Database.EnsureCreated();
		}

		// **********
		public Microsoft.EntityFrameworkCore.DbSet<Domain.Culture02>? Cultures { get; set; }
		// **********
	}
}
