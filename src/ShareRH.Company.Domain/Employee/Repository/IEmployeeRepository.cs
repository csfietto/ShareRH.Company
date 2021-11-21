using ShareRH.Company.Domain.Employee.Models;

namespace ShareRH.Company.Domain.Employee.Repository
{
    /// <summary>
    /// A repository class for <see cref="IEmployee"/>s.
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Add into the repository an instance of <see cref="IEmployee"/>.
        /// </summary>
        void Add(IEmployee employee);
    }
}
