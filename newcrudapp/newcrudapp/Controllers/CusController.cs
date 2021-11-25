using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using newcrudapp.Models;
using Microsoft.EntityFrameworkCore;

namespace newcrudapp.Controllers
{
    public class CusController : Controller

    {
        private readonly ApplicationDbContext _db;

        public CusController(ApplicationDbContext db)

        {
            _db = db;
           
        }
        public IActionResult Index()
        {
            var displaydata = _db.customer.ToList();
            return View(displaydata);
        }
        //load the form
        public IActionResult Create()
        {
            return View();
        }
        //form ekken data base load karanna


        [HttpPost]
        public async Task<IActionResult>Create(NewCusClass nec)
            
        {
            if (ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nec);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("Index");
            }

            var getcusdetails = await _db.customer.FindAsync(id);
            return View(getcusdetails);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(NewCusClass nc)
        {
            if (ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nc);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getcusdetails = await _db.customer.FindAsync(id);
            return View(getcusdetails);

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getcusdetails = await _db.customer.FindAsync(id);
            return View(getcusdetails);

        }
        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
            

            var getcusdetails = await _db.customer.FindAsync(id);
            _db.customer.Remove(getcusdetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}