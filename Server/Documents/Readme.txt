**************************************************
**************************************************
**************************************************
Session (13)
**************************************************
**************************************************
**************************************************
1)
	Run application and check it

2)
	Resource Philosophy
		Multilingual
			کشورهای عربی
		شناسه کاربر -> شناسه کاربری
		لهجه‌ها

3)
	Culture -> Almost -> Language

	2

		fa	en	fr	ar

	5

		fa-IR	en-US	en-UK	fr-FR

4)
	We should have one and only one master resource!
		It's better master be in english!

		X.resx

	We can have zero or more slave resources!

		X.fa.resx
		X.fa-IR.resx
		X.fr-FR.resx

5)
	Steps

		A. Create a master resource file (X.resx)
		B. Change the access modifier to 'Public'
		C. Add some key value in master resource file
			Name should not have and (.) or spacebar!
		D. Run custom tool
		E. Create a new resource (X.fa.resx)
		F. Copy all key value from master resource file to slave resource file
		G. Never change the access modifier of slave resource files 'No code generation'
		H. Slave resource files should not have designer!
		I. Check the 'Resources.csproj' file

6)
	Shared -> in 'Resources' project -> Create Resource file:

		DataDictionary.resx		(Public)(Run custom tool)
		DataDictionary.fa.resx	(No code generation)

		<ItemGroup>
			<Compile Update="DataDictionary.Designer.cs">
				<DesignTime>True</DesignTime>
				<AutoGen>True</AutoGen>
				<DependentUpon>DataDictionary.resx</DependentUpon>
			</Compile>
		</ItemGroup>

		<ItemGroup>
			<EmbeddedResource Update="DataDictionary.resx">
				<Generator>PublicResXFileCodeGenerator</Generator>
				<LastGenOutput>DataDictionary.Designer.cs</LastGenOutput>
			</EmbeddedResource>
		</ItemGroup>
7)
	Use resources in below files:

		Pages ->
			Index
			About
			Contact

8)
	Pages:
		_ViewStart.cshtml

9)
	Pages:
		Shared:
			Layouts:
				Ltr:
					_Layout.cshtml
				Rtl:
					_Layout.cshtml

10)
	wwwroot:
		css:
			ltr:
				site.css
			Rtl:
				site.css

11)
	libman.json

		{
			"library": "flag-icon-css@4.1.5",
			"destination": "wwwroot/lib/flag-icon-css/"
		}

12)
	Pages:
		Shared:
			PartialViews:
				Ltr:
					_Footer.cshtml
					_Header.cshtml
					_Scripts.cshtml
					_StyleSheets.cshtml
				Rtl:
					_Footer.cshtml
					_Header.cshtml
					_Scripts.cshtml
					_StyleSheets.cshtml

13)
	Pages:
		Shared:
			PartialViews:
				_ChangeCulture.cshtml
**************************************************

**************************************************
**************************************************
**************************************************
Session (14)
**************************************************
**************************************************
**************************************************

**************************************************
Tanx Mr. Hamed Banaie برای اصلاح متونی که مشکل تایپی داشته‌اند

Tanx Mr. Sadegh Dehghani

	CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
**************************************************

**************************************************
1)
	Infrastructure:
		Middlewares:
			CultureCookieHandlerMiddleware.cs

2)
	Pages:
		ChangeCulture.cshtml
			httpReferer!

3)
	Program.cs:
		app.UseMiddleware
			<Infrastructure.Middlewares.CultureCookieHandlerMiddleware>();

4)
	انواع حالات ایجاد سایت‌های چند زبانه

	a. به صورت بالقوه

	b. به صورت بالفعل و صرفا ظاهر و عناوین چند زبانه می‌شوند

	c. همه یا بعضی از داده‌ها نیز چند زبانه می‌شوند

		Some Tables has a field with the name of: CultureId

		اصلاح شود Routing باید

		https://www.x.com/fa/About
		https://www.x.com/fa-IR/About
		https://www.x.com/en/About
		https://www.x.com/en-US/About

	d. همه یا بعضی از داده‌ها نیز چند زبانه می‌شوند و با هم ارتباط معنوی دارند

		اصلاح شود Routing در این حالت نیز باید

		Users Table

		Id
		Age
		FullName
		BirthDate
		Description

		Users Table		UserCultures

		Id				Id
		Age				CultureId
		BirthDate		FullName		Dariush Tasdighi	داریوش تصدیقی
						Description
**************************************************

**************************************************
**************************************************
**************************************************
Session (17)
**************************************************
**************************************************
**************************************************
1) In 'Shared' solution folder -> In 'Resources' project:

	- Change file names: 'fa' to 'fa-IR'

2) In 'Program.cs':

	- Before 'var app = builder.Build();':

// **************************************************
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
	var supportedCultures = new[]
	{
		new System.Globalization.CultureInfo(name: "fa-IR"),
		new System.Globalization.CultureInfo(name: "en-US"),
	};

	options.SupportedCultures = supportedCultures;
	options.SupportedUICultures = supportedCultures;

	options.DefaultRequestCulture =
		new Microsoft.AspNetCore.Localization
		.RequestCulture(culture: "fa-IR", uiCulture: "fa-IR");
});
// **************************************************

	- After 'var app = builder.Build();':

