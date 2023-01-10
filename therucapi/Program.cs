using therucapi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder
    .Services
    .AddTheRucAPI();

builder
   .Services
   .AddGraphQLServer()
   .AddQueryType<Query>()
   .AddType<CountryGraphType>()
   .AddFiltering()
   .AddSorting()
   ;

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

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();

app.Run();
