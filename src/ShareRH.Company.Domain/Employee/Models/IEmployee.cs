using ShareRH.Company.Domain.Common;
using ShareRH.Company.Domain.Employee.Enums;

namespace ShareRH.Company.Domain.Employee.Models
{
    /// <summary>
    /// An interface that represent all employees in a company.
    /// </summary>
    /// <inheritdoc />
    public interface IEmployee : IStorable
    {
        /// <summary>
        /// Represent how the employee was contracted.
        /// </summary>
        ContractTypes Type { get; } 

        /// <summary>
        /// The name of the employee.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Represent what is the name of the position occupied by the employee.
        /// </summary>
        Function Function { get; }

        /// <summary>
        /// Represent how many hour per day the employee should work and also is the base of the payment calculation.
        /// </summary>
        int WorkHoursPerDay { get; }

        /// <summary>
        /// Returns the salary of the employee.
        /// </summary>
        /// <returns>A <see cref="double"/> value representing the salary of the employee.</returns>
        double Salary();
    }
}
