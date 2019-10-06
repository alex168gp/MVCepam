using System.Collections.Generic;

namespace MVCepam.Domain
{
    /// <summary>
    /// Article tags
    /// </summary>
    public interface ITag
    {
        /// <summary>
        /// A name of a tag
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// An articles with this tag
        /// </summary>
        ICollection<Article> Articles { get; set; }
    }
}