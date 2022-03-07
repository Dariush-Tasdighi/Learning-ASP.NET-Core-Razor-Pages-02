namespace Domain
{
	public class Culture01 : object
	{
		public Culture01() : base()
		{
		}

		// **********
		public int Id { get; set; }
		// **********

		// **********
		public int Ordering { get; set; }
		// **********

		// **********
		public bool IsActive { get; set; }
		// **********

		// **********
		public string? Name { get; set; }
		// **********

		// **********
		public string? Title { get; set; }
		// **********

		// **********
		public string? Description { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(databaseGeneratedOption:
			System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.DateTime InsertDateTime { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(databaseGeneratedOption:
			System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.DateTime UpdateDateTime { get; set; }
		// **********
	}
}
