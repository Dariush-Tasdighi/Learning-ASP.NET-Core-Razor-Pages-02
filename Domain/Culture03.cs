namespace Domain
{
	public class Culture03 : object
	{
		/// <summary>
		/// New
		/// </summary>
		//public Culture03() : base()
		//{
		//}

		/// <summary>
		/// New
		/// </summary>
		public Culture03(string name, string title) : base()
		{
			// New
			Name = name;
			Title = title;

			// New
			//Id = new System.Guid();
			Id = System.Guid.NewGuid();

			// New
			InsertDateTime = SeedWork.Utility.Now;
			UpdateDateTime = SeedWork.Utility.Now;
		}

		// **********
		/// <summary>
		/// New
		/// </summary>
		[System.ComponentModel.DataAnnotations.Key]
		public System.Guid Id { get; set; }
		// **********

		// **********
		public int Ordering { get; set; }
		// **********

		// **********
		public bool IsActive { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.MaxLength(length: 50)]

		// New
		//[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		public string? Name { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.MaxLength(length: 50)]

		// New
		//[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
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
