using System.Collections.Generic;

namespace MVCepam.Domain
{
    /// <summary>
    /// Article tags
    /// </summary>
    public class Tag : BaseEntity, ITag
    {
        /// <summary>
        /// A name of a tag
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Articles with this tag
        /// </summary>
        public ICollection<Article> Articles { get; set; }
    }
}
