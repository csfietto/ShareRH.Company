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

        /// <summary>
        /// Get an instance of <see cref="IEmployee"/> from the repository.
        /// </summary>
        /// <param name="id">The <see cref="IEmployee"/> identifier to select in the repository.</param>
        /// <returns>An instance of <see cref="IEmployeeRepository"/> that matched with the given identifier, otherwise a null instance.</returns>
        IEmployee Get(string id);
    }
}
