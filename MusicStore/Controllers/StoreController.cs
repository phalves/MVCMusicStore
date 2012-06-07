using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public string Index()
        {
            return "Hello from Store.Index()";
        }

        //
        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album" + id };

            return View(album);
        }

        //
        // GET: /Store/Browse?genre=Disco

        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre =" + genre);
            return message;
        }
    }
}
