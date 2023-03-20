using Bootcamp_CKres_Minor;
using Bootcamp_CKres_Minor.Helper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SchoolDBContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"))
);
builder.Services.AddScoped<GenderHelper>();
builder.Services.AddScoped<ReligionHelper>();
builder.Services.AddScoped<StudentHelper>();
builder.Services.AddScoped<GradeHelper>();
builder.Services.AddScoped<SubjectHelper>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
