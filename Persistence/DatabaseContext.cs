////using Microsoft.EntityFrameworkCore;

//namespace Persistence
//{
//	public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
//	{
//		public DatabaseContext
//			(Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options) : base(options: options)
//		{
//			//Database.EnsureCreated();
//		}

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<Domain.Culture>? Cultures { get; set; }
//		// **********

//		protected override void OnConfiguring
//			(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
//		{
//			base.OnConfiguring(optionsBuilder);
//		}

//		//protected override void OnModelCreating
//		//	(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
//		//{
//		//	base.OnModelCreating(modelBuilder);
//		//}

//		protected override void OnModelCreating
//			(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
//		{
//			// Solution (1)
//			//modelBuilder
//			//	.Entity<Domain.Culture>()
//			//	.Property(current => current.Name)
//			//	.IsUnicode(unicode: false)
//			//	;

//			//modelBuilder
//			//	.Entity<Domain.Culture>()
//			//	.HasIndex(current => new { current.Name })
//			//	.IsUnique(unique: true)
//			//	;
//			// /Solution (1)

//			// Solution (2)
//			//modelBuilder.ApplyConfiguration
//			//	(configuration: new Configurations.Culture());
//			// /Solution (2)

//			// Solution (3)
//			//new Configurations.Culture()
//			//	.Configure(builder: modelBuilder.Entity<Domain.Culture>());
//			// /Solution (3)

//			// Solution (4)
//			modelBuilder.ApplyConfigurationsFromAssembly
//				(assembly: typeof(Configurations.Culture).Assembly);
//			// /Solution (4)
//		}
//	}
//}
