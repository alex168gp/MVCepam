using MVCepam.Domain;
using System.Collections.Generic;

namespace MVCepam.Web
{
    public class ArticleViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string Preview { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}