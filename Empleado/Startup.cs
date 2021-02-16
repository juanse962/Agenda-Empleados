using EmpleadoController.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpleadoController
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors( options => options.AddPolicy("AllowWeb", 
                builder => builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod()));

            services.AddDbContext<EmpleadoContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            services.AddSwaggerGen( config => 
            config.SwaggerDoc("v1", new OpenApiInfo { Title = "Mi lista de empleados", Version = "v1" } )); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI( config => {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "Lista de Empleados V1");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseCors("AllowWeb");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
