namespace Kaddis.Framework.Utilities.Entities
{
    using System;

    /// <summary>
    /// Validation error.
    /// </summary>
    [Serializable]
    public class ValidationError
    {
        /// <summary>
        /// Gets or sets the type of the status.
        /// </summary>
        /// <value>The type of the status.</value>
        public ValidationStatus StatusType { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>The field.</value>
        public string Field { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        /// <value>The response.</value>
        public ValidationResponse ResponseType { get; set; }
    }
}