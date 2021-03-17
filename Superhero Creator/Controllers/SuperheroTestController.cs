using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superhero_Creator.Models;
using Superhero_Creator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Superhero_Creator.Controllers
{
    public class SuperheroTest : Controller
    {
        //start of setup access to database
        private ApplicationDbContext _context;//why not make new one? because the application automatically serves into parameter

        public SuperheroTest(ApplicationDbContext context)
        {
            _context = context;
        }
        //end of setup of access to database in any controller
        // GET: SuperheroTest
        public IActionResult Index()
        {
            var superheroes = _context.Superheroes;
            return View(superheroes);
        }

        // GET: SuperheroTest/Details/5
        public IActionResult Details(int id)
        {
            var superheroDetails = _context.Superheroes.Where(d => d.Id == id).Select(d => d).FirstOrDefault();
            return View(superheroDetails);
        }
       

        // GET: SuperheroTest/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SuperheroTest/Create
        [HttpPost]
       
        public IActionResult Create(Superhero superhero)
        {
            _context.Superheroes.Add(superhero);
            _context.SaveChanges();
            return RedirectToAction("Index");
         
        }
        public IActionResult Delete(int id)
        {
            var del = _context.Superheroes.Where(d => d.Id == id).Select(d => d).FirstOrDefault();
            return View(del);
        }

        // GET: SuperheroTest/Edit/5
        public IActionResult Edit(int id)
        {
            var edit = _context.Superheroes.Where(e => e.Id == id).Select(e => e).FirstOrDefault();
            return View(edit);
        }

        // POST: SuperheroTest/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            var superheroToBeChanged = _context.Superheroes.Where(s => s.Id == id).Select(s => s).FirstOrDefault();
            superheroToBeChanged.Name = collection["Name"];
            superheroToBeChanged.AlterEgoName = collection["AlterEgoName"];
            superheroToBeChanged.PrimarySuperheroAbility = collection["PrimarySuperheroAbility"];
            superheroToBeChanged.SecondarySuperheroAbility = collection["SecondarySuperheroAbility"];
            superheroToBeChanged.Catchphrase = collection["Catchphrase"];

            _context.SaveChanges();
            return RedirectToAction("Index");
            
        }


        // GET: SuperheroTest/Delete/5
        [HttpPost]
        public IActionResult Delete(Superhero superhero)
        {
           
            _context.Superheroes.Remove(superhero);
            _context.SaveChanges();
            return RedirectToAction("Index");

           
        }

      
    }
}
