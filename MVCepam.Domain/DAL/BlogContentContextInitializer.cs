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
            var articles = new List<Article>
            {
                new Article
                {
                    Title = "First article",
                    Text = "The repository and unit of work patterns are intended to create an abstraction layer between the data access layer and the business logic layer of an application. Implementing these patterns can help insulate your application from changes in the data store and can facilitate automated unit testing or test-driven development (TDD)." +
                    "In this tutorial you'll implement a repository class for each entity type. For the Student entity type you'll create a repository interface and a repository class. When you instantiate the repository in your controller, you'll use the interface so that the controller will accept a reference to any object that implements the repository interface. When the controller runs under a web server, it receives a repository that works with the Entity Framework. When the controller runs under a unit test class, it receives a repository that works with data stored in a way that you can easily manipulate for testing, such as an in-memory collection." +
                    "Later in the tutorial you'll use multiple repositories and a unit of work class for the Course and Department entity types in the Course controller. The unit of work class coordinates the work of multiple repositories by creating a single database context class shared by all of them. If you wanted to be able to perform automated unit testing, you'd create and use interfaces for these classes in the same way you did for the Student repository. However, to keep the tutorial simple, you'll create and use these classes without interfaces."
                },
                new Article
                {
                    Title = "Second article",
                    Text = "In the original version of the code, students is typed as an IQueryable object. The query isn't sent to the database until it's converted into a collection using a method such as ToList, which doesn't occur until the Index view accesses the student model. The Where method in the original code above becomes a WHERE clause in the SQL query that is sent to the database. That in turn means that only the selected entities are returned by the database. However, as a result of changing context.Students to studentRepository.GetStudents(), the students variable after this statement is an IEnumerable collection that includes all students in the database. The end result of applying the Where method is the same, but now the work is done in memory on the web server and not by the database. For queries that return large volumes of data, this can be inefficient."
                }
            };

            var reviews = new List<Review>
            {
                new Review
                {
                    Name = "First name",
                    Text = "First review"
                },
                new Review
                {
                    Name = "Second name",
                    Text = "In the original version of the code, students is typed as an IQueryable object. The query isn't sent to the database until it's converted into a collection using a method such as ToList, which doesn't occur until the Index view accesses the student model. The Where method in the original code above becomes a WHERE clause in the SQL query that is sent to the database. That in turn means that only the selected entities are returned by the database. However, as a result of changing context.Students to studentRepository.GetStudents(), the students variable after this statement is an IEnumerable collection that includes all students in the database. The end result of applying the Where method is the same, but now the work is done in memory on the web server and not by the database. For queries that return large volumes of data, this can be inefficient."
                }
            };

            articles.ForEach(art => context.Articles.Add(art));
            reviews.ForEach(rev => context.Reviews.Add(rev));
            context.SaveChanges();
        }
    }
}
