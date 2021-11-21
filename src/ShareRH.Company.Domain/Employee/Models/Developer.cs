using ShareRH.Company.Domain.Employee.Constants;
using ShareRH.Company.Domain.Employee.Enums;

namespace ShareRH.Company.Domain.Employee.Models
{
    /// <summary>
    /// Class to represents a developer.
    /// </summary>
    /// <inheritdoc />
    public class Developer : EmployeeBase
    {
        /// <inheritdoc />
        public override ContractTypes Type { get; }

        /// <inheritdoc />
        public override string Name { get; }

        /// <inheritdoc />
        public override Function Function => Function.Developer;

        /// <inheritdoc />
        public override int WorkHoursPerDay { get; }

        /// <summary>
        /// Initialize an object of <see cref="Developer"/>.
        /// </summary>
        /// <param name="name">The name of the employee contracted as <see cref="ContractTypes.Clt"/>.</param>
        /// <param name="contractType">The <see cref="ContractTypes"/> which the employee was contracted.</param>
        /// <param name="workHoursPerDay">The amount of hours that this worker must work in a day.</param>
        /// <param name="workHourValue">The value to pay for each hour worked by the employee.</param>
        public Developer(string name, ContractTypes contractType, int workHoursPerDay, double workHourValue) : base(workHourValue)
        {
            Name = name;
            Type = contractType;
            WorkHoursPerDay = workHoursPerDay;
        }

        /// <inheritdoc />
        public override double Salary() => (WorkHoursPerDay * EmployeeConstants.WorkDaysInMonth) * ValueByHourWorked;
    }
}
