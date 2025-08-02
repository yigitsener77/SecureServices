using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication("Bearer").AddJwtBearer("Bearer", options =>
    {
        options.Authority = "https://localhost:5001"; // IdentityServer URL, token'� kimin verdi�ini belirler.

        options.TokenValidationParameters = new TokenValidationParameters
        {
            // Token �zerindeki "audience" claim'ini kontrol etmemek i�in bu ayar� false yap�yoruz.
            // Ocelot kullan�l�rken genellikle bu ayar kullan�l�r.
            ValidateAudience = false,
        };
    });

builder.Services.AddAuthorization();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
