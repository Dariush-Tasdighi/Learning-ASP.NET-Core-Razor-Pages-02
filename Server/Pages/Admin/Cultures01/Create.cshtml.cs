using System.Linq;

namespace Server.Pages.Admin.Cultures01
{
	public class CreateModel :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public CreateModel
			(Persistence.DatabaseContext01 databaseContext) : base()
		{
			DatabaseContext = databaseContext;
		}

		public Persistence.DatabaseContext01 DatabaseContext { get; }

		/// <summary>
		/// New
		/// </summary>
		//public void OnGet()
		public Microsoft.AspNetCore.Mvc.IActionResult OnGet()
		{
			try
			{
				// **************************************************
				//var cultures =
				//	DatabaseContext.Cultures?
				//	.ToList()
				//	;

				//var cultureCount = cultures.Count;
				// **************************************************
				// Note: TSQL -> SELECT * FROM Cultures
				// **************************************************

				// **************************************************
				//var cultureCount =
				//	DatabaseContext.Cultures?
				//	.Count();
				// **************************************************
				// Note: TSQL -> SELECT COUNT(*) FROM Cultures
				// **************************************************

				var hasAny =
					DatabaseContext.Cultures?
					.Any();

				if (hasAny.HasValue && hasAny.Value == false)
				{
					for (int index = 1; index <= 10; index++)
					{
						var culture =
							new Domain.Culture01
							{
								Name = $"Name {index}",
								Title = $"Title {index}",
							};

						DatabaseContext.Cultures?.Add(culture);

						// Note: Not Transactional Behaviore
						//DatabaseContext.SaveChanges();
					}

					// Note: Transactional Behaviore
					DatabaseContext.SaveChanges();
				}
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}

			return RedirectToPage(pageName: "Index");
		}
	}
}
