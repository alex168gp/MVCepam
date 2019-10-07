using MVCepam.Domain;
using System.Linq;
using System.Web.Mvc;

namespace MVCepam.Web
{
    public class HomeController : Controller
    {

        private ArticleRepository repository;

        public HomeController()
        {
            var temp = new BlogContentContext();
            this.repository = new ArticleRepository(temp);
            using (BlogContentContext db = new BlogContentContext())
            {
                ViewBag.PollQuestion = db.Polls.FirstOrDefault(poll => poll.Id == 1).Question;
                ViewBag.PollOptions = db.Polls.Where(poll => poll.Id == 1).SelectMany(poll => poll.Options).Select(options => options.Value).ToList();
            }
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
            articleViewModel.Tags = repository.GetTags(article.Id);

            return View(articleViewModel);
        }

        [HttpPost]
        public ActionResult Voting(string Voting)
        {
            using (BlogContentContext db = new BlogContentContext())
            {
                var option = db.PollOptions.FirstOrDefault(opt => opt.Value == Voting);
                option.Votes++;
                db.SaveChanges();
            }
            return Redirect(Request.UrlReferrer.PathAndQuery);
        }
    }
}