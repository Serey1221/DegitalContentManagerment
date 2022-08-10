using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DegitalContentManagerment.Models;
using DegitalContentManagerment.Data;




namespace DegitalContentManagerment.Controllers
{
    public class LeturerController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly DataContext _context;

        public LeturerController(IWebHostEnvironment env, DataContext context)
        {
            _env = env;
            _context = context;
        }

        // GET: LeturerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LeturerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LeturerController/Create
        public IActionResult Create()
        {
           
            return View("create");
        }

        // POST: LeturerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Leturer leturer , IFormFile file)
        {
            if (file.Length>0 && file != null)
            {
                //var uploadFile = Path.GetFileName(file.FileName);
                //return Content($"{uploadFile}");
                var uploadFile = Path.GetFileName(file.FileName);
                var destination = Path.Combine(_env.WebRootPath, "Profiles", uploadFile);
                leturer.ImageFile = uploadFile;

                var fileStream = new FileStream(destination, FileMode.Create);
                await file.CopyToAsync(fileStream);

                await _context.Leturers.AddAsync(leturer);
                await _context.SaveChangesAsync();
            }
            return View("Index");
        }
        public IActionResult GetsAllProfile()
        {
            var profiles = _context.Leturers.ToList();
            return View(profiles);
        }
        // GET: LeturerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LeturerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LeturerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LeturerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
