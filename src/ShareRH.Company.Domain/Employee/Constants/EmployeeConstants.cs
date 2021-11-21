using ShareRH.Company.Domain.Employee.Enums;

namespace ShareRH.Company.Domain.Employee.Constants
{
    /// <summary>
    /// Constants values related to employee methods and properties.
    /// </summary>
    public static class EmployeeConstants
    {
        /// <summary>
        /// Represents the quantity of work available days in a month to calculate the salary.
        /// </summary>
        public const int WorkDaysInMonth = 30;

        /// <summary>
        /// Represents the hour value for a developer contracted as a <see cref="ContractTypes.Clt"/>.
        /// </summary>
        public const double DeveloperInitialValueByHourOnCltContracts = 100;

        /// <summary>
        /// Represents the hour value for a developer contracted as a <see cref="ContractTypes.Pj"/>.
        /// </summary>
        public const double DeveloperInitialValueByHourOnPjContracts = 300;

        /// <summary>
        /// Represents the hour value for a developer contracted as a <see cref="ContractTypes.Clt"/>.
        /// </summary>
        public const double ManagerInitialValueByHourOnCltContracts = 200;

        /// <summary>
        /// Represents the hour value for a developer contracted as a <see cref="ContractTypes.Pj"/>.
        /// </summary>
        public const double ManagerInitialValueByHourOnPjContracts = 600;

        /// <summary>
        /// Represents a percentage as a bonus for the manager.
        /// </summary>
        public const double ManagerBonusMultiplier = 1.1;
    }
}
