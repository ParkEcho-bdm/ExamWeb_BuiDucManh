using ExamWeb_BuiDucManh.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_BuiDucManh.Controllers
{
    public class PhimController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PhimController(ApplicationDbContext db)
        {
            _db = db;
        }

        //hiển thị list book
        public IActionResult Index()
        {
            var dsPhim = _db.phims.ToList();
            var tongsoluong = _db.phims.Sum(x => x.ThoiLuong);
            ViewBag.SUM = tongsoluong;
            return View(dsPhim);
        }
        //hiển thị giao diện thêm sách
        public IActionResult Add()
        {
            return View();
        }

        //xử lý thêm sách
        [HttpPost]
        public IActionResult Add(Phim phim)
        {
            if (ModelState.IsValid)
            {
                _db.phims.Add(phim);
                _db.SaveChanges();
                TempData["success"] = "Đã thêm 1 phimh";
                return RedirectToAction("Index");
            }
            return View(phim);
        }

        //hiển thị giao diện cập nhật 
        public IActionResult Update(int id)
        {
            
            var phim = _db.phims.SingleOrDefault(x => x.Id == id);
            if (phim != null)
                return View(phim);

            return NotFound();
        }

        //xử lý sua sách
        [HttpPost]
        public IActionResult Update(Phim phim)
        {
            if (ModelState.IsValid)
            {
                _db.phims.Update(phim);
                _db.SaveChanges();
                TempData["success"] = "Đã cập nhật 1 phim";
                return RedirectToAction("Index");
            }
            return View(phim);
        }

    }
}