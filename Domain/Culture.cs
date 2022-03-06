//namespace Domain
//{
//	public class Culture :
//		SeedWork.Entity,
//		SeedWork.IEntityHasIsActive,
//		SeedWork.IEntityHasUpdateDateTime
//	{
//		public Culture() : base()
//		{
//		}

//		// **********
//		[System.ComponentModel.DataAnnotations.Display
//			(ResourceType = typeof(Resources.DataDictionary),
//			Name = nameof(Resources.DataDictionary.IsActive))]
//		public bool IsActive { get; set; }
//		// **********

//		// **********
//		[System.ComponentModel.DataAnnotations.Display
//			(ResourceType = typeof(Resources.DataDictionary),
//			Name = nameof(Resources.DataDictionary.UpdateDateTime))]
//		public System.DateTime UpdateDateTime { get; set; }
//		// **********

//		//public Culture(System.Globalization.CultureInfo cultureInfo)
//		//{
//		//	Lcid = cultureInfo.LCID;
//		//	Name = cultureInfo.Name;
//		//	NativeName = cultureInfo.NativeName;
//		//	DisplayName = cultureInfo.DisplayName;
//		//}

//		// **********
//		[System.ComponentModel.DataAnnotations.Display
//			(ResourceType = typeof(Resources.DataDictionary),
//			Name = Resources.DataDictionary.Lcid)]
//		public int Lcid { get; set; }
//		// **********

//		// **********
//		[System.ComponentModel.DataAnnotations.Display
//			(ResourceType = typeof(Resources.DataDictionary),
//			Name = nameof(Resources.DataDictionary.Name))]

//		//[System.ComponentModel.DataAnnotations.Required
//		//	(AllowEmptyStrings = false,
//		//	ErrorMessageResourceType = typeof(Resources.Messages),
//		//	ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

//		//[System.ComponentModel.DataAnnotations.StringLength
//		//	(maximumLength: 50,
//		//	ErrorMessageResourceType = typeof(Resources.Messages),
//		//	ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
//		public string Name { get; set; }
//		// **********

//		// **********
//		[System.ComponentModel.DataAnnotations.Display
//			(ResourceType = typeof(Resources.DataDictionary),
//			Name = nameof(Resources.DataDictionary.Title))]

//		//[System.ComponentModel.DataAnnotations.Required
//		//	(AllowEmptyStrings = false,
//		//	ErrorMessageResourceType = typeof(Resources.Messages),
//		//	ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

//		//[System.ComponentModel.DataAnnotations.StringLength
//		//	(maximumLength: 50,
//		//	ErrorMessageResourceType = typeof(Resources.Messages),
//		//	ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
//		public string Title { get; set; }
//		// **********

//		// **********
//		//[System.ComponentModel.DataAnnotations.Display
//		//	(ResourceType = typeof(Resources.Models.MyCulture),
//		//	Name = Resources.Models.Strings.MyCultureKeys.NativeName)]

//		//[System.ComponentModel.DataAnnotations.Required
//		//	(AllowEmptyStrings = false,
//		//	ErrorMessageResourceType = typeof(Resources.Messages),
//		//	ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

//		//[System.ComponentModel.DataAnnotations.StringLength
//		//	(maximumLength: 50,
//		//	ErrorMessageResourceType = typeof(Resources.Messages),
//		//	ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
//		public string NativeName { get; set; }
//		// **********

//		// **********
//		//[System.ComponentModel.DataAnnotations.Display
//		//	(ResourceType = typeof(Resources.Models.MyCulture),
//		//	Name = Resources.Models.Strings.MyCultureKeys.DisplayName)]

//		//[System.ComponentModel.DataAnnotations.Required
//		//	(AllowEmptyStrings = false,
//		//	ErrorMessageResourceType = typeof(Resources.Messages),
//		//	ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

//		//[System.ComponentModel.DataAnnotations.StringLength
//		//	(maximumLength: 100,
//		//	ErrorMessageResourceType = typeof(Resources.Messages),
//		//	ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
//		public string DisplayName { get; set; }
//		// **********

//		// **********
//		//[System.Web.Mvc.AllowHtml]

//		//[System.ComponentModel.DataAnnotations.Display
//		//	(ResourceType = typeof(Resources.Models.General),
//		//	Name = Resources.Models.Strings.GeneralKeys.Description)]

//		//[System.ComponentModel.DataAnnotations.DataType
//		//	(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
//		public string Description { get; set; }

//		public void SetUpdateDateTime()
//		{
//		}
//		// **********
//	}
//}
