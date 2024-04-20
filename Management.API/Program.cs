using Infrastructure.DataContext;
using Infrastructure.MappingProfiles;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlite("Data Source=../Data.db")
    );

//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//        options.UseSqlite("Data Source=app/Data.db")
//    );

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<IWhiskyService, WhiskyService>();
builder.Services.AddAutoMapper(typeof(AutoMappingProfile));

// TODO
//builder.Services.AddSingleton<ILoggerProvider, ResponseLoggerProvider>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
