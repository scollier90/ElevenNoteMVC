using ElevenNote.Models;
using ElevenNote.Services;
using Microsoft.AspNet.Identity;
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
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NoteService(userId);
            var model = service.GetNotes();

            return View(model);
        }

        // GET: Note/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Note/Create
        [HttpPost]
        public ActionResult Create(NoteCreate model)
        {
            if (ModelState.IsValid)
            {
                var userID = Guid.Parse(User.Identity.GetUserId());
                var service = new NoteService(userID);
                service.CreateNote(model);

                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}