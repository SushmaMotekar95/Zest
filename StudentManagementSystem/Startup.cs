﻿using Microsoft.EntityFrameworkCore;

using StudentManagementSystem.DatabaseConnection;
using StudentManagementSystem.StudentServices;

public class Startup
{
    public IConfiguration Configuration { get; }




    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped<StudentService, StudentServiceImplementation>();
        services.AddControllers();  
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
