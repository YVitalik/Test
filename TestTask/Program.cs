using Microsoft.EntityFrameworkCore;
using TestTask;
using TestTask.Interfaces;
using TestTask.Repositories;
using TestTask.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient<IAccountRepository, AccountRepository>();
builder.Services.AddTransient<IContactRepository, ContactRepository>();
builder.Services.AddTransient<IIncidentRepository, IncidentRepository>();

builder.Services.AddTransient<IAccountService, AccountService>();
builder.Services.AddTransient<IIncidentService, IncidentService>();
builder.Services.AddTransient<IContactService, ContactService>();
builder.Services.AddTransient<IRecordService, RecordService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
