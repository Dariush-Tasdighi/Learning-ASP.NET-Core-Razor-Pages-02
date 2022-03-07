using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var webApplicationOptions =
	new Microsoft.AspNetCore.Builder.WebApplicationOptions
	{
		EnvironmentName =
			Microsoft.Extensions.Hosting.Environments.Development,

		//EnvironmentName =
		//	Microsoft.Extensions.Hosting.Environments.Production,
	};

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(options: webApplicationOptions);

// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddRazorPages();

// **************************************************
// https://www.connectionstrings.com/sql-server/
// **************************************************
// GetConnectionString() -> using Microsoft.Extensions.Configuration;
var connectionString =
	builder.Configuration.GetConnectionString("ConnectionString01");

//var connectionString =
//	builder.Configuration.GetConnectionString("ConnectionString02");

//var connectionString =
//	builder.Configuration.GetConnectionString("ConnectionString03");

//var connectionString =
//	builder.Configuration.GetConnectionString("ConnectionString04");

//var connectionString =
//	builder.Configuration.GetConnectionString("ConnectionString05");

// AddDbContext -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddDbContext<Persistence.DatabaseContext01>(options =>
{
	options
		// using Microsoft.EntityFrameworkCore;
		.UseLazyLoadingProxies();

	options
		// using Microsoft.EntityFrameworkCore;
		.UseSqlServer(connectionString: connectionString);
});
// **************************************************

var app =
	builder.Build();

// IsDevelopment() -> using Microsoft.Extensions.Hosting;
if (app.Environment.IsDevelopment())
{
	// UseDeveloperExceptionPage() -> using Microsoft.AspNetCore.Builder;
	app.UseDeveloperExceptionPage();
}
else
{
	// UseExceptionHandler() -> using Microsoft.AspNetCore.Builder;
	app.UseExceptionHandler("/Errors/Error");

	// The default HSTS value is 30 days.
	// You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts
	// UseHsts() -> using Microsoft.AspNetCore.Builder; 
	app.UseHsts();
}

// UseHttpsRedirection() -> using Microsoft.AspNetCore.Builder;
app.UseHttpsRedirection();

// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
app.UseStaticFiles();

app.Use(async (context, next) =>
{
	//var cultureInfo =
	//	new System.Globalization.CultureInfo(name: "fa");

	var cultureInfo =
		new System.Globalization.CultureInfo(name: "en");

	System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
	System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

	await next();
});

// UseRouting() -> using Microsoft.AspNetCore.Builder;
app.UseRouting();

//// UseAuthorization() -> using Microsoft.AspNetCore.Builder;
//app.UseAuthentication();

//// UseAuthorization() -> using Microsoft.AspNetCore.Builder;
//app.UseAuthorization();

// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
app.MapRazorPages();

app.Run();
