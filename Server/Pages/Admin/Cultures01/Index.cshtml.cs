using System.Linq;

namespace Server.Pages.Admin.Cultures01
{
	public class IndexModel :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public IndexModel
			(Persistence.DatabaseContext01 databaseContext) : base()
		{
			DatabaseContext = databaseContext;
		}

		//private Persistence.DatabaseContext01 _databaseContext;

		//private readonly Persistence.DatabaseContext01 _databaseContext;

		public Persistence.DatabaseContext01 DatabaseContext { get; }

		public System.Collections.Generic.IList<Domain.Culture01>? Cultures { get; set; }

		public void OnGet()
		{
			Cultures =
				DatabaseContext.Cultures?
				// ToList() -> using System.Linq;
				.ToList()
				;
		}
	}
}
