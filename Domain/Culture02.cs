namespace Domain
{
	public class Culture02 : object
	{
		public Culture02() : base()
		{
			// New
			InsertDateTime = System.DateTime.Now;
			UpdateDateTime = System.DateTime.Now;
		}

		// **********
		/// <summary>
		/// New
		/// </summary>
		[System.ComponentModel.DataAnnotations.Key]

		/// <summary>
		/// New
		/// </summary>
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(databaseGeneratedOption:
			System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		public int Code { get; set; }
		// **********

		// **********
		public int Ordering { get; set; }
		// **********

		// **********
		public bool IsActive { get; set; }
		// **********

		// **********
		/// <summary>
		/// New
		/// </summary>
		//[System.ComponentModel.DataAnnotations.MaxLength
		//	(length: 5)]

		//[System.ComponentModel.DataAnnotations.StringLength
		//	(maximumLength: 5)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 5, MinimumLength = 2)]
		public string? Name { get; set; }
		// **********

		// **********
		/// <summary>
		/// New
		/// </summary>
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]
		public string? Title { get; set; }
		// **********

		// **********
		public string? Description { get; set; }
		// **********

		// **********
		public System.DateTime InsertDateTime { get; set; }
		// **********

		// **********
		public System.DateTime UpdateDateTime { get; set; }
		// **********
	}
}
