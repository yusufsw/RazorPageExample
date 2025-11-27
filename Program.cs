using RazorPageExample.Models;
using RazorPageExample.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddTransient<IEmployeeRepository, SQLEmployeeRepository>(); 
builder.Services.AddDbContext<DataContext>(); //Models/DataContext'te connection string mevcut

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
