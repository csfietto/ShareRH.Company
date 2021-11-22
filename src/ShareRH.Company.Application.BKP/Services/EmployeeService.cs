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
        public EmployeeResponse Hire(Function function, string name, ContractTypes type, int workHoursPerDay)
        {
            try
            {
                var employee = function.ToEmployee(name, type, workHoursPerDay);
                _employeeRepository.Add(employee);

                return new EmployeeResponse { Employee = employee };
            }
            catch (Exception e)
            {
                return new EmployeeResponse { ErrorMessage = e.StackTrace };
            }
        }

        /// <inheritdoc cref="IEmployeeService.Get"/>
        public EmployeeResponse Get(string id)
        {
            try
            {
                var employee = _employeeRepository.Get(id);
                if (employee == null)
                    throw new Exception("Employee was not found!");

                return new EmployeeResponse { Employee = employee };
            }
            catch (Exception e)
            {
                return new EmployeeResponse { ErrorMessage = e.ToString() };
            }
        }
    }
}
