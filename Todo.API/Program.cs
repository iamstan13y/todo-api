using Microsoft.EntityFrameworkCore;
using Todo.API.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

var app = builder.Build();

///app.UseHttpsRedirection();

app.Run();