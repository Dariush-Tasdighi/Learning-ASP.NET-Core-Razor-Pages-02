using Microsoft.AspNetCore.Http;

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

			// **************************************************
			//var cultureInfo =
			//	new System.Globalization.CultureInfo(name: name);

			//System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
			//System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

			Infrastructure.Middlewares
				.CultureCookieHandlingMiddleware.SetCulture(cultureName: name);
			// **************************************************

			// **************************************************
			Infrastructure.Middlewares.CultureCookieHandlingMiddleware
				.CreateCookie(httpContext: HttpContext, cultureName: name);
			// **************************************************

			return RedirectToPage(pageName: "/Index");
		}

		//public Microsoft.AspNetCore.Mvc.IActionResult OnGet(string name)
		//{
		//	// **************************************************
		//	// GetTypedHeaders -> using Microsoft.AspNetCore.Http;
		//	var typedHeaders =
		//		HttpContext.Request.GetTypedHeaders();

		//	var httpReferer =
		//		typedHeaders.Referer?.AbsoluteUri;

		//	if (string.IsNullOrWhiteSpace(httpReferer))
		//	{
		//		return RedirectToPage(pageName: "/Index");
		//	}
		//	// **************************************************

		//	// **************************************************
		//	string defaultCulture = "fa";

		//	if (string.IsNullOrEmpty(name))
		//	{
		//		name =
		//			defaultCulture;
		//	}

		//	name =
		//		name
		//		.Trim()
		//		.ToLower();

		//	switch (name)
		//	{
		//		case "fa":
		//		case "en":
		//		{
		//			break;
		//		}

		//		default:
		//		{
		//			name =
		//				defaultCulture;

		//			break;
		//		}
		//	}

		//	var cultureInfo =
		//		new System.Globalization.CultureInfo(name: name);

		//	System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
		//	System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
		//	// **************************************************

		//	// **************************************************
		//	Infrastructure.CultureCookieHandlingMiddleware
		//		.CreateCookie(httpContext: HttpContext, cultureName: name);
		//	// **************************************************

		//	return Redirect(url: httpReferer);
		//}
	}
}
