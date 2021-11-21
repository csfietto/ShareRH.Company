using System;
using ShareRH.Company.Domain.Common;
using ShareRH.Company.Domain.Employee.Enums;

namespace ShareRH.Company.Domain.Employee.Models
{
    /// <inheritdoc cref="IEmployee" />
    /// <inheritdoc cref="IStorable" />
    public abstract class EmployeeBase : IEmployee
    {
        public string Id { get; }

        /// <inheritdoc />
        public abstract ContractTypes Type { get; }

        /// <inheritdoc />
        public abstract string Name { get; }

        /// <inheritdoc />
        public abstract Function Function { get; }

        /// <inheritdoc />
        public abstract int WorkHoursPerDay { get; }

        /// <summary>
        /// The amount that should be paid to the employee for each hour worked.
        /// </summary>
        protected double ValueByHourWorked { get; set; } = 0;

        /// <summary>
        /// Creates an instance of <see cref="IEmployee"/> and set the value of each work hour.
        /// </summary>
        /// <param name="workHourValue">The value to pay for each hour worked by the employee.</param>
        protected EmployeeBase(double workHourValue)
        {
            ValueByHourWorked = workHourValue;
            Id = Guid.NewGuid().ToString();
        }

        /// <inheritdoc />
        public virtual double Salary() => 0;
    }
}
