using ConfigCat.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Register ConfigCatClient as a singleton
builder.Services.AddSingleton<IConfigCatClient>(sp =>
{
    var client = new ConfigCatClient(options =>
    {
        options.SdkKey = "YOUR-SDK-KEY"; 
        options.PollingMode = PollingModes.AutoPoll(pollInterval: TimeSpan.FromSeconds(5));
    } );

    return client;
});

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
