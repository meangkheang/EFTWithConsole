using ConnectDB.AppContexts;
using ConnectDB.Controllers;
using ConnectDB.Models;

BlogController _blogController = new BlogController();


_blogController.AddBlog(new Blog() { Url="http://localhost:8000"});