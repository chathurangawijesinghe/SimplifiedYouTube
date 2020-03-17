namespace Kaddis.Framework.Utilities.Entities
{
    using System;

    /// <summary>
    /// Web http response
    /// </summary>
    /// <typeparam name="T">Generic object</typeparam>
    public class WebHttpResponse<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHttpResponse{T}"/> class.
        /// </summary>
        public WebHttpResponse()
        {
            if (typeof(T).Name != "String")
            {
                this.Data = (T)Activator.CreateInstance(typeof(T), new object[] { });
            }
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public T Data { get; set; }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        /// <value>
        /// The error.
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
        /// Gets or sets the response code.
        /// </summary>
        public object StatusCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the response's action status.
        /// </summary>
        /// <value>The action status.</value>
        public bool ActionStatus { get; set; }
    }
}
