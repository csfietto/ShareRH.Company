using System;
using ShareRH.Company.Application.Extensions;
using ShareRH.Company.Domain.Employee.Enums;
using ShareRH.Company.Domain.Employee.Repository;
using ShareRH.Company.Domain.Employee.Service;
using ShareRH.Company.Domain.Responses;

namespace ShareRH.Company.Application.Services
{
    /// <inheritdoc cref="IEmployeeService"/>
    public class EmployeeService : IEmployeeService
    {
        /// <summary>
        /// An instance of <see cref="IEmployeeRepository"/>.
        /// </summary>
        private readonly IEmployeeRepository _employeeRepository;

        /// <summary>
        /// Initialize an instance of <see cref="EmployeeService"/> that implements <see cref="IEmployeeService"/>.
        /// </summary>
        /// <param name="employeeRepository">An instance of <see cref="IEmployeeRepository"/>.</param>
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        /// <inheritdoc cref="IEmployeeService.Hire"/>
        public Response Hire(Function function, string name, ContractTypes type, int workHoursPerDay)
        {
            try
            {
                var employee = function.ToEmployee(name, type, workHoursPerDay);
                _employeeRepository.Add(employee);

                return new Response { Success = true };
            }
            catch (Exception e)
            {
                return new Response { ErrorMessage = e.StackTrace };
            }
        }
    }
}
