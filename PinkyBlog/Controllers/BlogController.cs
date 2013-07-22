using System;
using System.Web.Mvc;
using PinkyBlog.Models;

namespace PinkyBlog.Controllers
{
    public class BlogController : Controller
    {
         public ActionResult Index()
         {
             var post = new BlogPost
                 {
                     Title = "Pinky's First Blog Post!",
                     Published = DateTime.Today,
                     Body = "<p>Stay tuned!</p><p>Still working on it!</p>"
                 };

             return View(post);
         }
    }
}