namespace Kaddis.Framework.Utilities.Entities
{
    /// <summary>
    /// Web http response
    /// </summary>
    public class WebHttpLogResponse
    {
        /// <summary>
        /// Initializes a new instance of the WebHttpLogResponse class.
        /// </summary>
        public WebHttpLogResponse()
        {
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public WebHttpError Error { get; set; }

        /// <summary>
        /// Gets or sets the status code of the HTTP response.
        /// </summary>
        public StatusCode ResponseCode { get; set; }

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        /// <value>
        /// The messages.
        /// </value>
        public string Messages { get; set; }

        /// <summary>
        /// Gets or sets the validation response.
        /// </summary>
        /// <value>The validation response.</value>
        public ValidationResult ValidationResult { get; set; }

        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        public object StatusCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the action status.
        /// </summary>
        /// <value>The action status.</value>
        public bool ActionStatus { get; set; }
    }
}