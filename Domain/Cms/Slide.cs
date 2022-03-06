//namespace Domain.Cms
//{
//	[System.ComponentModel.DataAnnotations.Schema.Table
//		("Slides", Schema = Constants.SCHEMA_CMS)]
//	public class Slide : BaseLocalizedEntity
//	{
//		#region Configuration
//		internal class Configuration :
//			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Slide>
//		{
//			public Configuration()
//			{

//				switch (Models.Utility.DatabaseProvider)
//				{
//					case Enums.DatabaseProviders.Oracle:
//					{
//						break;
//					}

//					case Enums.DatabaseProviders.SqlServer:
//					{
//						break;
//					}

//					case Enums.DatabaseProviders.SqlServerCompactEdition:
//					{
//						Property(current => current.Description)
//							.HasColumnType("ntext")
//							.IsMaxLength()
//							;

//						break;
//					}
//				}
//			}
//		}
//		#endregion /Configuration

//		public Slide()
//		{
//		}

//		// **********
//		[System.ComponentModel.DataAnnotations.Display
//			(ResourceType = typeof(Resources.Models.General),
//			Name = Resources.Models.Strings.GeneralKeys.Title)]

//		[System.ComponentModel.DataAnnotations.StringLength
//			(maximumLength: 100,
//			ErrorMessageResourceType = typeof(Resources.Messages),
//			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
//		public string Title { get; set; }
//		// **********

//		// **********
//		/// <summary>
//		/// Version: 1.0.1
//		/// Update Date: 1394/11/04
//		/// Changed in New Version: 1.1.0
//		/// Developer: Mr. Dariush Tasdighi
//		/// </summary>
//		[System.ComponentModel.DataAnnotations.Display
//			(ResourceType = typeof(Resources.Models.General),
//			Name = Resources.Models.Strings.GeneralKeys.Url)]

//		[System.ComponentModel.DataAnnotations.StringLength
//			(maximumLength: 250,
//			ErrorMessageResourceType = typeof(Resources.Messages),
//			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]

//		//[System.ComponentModel.DataAnnotations.RegularExpression
//		//	(Dtx.Text.RegularExpressions.Patterns.Url,
//		//	ErrorMessageResourceType = typeof(Resources.Messages),
//		//	ErrorMessageResourceName =
//		//	Resources.Strings.MessagesKeys.RegularExpressionForUrl)]

//		//[System.ComponentModel.DataAnnotations.DataType
//		//	(System.ComponentModel.DataAnnotations.DataType.Url)]
//		public string Url { get; set; }
//		// **********

//		// **********
//		/// <summary>
//		/// Version: 1.0.0
//		/// Update Date: 1394/11/04
//		/// Changed in New Version: 1.1.0
//		/// Developer: Mr. Dariush Tasdighi
//		/// </summary>
//		[System.ComponentModel.DataAnnotations.Display
//			(ResourceType = typeof(Resources.Models.General),
//			Name = Resources.Models.Strings.GeneralKeys.OpenUrlInNewWindow)]
//		public bool OpenUrlInNewWindow { get; set; }
//		// **********

//		// **********
//		[System.ComponentModel.DataAnnotations.Display
//			(ResourceType = typeof(Resources.Models.General),
//			Name = Resources.Models.Strings.GeneralKeys.ImageUrl)]

//		[System.ComponentModel.DataAnnotations.Required
//			(AllowEmptyStrings = false,
//			ErrorMessageResourceType = typeof(Resources.Messages),
//			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

//		[System.ComponentModel.DataAnnotations.StringLength
//			(maximumLength: 250,
//			ErrorMessageResourceType = typeof(Resources.Messages),
//			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]

//		//[System.ComponentModel.DataAnnotations.RegularExpression
//		//	(Dtx.Text.RegularExpressions.Patterns.Url,
//		//	ErrorMessageResourceType = typeof(Resources.Messages),
//		//	ErrorMessageResourceName =
//		//	Resources.Strings.MessagesKeys.RegularExpressionForUrl)]

//		//[System.ComponentModel.DataAnnotations.DataType
//		//	(System.ComponentModel.DataAnnotations.DataType.Url)]
//		public string ImageUrl { get; set; }
//		// **********

//		// **********
//		[System.Web.Mvc.AllowHtml]

//		[System.ComponentModel.DataAnnotations.Display
//			(ResourceType = typeof(Resources.Models.General),
//			Name = Resources.Models.Strings.GeneralKeys.Description)]

//		[System.ComponentModel.DataAnnotations.DataType
//			(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
//		public string Description { get; set; }
//		// **********
//	}
//}
