using Microsoft.Extensions.DependencyInjection;
using ShareRH.Company.Application.Services;
using ShareRH.Company.Domain.Employee.Service;

namespace ShareRH.Company.Application
{
    /// <summary>
    /// Injects the application dependencies in the API scope.
    /// </summary>
    public static class ApplicationModuleDependency
    {
        /// <summary>
        /// Export the application modules available
        /// </summary>
        /// <param name="services">An instance of <see cref="IServiceCollection"/></param>
        public static void AddApplicationModule(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
        }
    }
}
