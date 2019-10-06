using System.Data.Entity;

namespace MVCepam.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class BlogContentContext : DbContext
    {
        public BlogContentContext() : base("DefaultConnection")
        {
            Database.SetInitializer<BlogContentContext>(null);
        }

        public BlogContentContext(string nameOrConnectionString) : base(nameOrConnectionString) { }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}