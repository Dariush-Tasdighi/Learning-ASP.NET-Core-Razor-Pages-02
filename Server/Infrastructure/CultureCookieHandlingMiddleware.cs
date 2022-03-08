namespace Infrastructure
{
	public class CultureCookieHandlingMiddleware : object
	{
		public readonly static string CookieName = "Culture.Cookie";

		public CultureCookieHandlingMiddleware
			(Microsoft.AspNetCore.Http.RequestDelegate next) : base()
		{
			Next = next;
		}

		protected Microsoft.AspNetCore.Http.RequestDelegate Next { get; }

		public async System.Threading.Tasks.Task InvokeAsync
			(Microsoft.AspNetCore.Http.HttpContext httpContext)
		{
			var cultureName =
				httpContext.Request.Cookies[key: CookieName];

			switch (cultureName?.ToLower())
			{
				case "fa":
				case "en":
				{
					SetCulture(cultureName: cultureName);

					break;
				}

				default:
				{
					// می‌خواهیم اول بسم‌الله سایت به چه زبانی باز شود
					SetCulture(cultureName: "fa");
					//SetCulture(cultureName: "en");

					break;
				}
			}

			await Next(context: httpContext);
		}

		public static void SetCulture(string cultureName)
		{
			var cultureInfo =
				new System.Globalization.CultureInfo(name: cultureName);

			System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
			System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
		}

		public static void CreateCookie
			(Microsoft.AspNetCore.Http.HttpContext httpContext, string cultureName)
		{
			var cookieOptions =
				new Microsoft.AspNetCore.Http.CookieOptions
				{
					//MaxAge,

					Path = "/",
					Secure = true,
					HttpOnly = false,
					IsEssential = true,

					// Note: نباید تغییر دهیم، خودش به طور
					// خودکار بر اساس دامنه سایت تنظیم می‌شود
					//Domain = ?????

					Expires =
						System.DateTimeOffset.UtcNow.AddYears(1),

					SameSite =
						Microsoft.AspNetCore.Http.SameSiteMode.Strict,
				};

			httpContext.Response.Cookies.Delete(key: CookieName);

			httpContext.Response.Cookies
				.Append(key: CookieName,
				value: cultureName.ToLower(), options: cookieOptions);
		}
	}
}
