using ShareRH.Company.Domain.Employee.Enums;
using ShareRH.Company.Domain.Employee.Models;
using ShareRH.Company.Domain.Responses;

namespace ShareRH.Company.Domain.Employee.Service
{
    /// <summary>
    /// Encapsulate the functions to manipulate the <see cref="IEmployee"/> instances.
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Creates a new employee and add in the company base list.
        /// </summary>
        /// <returns>An instance of <see cref="Response"/> with the result of the operation.</returns>
        public EmployeeResponse Hire(Function function, string name, ContractTypes type, int workHoursPerDay);

        /// <summary>
        /// Get an instance of <see cref="IEmployee"/> from the repository based on the given identifier.
        /// A null value will be returned in case of non-existent value.
        /// </summary>
        /// <param name="id">The identifier to be selected.</param>
        /// <returns>An instance of <see cref="IEmployee"/> that matched with the identifier.</returns>
        public EmployeeResponse Get(string id);
    }
}
