using System.Xml.XPath;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ShareRH.Company.Application;
using ShareRH.Company.Infrastructure;

namespace ShareRH.Company.API
{
    /// <summary>
    /// The APIs startup operation.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Creates an instance of <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">An instance of <see cref="IConfiguration"/>.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// An instance of <see cref="IConfiguration"/>.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">An instance of <see cref="IServiceCollection"/></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDataBaseInMemoryModule();
            services.AddApplicationModule();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ShareRH.Company.API", Version = "v1" });
                c.IncludeXmlComments(() => new XPathDocument(@".\ShareRH.Company.API.xml"));
            });
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">An instance of <see cref="IApplicationBuilder"/>.</param>
        /// <param name="env">An instance of <see cref="IWebHostEnvironment"/>.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ShareRH.Company.API v1"));
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
}
