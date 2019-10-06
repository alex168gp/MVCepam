using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MVCepam.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class ArticleRepository : GenericRepository<Article>
    {
        public ArticleRepository(BlogContentContext context) : base(context) { }

        public ICollection<Tag> GetTags(int ArticleId)
        {
            IQueryable<Tag> query = context.Articles.Where(article => article.Id == ArticleId).SelectMany(article => article.Tags);
            return query.ToList();
        }
    }
}
