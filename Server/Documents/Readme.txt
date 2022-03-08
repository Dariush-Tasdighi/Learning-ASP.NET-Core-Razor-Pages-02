**************************************************
Session (13)
**************************************************
1)
	Run application and check it

2)
	Culture -> Almost -> Language

	2

		fa	en	fr	ar

	5

		fa-IR	en-US	en-US	fr-FR

3)
	We should have one and only one master resource!
		It's better master be in english!

	We can have zero or more slave resources!

	X.resx
	X.fa.rest
	X.fa-IR.rest
	X.fr-FR.rest

4)
	Steps

		A. Create a master resource file (X.resx)
		B. Change the access modifier to 'Public'
		C. Add some key value in master resource file
			key should not have and (.) or spacebar!
		D. Run custom tool
		E. Create a new resource (X.fa.resx)
		F. Copy all key value from master resource file to slave resource file
		G. Never change the access modifier of slave resource files 'No code generation'
		H. Slave resource files should not have designer!
		I. Check the 'Resources.csproj' file

5)
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
6)
	Use resources in below files:

		Pages ->
			Index
			About
			Contact

7)
	Pages:
		_ViewStart.cshtml

8)
	Pages:
		Shared:
			Layouts:
				Ltr:
					_Layout.cshtml
				Rtl:
					_Layout.cshtml

9)
	wwwroot:
		css:
			ltr:
				site.css
			Rtl:
				site.css

10)
	libman.json

		{
			"library": "flag-icon-css@4.1.5",
			"destination": "wwwroot/lib/flag-icon-css/"
		}

11)
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

12)
	Pages:
		Shared:
			PartialViews:
				_ChangeCulture.cshtml

					(Referer)

13)
	Pages:
		ChangeCulture.cshtml
			httpReferer!

14)
	Infrastructure:
		Middlewares:
			CultureCookieHandlingMiddleware.cs

15)
	Program.cs:
		app.UseMiddleware
			<Infrastructure.Middlewares.CultureCookieHandlingMiddleware>();
**************************************************

**************************************************
Session (14)
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
Session (15)
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
