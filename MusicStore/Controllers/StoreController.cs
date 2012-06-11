﻿using System;
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

        MusicStoreEntities storeDB = new MusicStoreEntities();

        public ActionResult Index()
        {
            //TEM ALGUMA COISA ERRADA AQUI
            var genres = storeDB.Genres.ToList();
            
            return View(genres);
        }

        //
        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };

            return View(album);
        }

        //
        // GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };

            return View(genreModel);
        }
    }
}
