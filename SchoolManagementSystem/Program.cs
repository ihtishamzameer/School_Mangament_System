using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SchoolManagementSystem.Api.JWT;
using SchoolManagementSystem.Application.Interfaces;
using SchoolManagementSystem.Infrastructure.Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

var jwt = builder.Configuration.GetSection("Jwt");

// ─────────────────────────────────────────────
// DATABASE
// ─────────────────────────────────────────────
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IApplicationDbContext>(provider =>
    provider.GetRequiredService<ApplicationDbContext>());

// ─────────────────────────────────────────────
// MEDIATR (CQRS)
// ─────────────────────────────────────────────
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(IApplicationDbContext).Assembly));

// ─────────────────────────────────────────────
// JWT AUTHENTICATION (CRITICAL)
// ─────────────────────────────────────────────
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = jwt["Issuer"],
        ValidAudience = jwt["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(jwt["Key"]!))
    };
});

// ─────────────────────────────────────────────
// AUTHORIZATION
// ─────────────────────────────────────────────
builder.Services.AddAuthorization();

// ─────────────────────────────────────────────
// CONTROLLERS
// ─────────────────────────────────────────────
builder.Services.AddControllers();

// ─────────────────────────────────────────────
// CORS
// ─────────────────────────────────────────────
builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactAppPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// ─────────────────────────────────────────────
// SWAGGER
// ─────────────────────────────────────────────
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ─────────────────────────────────────────────
// CUSTOM SERVICES
// ─────────────────────────────────────────────
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<JwtTokenService>();

var app = builder.Build();

// ─────────────────────────────────────────────
// MIDDLEWARE PIPELINE (ORDER IS CRITICAL)
// ─────────────────────────────────────────────
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("ReactAppPolicy");

// 🔴 IMPORTANT: AUTHENTICATION MUST COME BEFORE AUTHORIZATION
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();