using ShareRH.Company.Domain.Common;
using ShareRH.Company.Domain.Employee.Models;
using ShareRH.Company.Domain.Employee.Repository;

namespace ShareRH.Company.Infrastructure.Repositories
{
    /// <inheritdoc />
    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// The <see cref="IEmployee"/> memory database.
        /// </summary>
        private readonly IRepository _repository;

        /// <summary>
        /// Initialize an instance of <see cref="EmployeeRepository"/> which provides an implementation of <see cref="IEmployeeRepository"/>.
        /// </summary>
        /// <param name="repository">An instance of <see cref="IRepository"/>.</param>
        public EmployeeRepository(IRepository repository)
        {
            _repository = repository;
        }

        /// <inheritdoc />
        public void Add(IEmployee employee) => _repository.Add(employee);

        /// <inheritdoc />
        public IEmployee Get(string id) => _repository.Get<IEmployee>(id);
    }
}
