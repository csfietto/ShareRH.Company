namespace ShareRH.Company.Domain.Employee.Enums
{
    /// <summary>
    /// Enumerates the types of contracts that can have in a company.
    /// </summary>
    public enum ContractTypes
    {
        /// <summary>
        /// It is a contract type where the employee was contracted using the CPF document and not as a company based on government rules.
        /// </summary>
        Clt,

        /// <summary>
        /// Represents a type of contract where the employee was contracted as a company.
        /// </summary>
        Pj
    }
}
