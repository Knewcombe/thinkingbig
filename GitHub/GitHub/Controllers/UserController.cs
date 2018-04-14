using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHub.Controllers
{
    public class UserController : Controller
    {
        // GET: user from url
        public async System.Threading.Tasks.Task<ActionResult> Index(string username)
        {
            //ViewData["username"] = username;
            Console.WriteLine("This has started...");
            var github = new GitHubClient(new ProductHeaderValue(username));
            var user = await github.User.Get(username);
            ViewData["name"] = user.Name;
            ViewData["image"] = user.AvatarUrl;
            ViewData["username"] = user.Login;
            ViewData["bio"] = user.Bio;
            ViewData["location"] = user.Location;
            ViewData["work"] = user.Company;
            ViewData["link"] = user.Blog;
            
            return View();
        }
    }
}