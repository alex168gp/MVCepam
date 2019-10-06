using MVCepam.Domain;
using System.Linq;
using System.Web.Mvc;

namespace MVCepam.Web
{
    public class HomeController : Controller
    {

        private GenericRepository<Article> repository;

        public HomeController()
        {
            this.repository = new GenericRepository<Article>(new BlogContentContext());
        }

        public ActionResult Index()
        {
            var DBArticles = repository.Get();
            ArticlesViewModel articlesViewModel = new ArticlesViewModel();


            var articles = DBArticles.Select(x => new ArticleViewModel() { 
                Id = x.Id,
                Title = x.Title, 
                Text = x.Text,
                // if text of an article is less than 200 symbols, preview all the text, 
                // otherwise, take text until the last word in first 200 symbols
                Preview = x.Text.Substring(0, x.Text.Length <= 200 ? x.Text.Length : x.Text.Substring(0, 200).LastIndexOf(' ')) + " ..."
                }).Take(20).ToList();

            articlesViewModel.Articles = articles;

            return View(articlesViewModel);
        }

        public ActionResult ShowArticle(int? id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var article = repository.GetByID(id);
            if (article == null)
            {
                return RedirectToAction("Index");
            }
            ArticleViewModel articleViewModel = new ArticleViewModel();
            articleViewModel.Title = article.Title;
            articleViewModel.Text = article.Text;

            return View(articleViewModel);
        }
    }
}