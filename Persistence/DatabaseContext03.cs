namespace Persistence
{
	public class DatabaseContext03 : Microsoft.EntityFrameworkCore.DbContext
	{
		public DatabaseContext03(Microsoft.EntityFrameworkCore
			.DbContextOptions<DatabaseContext03> options) : base(options: options)
		{
			Database.EnsureCreated();
		}

		// **********
		public Microsoft.EntityFrameworkCore.DbSet<Domain.Culture03>? Cultures { get; set; }
		// **********
	}
}
