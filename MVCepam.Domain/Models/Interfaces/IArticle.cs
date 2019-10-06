namespace MVCepam.Domain
{
    /// <summary>
    /// A model for a blog articles
    /// </summary>
    public interface IArticle
    {
        /// <summary>
        /// A title of an article
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// A content of an article
        /// </summary>
        string Text { get; set; }

        /*
        /// <summary>
        /// A date when the article was published
        /// </summary>
        public DateTimeOffset PublicationTime { get; set; }
        */
    }
}
