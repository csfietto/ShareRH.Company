using ShareRH.Company.Domain.Employee.Models;

namespace ShareRH.Company.Domain.Responses
{
    /// <summary>
    /// A response object which requires an instance of <see cref="IEmployee"/>.
    /// </summary>
    public class EmployeeResponse
    {
        /// <summary>
        /// The identifier of the <see cref="IEmployee"/>.
        /// </summary>
        public string EmployeeIdentifier => Employee?.Id;

        /// <summary>
        /// An instance of <see cref="IEmployee"/>.
        /// </summary>
        public IEmployee Employee { get; set; }

        /// <summary>
        /// A <see cref="string"/> message to be filled in case of any errors in the operation.
        /// It will be empty in case of success.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
