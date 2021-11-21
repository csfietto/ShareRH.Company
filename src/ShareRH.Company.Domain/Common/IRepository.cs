namespace ShareRH.Company.Domain.Common
{
    /// <summary>
    /// Provides the expected methods for a repository instance.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Add a new instance of <see cref="IStorable"/> objects into the repository.
        /// </summary>
        /// <param name="storable">Any <see cref="IStorable"/> instance.</param>
        void Add(IStorable storable);
    }
}
