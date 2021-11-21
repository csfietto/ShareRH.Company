using ShareRH.Company.Domain.Employee.Constants;
using ShareRH.Company.Domain.Employee.Enums;

namespace ShareRH.Company.Application.Extensions
{
    /// <summary>
    /// Provides an extension methods for <see cref="ContractTypes"/> objects.
    /// </summary>
    public static class ContractTypesExtensions
    {
        /// <summary>
        /// Returns the developer value by hour based on the given <see cref="ContractTypes"/>.
        /// </summary>
        /// <param name="contractType">An instance of <see cref="ContractTypes"/>.</param>
        /// <returns>A <see cref="double"/> representing the value of the hour for the developer.</returns>
        public static double DeveloperHourValue(this ContractTypes contractType)
        {
            return contractType == ContractTypes.Clt
                ? EmployeeConstants.DeveloperInitialValueByHourOnCltContracts
                : EmployeeConstants.DeveloperInitialValueByHourOnPjContracts;
        }

        /// <summary>
        /// Returns the manager value by hour based on the given <see cref="ContractTypes"/>.
        /// </summary>
        /// <param name="contractType">An instance of <see cref="ContractTypes"/>.</param>
        /// <returns>A <see cref="double"/> representing the value of the hour for the manager.</returns>
        public static double ManagerHourValue(this ContractTypes contractType)
        {
            return contractType == ContractTypes.Clt
                ? EmployeeConstants.ManagerInitialValueByHourOnCltContracts
                : EmployeeConstants.ManagerInitialValueByHourOnPjContracts;
        }
    }
}
