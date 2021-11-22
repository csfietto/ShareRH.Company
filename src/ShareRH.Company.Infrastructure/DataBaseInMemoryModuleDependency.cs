using Microsoft.Extensions.DependencyInjection;
using ShareRH.Company.Domain.Common;
using ShareRH.Company.Domain.Employee.Repository;
using ShareRH.Company.Infrastructure.Contexts;
using ShareRH.Company.Infrastructure.Repositories;

namespace ShareRH.Company.Infrastructure
{
    /// <summary>
    /// Injects the application dependencies in the API scope.
    /// </summary>
    public static class DataBaseInMemoryModuleDependency
    {
        /// <summary>
        /// Export the application modules available
        /// </summary>
        /// <param name="services">An instance of <see cref="IServiceCollection"/></param>
        public static void AddDataBaseInMemoryModule(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IRepository, InMemoryDataBase>();
        }
    }
}
