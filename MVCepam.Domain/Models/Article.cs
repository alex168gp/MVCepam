using System;
using System.Collections.Generic;

namespace MVCepam.Domain
{
    /// <summary>
    /// A model for a blog articles
    /// </summary>
    public class Article : BaseEntity, IArticle
    {
        /// <summary>
        /// A title of an article
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A content of an article
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Tags of an article
        /// </summary>
        public ICollection<Tag> Tags { get; set; }

        /*
        /// <summary>
        /// A date when the article was published
        /// </summary>
        public DateTimeOffset PublicationTime { get; set; }
        */
    }
}
