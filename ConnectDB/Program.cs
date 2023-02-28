using ConnectDB.AppContexts;
using ConnectDB.Models;

using (var context = new BloggingContext())
{
    // Create the database if it doesn't already exist
    context.Database.EnsureCreated();

    // Add a new Blog object
    var blog = new Blog { Url = "http://example.com" };
    context.Blogs.Add(blog);
    context.SaveChanges();
}
