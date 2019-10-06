﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCepam.Domain
{
    /// <summary>
    /// Information about reviews
    /// </summary>
    public class Review : BaseEntity, IReview
    {
        /// <summary>
        /// A name of a person that wrote review
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The content of a review
        /// </summary>
        public string Text { get; set; }

        [Column(TypeName = "datetime2")]
        /// <summary>
        /// Date when the review was added
        /// </summary>
        public DateTime PublishTime { get; set; }
    }
}
