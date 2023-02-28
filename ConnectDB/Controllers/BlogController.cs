using ConnectDB.AppContexts;
using ConnectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB.Controllers
{
    public class BlogController
    {
        private readonly BloggingContext _bloggingContext;
        public BlogController()
        {
            _bloggingContext = new BloggingContext();
        }

        public void AddBlog(Blog blog,bool commit = true)
        {
            _bloggingContext.Add(blog);
            if(commit) _bloggingContext.SaveChanges();
        }

    }
}
