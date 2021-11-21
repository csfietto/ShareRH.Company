﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShareRH.Company.Domain.Employee.Enums;
using ShareRH.Company.Domain.Employee.Models;
using ShareRH.Company.Domain.Employee.Service;
using ShareRH.Company.Domain.Responses;

namespace ShareRH.Company.API.Controllers
{
    /// <summary>
    /// An API controller that provide some employee functionalities.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// An instance of <see cref="IEmployeeService"/>
        /// </summary>
        private readonly IEmployeeService _employeeService;

        /// <summary>
        /// Initialize the Customer controller.
        /// </summary>
        /// <param name="employeeService">An instance of <see cref="IEmployeeService"/>.</param>
        public EmployeeController(IEmployeeService employeeService) => _employeeService = employeeService;

        /// <summary>
        /// An API to create and include a new <see cref="IEmployee"/>.
        /// </summary>
        /// <param name="function">Indicates which <see cref="Function"/> the employee will occupy.</param>
        /// <param name="name">The name of the employee.</param>
        /// <param name="type">The <see cref="ContractTypes"/> model which the employee will be hired.</param>
        /// <param name="workHoursPerDay">How many hours the given employee will work in a day.</param>
        /// <returns>An instance of <see cref="IActionResult"/> with a <see cref="Response"/> instance encapsulated.</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response))]
        public IActionResult Hire([FromHeader] Function function, [FromHeader] string name, [FromHeader] ContractTypes type, [FromHeader] int workHoursPerDay)
        {
            try
            {
                var response = _employeeService.Hire(function, name, type, workHoursPerDay);

                return Created("Employee//Hire", response);
            }
            catch (Exception ex)
            {
                return BadRequest(new Response {ErrorMessage = ex.StackTrace});
            }
        }
    }
}
