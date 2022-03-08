namespace Server.Pages
{
	public class ChangeCultureModel : Infrastructure.BasePageModel
	{
		public ChangeCultureModel() : base()
		{
		}

		//public void OnGet()
		//public void OnGet(string name)
		public Microsoft.AspNetCore.Mvc.IActionResult OnGet(string name)
		{
			string defaultCulture = "fa";

			if (string.IsNullOrEmpty(name))
			{
				name =
					defaultCulture;
			}

			name =
				name
				.Trim()
				.ToLower();

			switch (name)
			{
				case "fa":
				case "en":
				{
					break;
				}

				default:
				{
					name =
						defaultCulture;

					break;
				}
			}

			var cultureInfo =
				new System.Globalization.CultureInfo(name: name);

			System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
			System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

			Infrastructure.CultureCookieHandlingMiddleware
				.CreateCookie(httpContext: HttpContext, cultureName: name);

			return RedirectToPage(pageName: "/Index");
		}
	}
}
