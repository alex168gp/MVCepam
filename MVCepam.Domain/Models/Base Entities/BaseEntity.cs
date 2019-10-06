namespace MVCepam.Domain
{
    /// <summary>
    /// A basic properties, required for all models
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// An id of an object
        /// </summary>
        public int Id { get; set; }
    }
}
