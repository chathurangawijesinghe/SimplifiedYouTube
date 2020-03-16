using System;
using System.Collections.Generic;
using System.Text;

namespace Kaddis.Framework.Utilities.Entities
{
    /// <summary>
    /// ValidationResponse ENUM.
    /// </summary>
    public enum ValidationResponse
    {
        /// <summary>
        /// Gets or sets the Success state.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Gets or sets weather an internal error.
        /// </summary>
        InternalError = 1,

        /// <summary>
        /// Gets or sets weather an duplicate.
        /// </summary>
        Duplicate = 2,

        /// <summary>
        /// Get or sets weather an duplicate email.
        /// </summary>
        DuplicateEmail = 3,

        /// <summary>
        /// Get or sets weather a duplicate name.
        /// </summary>
        DuplicateName = 4,

        /// <summary>
        /// Get or sets weather the password is too weak
        /// </summary>
        PasswordIsTooWeak = 5,

        /// <summary>
        /// Get or sets weather the field is required.
        /// </summary>
        FieldIsRequired = 6,

        /// <summary>
        /// Get or sets weather the duplicate discount interval.
        /// </summary>
        DuplicateDiscountInterval = 7,

        /// <summary>
        /// Get or sets weather the already default available.
        /// </summary>
        AlreadyDefaultAvailable = 8,

        /// <summary>
        /// Get or sets weather the duplicate index base interval.
        /// </summary>
        DuplicateIndexBaseInterval = 9,

        /// <summary>
        /// Get or sets weather the value assigned.
        /// </summary>
        ValueAssigned = 10,

        /// <summary>
        /// Get or sets weather the duplicate station hours.
        /// </summary>
        DuplicateStationHours = 11,

        /// <summary>
        /// Get or sets weather the expired recover periods.
        /// </summary>
        ExpiredRecoverPeriods = 12,

        /// <summary>
        /// Get or sets weather the duplicate folder name.
        /// </summary>
        DuplicateFolderName = 13
    }
}
