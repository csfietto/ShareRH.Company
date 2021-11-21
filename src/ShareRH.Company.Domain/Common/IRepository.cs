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

        /// <summary>
        /// Returns the <see cref="IStorable"/> from the repository.
        /// </summary>
        /// <typeparam name="T">The type of the instance returned which must implements an <see cref="IStorable"/>.</typeparam>
        /// <param name="id">The <see cref="string"/> identifier of the <see cref="IStorable"/> item saved.</param>
        /// <returns>The <see cref="IStorable"/> item if any matched with the given identifier, otherwise a null instance.</returns>
        T Get<T>(string id) where T : IStorable;
    }
}
