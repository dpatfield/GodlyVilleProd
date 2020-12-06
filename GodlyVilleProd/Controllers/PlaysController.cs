using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GodlyVilleProd.Models;
using GodlyVilleProd.ViewModels;

namespace GodlyVilleProd.Controllers
{
    public class PlaysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlaysController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Plays
        public ActionResult Index()
        {
            var plays = _context.Plays.ToList();

            if (User.IsInRole(RoleName.CanManagePlays))
                return View("List", plays);

            return View("ReadOnlyList", plays);
        }

        public ActionResult Details(int id)
        {
            var play = _context.Plays.SingleOrDefault(p => p.Id == id);

            return View(play);
        }

        [Authorize(Roles = RoleName.CanManagePlays)]
        public ActionResult New()
        {

            var viewModel = new PlayFormViewModel() { };

            return View("PlayForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManagePlays)]
        public ActionResult Edit(int id)
        {
            var play = _context.Plays.SingleOrDefault(p => p.Id == id);

            if (play == null)
                return HttpNotFound();

            var viewModel = new PlayFormViewModel(play) { };

            return View("PlayForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManagePlays)]
        public ActionResult Save(Play play)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new PlayFormViewModel(play);
                return View("PlayForm", viewModel);
            }
       
            if(play.Id == 0)
            {
                _context.Plays.Add(play);    
            }
            else
            {
                var playInDb = _context.Plays.Single(p => p.Id == play.Id);
                playInDb.Id = play.Id;
                playInDb.Name = play.Name;
                playInDb.IsMusical = play.IsMusical;
                playInDb.NumberOfActs = play.NumberOfActs;
                playInDb.DurationInMinutes = play.DurationInMinutes;
                playInDb.Description = play.Description;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Plays");
        }
    }
}