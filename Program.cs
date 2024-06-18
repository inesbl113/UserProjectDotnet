using Back.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Back.Data.UserContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDatabase")));


builder.Services.AddCors(options =>
{
	options.AddDefaultPolicy(
		builder =>
		{
			builder.WithOrigins("*")
				.AllowAnyHeader()
				.AllowAnyMethod();
		});
});


 builder.Services.AddDbContext<UserContext>();

var app = builder.Build();
app.UseCors();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
