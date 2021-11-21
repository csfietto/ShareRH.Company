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
        public Response Hire(Function function, string name, ContractTypes type, int workHoursPerDay);
    }
}
