namespace ShareRH.Company.Domain.Responses
{
    /// <summary>
    /// Encapsulate the information related to the responses that can be returned to the APIs.
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Represents the status of the execution. It will be set as TRUE when the operation finished successfully.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Once the execution failed, this property will be set with the stack trace of the issue.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
