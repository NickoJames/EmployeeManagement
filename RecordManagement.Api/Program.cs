using RecordManagement.Application;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services
            .AddApplication()
            .AddInfrastructure();

            
builder.Services.AddControllers();

var app = builder.Build();

// Configure middleware

app.UseAuthorization();

// Configure endpoints
app.MapControllers();

app.Run();
