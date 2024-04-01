
    using Infrastracture.Services;
    using Infrastracture.DataContext;

    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddControllers();
    builder.Services.AddScoped<DapperContext>();
    builder.Services.AddScoped<ICustomerService, CustomerService>();
    builder.Services.AddScoped<IManagementService, ManagementService>();

    var app = builder.Build();
    /*builder.Services.AddScoped(serviceProvider =>
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        return new DapperContext(connectionString);
    });*/

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();


    app.MapControllers();
    app.Run();

