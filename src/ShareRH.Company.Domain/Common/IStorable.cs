namespace ShareRH.Company.Domain.Common
{
    /// <summary>
    /// Represents any object that can be stored.
    /// </summary>
    public interface IStorable
    {
        /// <summary>
        /// The identifier of the object that can be stored.
        /// </summary>
        string Id { get; }
    }
}
