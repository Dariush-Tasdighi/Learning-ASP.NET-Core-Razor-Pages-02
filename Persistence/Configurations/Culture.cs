//namespace Persistence.Configurations
//{
//	internal class Culture :
//		object, Microsoft.EntityFrameworkCore
//		.IEntityTypeConfiguration<Domain.Culture>
//	{
//		public Culture() : base()
//		{
//		}

//		//public void Configure
//		//	(Microsoft.EntityFrameworkCore.Metadata
//		//	.Builders.EntityTypeBuilder<Domain.Culture> builder)
//		//{
//		//	throw new System.NotImplementedException();
//		//}
//		public void Configure
//			(Microsoft.EntityFrameworkCore.Metadata
//			.Builders.EntityTypeBuilder<Domain.Culture> builder)
//		{
//			// **************************************************
//			builder
//				.Property(current => current.Name)
//				.IsUnicode(unicode: false)
//				;

//			builder
//				.HasIndex(current => new { current.Name })
//				.IsUnique(unique: true)
//				;
//			// **************************************************

//			// **************************************************
//			builder
//				.Property(current => current.Title)
//				.IsUnicode(unicode: false)
//				;

//			builder
//				.HasIndex(current => new { current.Title })
//				.IsUnique(unique: true)
//				;
//			// **************************************************
//		}
//	}
//}
