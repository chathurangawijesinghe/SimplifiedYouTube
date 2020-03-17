namespace Kaddis.Framework.Utilities.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The Validation Response
    /// </summary>
    [Serializable]
    public class ValidationResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether the result is success.
        /// </summary>
        /// <value>The result.</value>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Gets or sets a value validations.
        /// </summary>
        /// <value>The validations.</value>
        public List<ValidationError> Validations { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is global validation.
        /// </summary>
        /// <value>The is global validation.</value>
        public bool IsGlobalValidation { get; set; }

        /// <summary>
        /// Gets or sets a value the global validations.
        /// </summary>
        /// <value>The global validations.</value>
        public List<ValidationError> GlobalValidations { get; set; }

        /// <summary>
        /// Gets or sets a value password strength errors.
        /// </summary>
        public Dictionary<int, int> PasswordStrengthErrors { get; set; }

        /// <summary>
        /// Gets or sets a value the ref id.
        /// </summary>
        /// <value>The ref id.</value>
        public int RefId { get; set; }
    }
}