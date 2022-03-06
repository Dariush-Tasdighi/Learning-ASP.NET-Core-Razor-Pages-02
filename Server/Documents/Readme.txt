**************************************************
Session (13)
**************************************************

)
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

)
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

)
	Use resources in Index, About and Contact pages for their titles

)
	Create a middleware in program.cs
