using ProjectSuperhero.Data;
using ProjectSuperhero.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies; // Added for Cookie Authentication constants

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ProjectSuperheroContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ProjectSuperheroContext") ?? throw new InvalidOperationException("Connection string 'ProjectSuperheroContext' not found.")));

// 1. ADDED: Configure Razor Pages folder conventions and security policies
builder.Services.AddRazorPages(options =>
{
    // Restricts the entire /Admin folder to users who pass the RequireAdminRole policy
    options.Conventions.AuthorizeFolder("/Admin", "RequireAdminRole");
});

// 2. ADDED: Configure Cookie Authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";
        options.AccessDeniedPath = "/Account/AccessDenied";
    });

// 3. ADDED: Define what the "RequireAdminRole" policy checks for
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Administrator"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

// 4. MODIFIED: UseAuthentication MUST run right before UseAuthorization
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();