using Microsoft.AspNetCore.Http.Json;
var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<JsonOptions>(options =>{options.SerializerOptions.PropertyNamingPolicy = null;});
var app = builder.Build();
APIs.Init(ref app,new List<Type>{ typeof(UsersAPI) });
app.Run();
