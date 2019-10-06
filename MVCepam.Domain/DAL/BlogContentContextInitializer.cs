using System.Collections.Generic;
using System.Data.Entity;

namespace MVCepam.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class BlogContentContextInitializer : CreateDatabaseIfNotExists<BlogContentContext>
    {
        protected override void Seed(BlogContentContext context)
        {
            var artic = new List<Article>
            {
                new Article
                {
                    Title = "Something",
                    Text = "else"
                },
                new Article
                {
                    Title = "1234124",
                    Text = "fgkdkfg"
                }
            };

            artic.ForEach(art => context.Articles.Add(art));
            context.SaveChanges();
        }
    }
}