// **************************************************
// UseMiddleware -> using Microsoft.AspNetCore.Builder;
//app.UseMiddleware
//	<Infrastructure.Middlewares.CultureCookieHandlerMiddleware>();

// UseCultureCookie() -> using Infrastructure.Middlewares;
app.UseCultureCookie();
// **************************************************

3) In 'Infrastructure' Folder -> In 'Middlewares' Folder -> In 'CultureCookieHandlerMiddleware.cs' File:

	- Rename: CultureCookieHandlingMiddleware -> CultureCookieHandlerMiddleware

	- Injection in Constructor:

		Microsoft.Extensions.Options.IOptions
			<Microsoft.AspNetCore.Builder.RequestLocalizationOptions> requestLocalizationOptions

4) In 'Infrastructure' Folder -> In 'Middlewares' Folder:

	- Check 'ExtensionMethods.cs' File:

5) In 'Pages' Folder -> In 'ChangeCulture.cshtml.cs' File:

	- Injection in Constructor:

		Microsoft.Extensions.Options.IOptions
			<Microsoft.AspNetCore.Builder.RequestLocalizationOptions> requestLocalizationOptions

6) In 'Pages' Folder -> In 'Shared' Folder -> In 'PartialViews' Folder -> In '_ChangeCulture.cshtml' File:

	@inject Microsoft.Extensions.Options.IOptions
		<Microsoft.AspNetCore.Builder.RequestLocalizationOptions>? requestLocalizationOptions

7) In 'Pages' Folder -> In 'Shared' Folder -> In 'Layouts' Folder -> In 'Ltr' Folder -> In '_Layout.cshtml' File:

	var currentCultureName =
		System.Threading.Thread
		.CurrentThread.CurrentUICulture.Name;

8) In 'Pages' Folder -> In 'Shared' Folder -> In 'Layouts' Folder -> In 'Rtl' Folder -> In '_Layout.cshtml' File:

	var currentCultureName =
		System.Threading.Thread
		.CurrentThread.CurrentUICulture.Name;

9) In 'Pages' Folder -> In 'Shared' Folder -> In '_ViewStart.cshtml' File:

	کماکان همان است و تغییر نمی‌دهیم
	var currentCultureName =
		System.Threading.Thread.CurrentThread
		.CurrentUICulture.TwoLetterISOLanguageName;
**************************************************

**************************************************
Session (18)
**************************************************

1)
Install Packages:

	In 'Persistence':

		Microsoft.EntityFrameworkCore.SqlServer

			Microsoft.Data.SqlClient
			Microsoft.EntityFrameworkCore.Relational
				Microsoft.EntityFrameworkCore
				Microsoft.Extensions.Configuration.Abstractions

		Microsoft.EntityFrameworkCore.Tools

			Microsoft.EntityFrameworkCore.Design
				Humanizer.Core
				Microsoft.EntityFrameworkCore.Relational

		Microsoft.EntityFrameworkCore.Proxies

			Castle.Core
			Microsoft.EntityFrameworkCore

2)
	Domain Models -> Domain -> Culture01

	Data Access Layer -> Persistence -> DatabaseContext01

		Database.EnsureDeleted(); 
		Database.EnsureCreated();

	Presentation Layer -> Server -> Pages -> Admin -> Cultures01 -> Index

	Presentation Layer -> Server -> appsettings.Development.json -> ConnectionStrings -> ConnectionString01

	Presentation Layer -> Server -> Program.cs ->

		var connectionString =
			builder.Configuration.GetConnectionString("ConnectionString01");

	Presentation Layer -> Server -> Program.cs ->

		builder.Services.AddDbContext<Persistence.DatabaseContext01>(options =>
		{
			options
				// using Microsoft.EntityFrameworkCore;
				.UseLazyLoadingProxies()

				// using Microsoft.EntityFrameworkCore;
				.UseSqlServer(connectionString: connectionString);
		});
**************************************************

**************************************************
**************************************************
**************************************************
Session (19)
**************************************************
**************************************************
**************************************************

**************************************************
1)
	Domain Models -> Domain -> Culture02

	Data Access Layer -> Persistence -> DatabaseContext02 [Database.EnsureCreated();]

	Presentation Layer -> Server -> Pages -> Admin -> Cultures02 -> Index

	Presentation Layer -> Server -> appsettings.Development.json -> ConnectionStrings -> ConnectionString02

	Presentation Layer -> Server -> Program.cs ->

		var connectionString =
			builder.Configuration.GetConnectionString("ConnectionString02");

2)
	Domain Models -> Domain -> Culture03

	Data Access Layer -> Persistence -> DatabaseContext03 [Database.EnsureCreated();]

	Presentation Layer -> Server -> Pages -> Admin -> Cultures02 -> Index

	Presentation Layer -> Server -> appsettings.Development.json -> ConnectionStrings -> ConnectionString03

	Presentation Layer -> Server -> Program.cs ->

		var connectionString =
			builder.Configuration.GetConnectionString("ConnectionString03");
