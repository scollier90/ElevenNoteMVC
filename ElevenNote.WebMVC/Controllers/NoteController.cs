﻿using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    [Authorize]
    public class NoteController : Controller
    {
        // GET: Note/Index
        public ActionResult Index()
        {
            var model = new NoteListItem[0];
            return View(model);
        }

        // GET: Note/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}