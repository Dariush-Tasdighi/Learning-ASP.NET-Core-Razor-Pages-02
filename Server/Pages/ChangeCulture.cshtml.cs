using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Server.Pages
{
	public class ChangeCultureModel : Infrastructure.BasePageModel
	{
		public ChangeCultureModel
			(Microsoft.Extensions.Options.IOptions
			<Microsoft.AspNetCore.Builder.RequestLocalizationOptions>? requestLocalizationOptions) : base()
		{
			RequestLocalizationOptions =
				requestLocalizationOptions?.Value;
		}

		private Microsoft.AspNetCore.Builder.RequestLocalizationOptions? RequestLocalizationOptions { get; }

		////public void OnGet()
		////public void OnGet(string name)
		//public Microsoft.AspNetCore.Mvc.IActionResult OnGet(string name)
		//{
		//	string defaultCulture = "fa";

		//	if (string.IsNullOrEmpty(name))
		//	{
		//		name =
		//			defaultCulture;
		//	}

		//	name =
		//		name
		//		.Replace(" ", string.Empty)
		//		.ToLower()
		//		;

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

		//	// **************************************************
		//	//var cultureInfo =
		//	//	new System.Globalization.CultureInfo(name: name);

		//	//System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
		//	//System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

		//	Infrastructure.Middlewares
		//		.CultureCookieHandlerMiddleware.SetCulture(cultureName: name);
		//	// **************************************************

		//	// **************************************************
		//	Infrastructure.Middlewares.CultureCookieHandlerMiddleware
		//		.CreateCookie(httpContext: HttpContext, cultureName: name);
		//	// **************************************************

		//	return RedirectToPage(pageName: "/Index");
		//}

		//public Microsoft.AspNetCore.Mvc.IActionResult OnGet(string name)
		//{
		//	// **************************************************
		//	// GetTypedHeaders -> using Microsoft.AspNetCore.Http;
		//	var typedHeaders =
		//		HttpContext.Request.GetTypedHeaders();

		//	var httpReferer =
		//		typedHeaders?.Referer?.AbsoluteUri;

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
		//		.Replace(" ", string.Empty)
		//		.ToLower()
		//		;

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
		//	// **************************************************

		//	// **************************************************
		//	Infrastructure.Middlewares
		//		.CultureCookieHandlerMiddleware.SetCulture(cultureName: name);
		//	// **************************************************

		//	// **************************************************
		//	Infrastructure.Middlewares.CultureCookieHandlerMiddleware
		//		.CreateCookie(httpContext: HttpContext, cultureName: name);
		//	// **************************************************

		//	return Redirect(url: httpReferer);
		//}

		public Microsoft.AspNetCore.Mvc.IActionResult OnGet(string? cultureName)
		{
			// **************************************************
			// GetTypedHeaders -> using Microsoft.AspNetCore.Http;
			var typedHeaders =
				HttpContext.Request.GetTypedHeaders();

			var httpReferer =
				typedHeaders?.Referer?.AbsoluteUri;

			if (string.IsNullOrWhiteSpace(httpReferer))
			{
				return RedirectToPage(pageName: "/Index");
			}
			// **************************************************

			// **************************************************
			var defaultCultureName =
				RequestLocalizationOptions?
				.DefaultRequestCulture.UICulture.TwoLetterISOLanguageName;

			var supportedCultureNames =
				RequestLocalizationOptions?.SupportedUICultures?
				.Select(current => current.Name)
				.ToList()
				;
			// **************************************************

			// **************************************************
			if (string.IsNullOrWhiteSpace(cultureName))
			{
				cultureName =
					defaultCultureName;
			}

			cultureName =
				cultureName?
				.Replace(" ", string.Empty)
				.ToLower()
				;
			// **************************************************

			// **************************************************
			//if (supportedCultureNames?.Contains(item: cultureName) == false)
			//{
			//	cultureName =
			//		defaultCultureName;
			//}

			if (supportedCultureNames?.Contains(item: cultureName!) == false)
			{
				cultureName =
					defaultCultureName;
			}
			// **************************************************

			// **************************************************
			Infrastructure.Middlewares
				.CultureCookieHandlerMiddleware.SetCulture(cultureName: cultureName);
			// **************************************************

			// **************************************************
			//Infrastructure.Middlewares.CultureCookieHandlerMiddleware
			//	.CreateCookie(httpContext: HttpContext, cultureName: cultureName);

			Infrastructure.Middlewares.CultureCookieHandlerMiddleware
				.CreateCookie(httpContext: HttpContext, cultureName: cultureName!);
			// **************************************************

			return Redirect(url: httpReferer);
		}
	}
}
