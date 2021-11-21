using ShareRH.Company.Domain.Employee.Enums;
using ShareRH.Company.Domain.Employee.Models;

namespace ShareRH.Company.Application.Extensions
{
    /// <summary>
    /// Provides an extension methods for <see cref="Function"/> objects.
    /// </summary>
    public static class FunctionExtensions
    {
        /// <summary>
        /// Creates an instance of <see cref="IEmployee"/> based on the given <see cref="Function"/>, name, <see cref="ContractTypes"/> and how many hour to work.
        /// </summary>
        /// <param name="function">An instance of <see cref="Function"/>.</param>
        /// <param name="name">The name of the employee.</param>
        /// <param name="type">An instance of <see cref="ContractTypes"/>.</param>
        /// <param name="workHoursPerDay">How may hours the given employee was hired to work.</param>
        /// <returns></returns>
        public static IEmployee ToEmployee(this Function function, string name, ContractTypes type, int workHoursPerDay) => 
            function == Function.Developer 
                ? new Developer(name, type, workHoursPerDay, type.DeveloperHourValue()) 
                : new Manager(name, type, workHoursPerDay, type.ManagerHourValue());
    }
}
