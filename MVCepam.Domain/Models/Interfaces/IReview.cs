using System;

namespace MVCepam.Domain
{
    /// <summary>
    /// Information about reviews
    /// </summary>
    public interface IReview
    {
        /// <summary>
        /// A name of a person that wrote review
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The content of a review
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Date when the review was added
        /// </summary>
        DateTime PublishTime { get; set; }
    }
}
