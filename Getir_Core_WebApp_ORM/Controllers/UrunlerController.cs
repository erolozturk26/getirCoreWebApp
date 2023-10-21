﻿using AppDataAccess.Data;
using AppModel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Getir_Core_WebApp_ORM.Controllers
{
    public class UrunlerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UrunlerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objList = _db.Urunlers.ToList();
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create(Urunler obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(obj);



        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");

            }

            var ob = await _db.Urunlers.FindAsync(id);
            return View(ob);
        }
        [HttpPost]

        public async Task<IActionResult> Edit(Urunler ob)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ob);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            return View(ob);
        }
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var obj = await _db.Urunlers.FindAsync(id);
            return View(obj);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var obj = await _db.Urunlers.FindAsync(id);
            _db.Urunlers.Remove(obj);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
