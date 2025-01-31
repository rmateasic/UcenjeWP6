using EdunovaAPP.Data;
using Microsoft.EntityFrameworkCore;

// Dobro dodatno ?itanje
// 1. https://medium.com/@robhutton8/entity-framework-vs-repository-pattern-vs-unit-of-work-9fa093bd59e4
// 2. https://www.thereformedprogrammer.net/is-the-repository-pattern-useful-with-entity-framework-core/
// 3. https://medium.com/@rabinarayandev/should-you-use-uuids-for-database-keys-597b15b000bb
// 4. https://blog.stackademic.com/goodbye-swagger-how-net-9-is-redefining-api-documentation-7488456a538f

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen();

// dodavanje konteksta baze podataka - dependency injection

builder.Services.AddDbContext<EdunovaContekst>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EdunovaContext"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapOpenApi();

app.UseHttpsRedirection();

app.UseAuthorization();

// dodati ove dvije linije za swager
app.UseSwagger();

app.UseSwaggerUI(o =>
{
    o.EnableTryItOutByDefault();
    o.ConfigObject.AdditionalItems.Add("requestSnippetsEnabled", true);
});

app.MapControllers();

app.Run();
