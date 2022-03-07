**************************************************
Session (13)
**************************************************
1)
- Create Resource file in Resources project:

	DataDictionary.resx		(public)
	DataDictionary.fa.resx	(public)

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

2)
	Use resources in Index, About and Contact pages for their titles

3)
	Create a middleware in program.cs


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
