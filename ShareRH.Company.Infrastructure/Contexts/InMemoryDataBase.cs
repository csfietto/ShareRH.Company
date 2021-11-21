using System.Collections.Generic;
using ShareRH.Company.Domain.Common;

namespace ShareRH.Company.Infrastructure.Contexts
{
    /// <summary>
    /// Represents an instance of <see cref="IRepository"/> which keep the data in memory.
    /// </summary>
    public class InMemoryDataBase : IRepository
    {
        /// <summary>
        /// The <see cref="IStorable"/> memory database.
        /// </summary>
        private static readonly Dictionary<string, IStorable> MemoryRepository = new();

        /// <inheritdoc />
        public void Add(IStorable storable) => 
            MemoryRepository.Add(storable.Id, storable);

        /// <inheritdoc />
        public T Get<T>(string id) where T : IStorable
        {
            MemoryRepository.TryGetValue(id, out var storable);
            return storable is not T stored 
                ? default 
                : stored;
        }
    }
}
