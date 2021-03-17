using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Codedy.StarSecurity.WebApp.Models.Catalog.Services;
using Microsoft.AspNetCore.Http;
using System.IO;
using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        private readonly IServicesService _context;

        public ServicesController(IServicesService context)
        {
            _context = context;
        }

        // GET: Admin/Services
        public IActionResult Index()
        {
            var info = _context.Services();
            return View(info);
        }

        // GET: Admin/Services/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = _context.Service(id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Admin/Services/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,CategoryId,Title,Description,Image,Price,PromotionPrice,IsActive,IsFeatured,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] Service service)
        {
            if (ModelState.IsValid)
            {
                service.Id = Guid.NewGuid();
                _context.Create(service);
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }


        // GET: Admin/Services/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = _context.Service(id);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }

        // POST: Admin/Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,CategoryId,Title,Description,Image,Price,PromotionPrice,IsActive,IsFeatured,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] Service service)
        {
            if (id != service.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Edit(service);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.ServiceExists(service.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }

        // GET: Admin/Services/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = _context.Service(id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Admin/Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _context.Detele(id);
            return RedirectToAction(nameof(Index));
        }


        //[HttpPost]
        //public ActionResult UpdateImage(Service service, IEnumerable<HttpPostedFileBase> file, int? id)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var supportedPicTypes = new[] { "jpg", "jpeg", "png" };
        //        var supportedPdfTypes = new[] { "pdf", "doc", "docx" };
        //        var PicFileSize = 200000;
        //        var PdfFileSize = 1000000;


        //        if (file.ElementAt(0) != null && file.ElementAt(1) != null)
        //        {
        //            if (file.ElementAt(0).ContentLength > (PicFileSize))
        //            {
        //                ViewBag.Message = "Image Size should be less than 2mb";
        //            }
        //            else if (!supportedPicTypes.Contains(System.IO.Path.GetExtension(file.ElementAt(0).FileName).Substring(1)))
        //            {
        //                ViewBag.Message = "Image Extension is not valid";
        //            }
        //            else if (file.ElementAt(1).ContentLength > (PdfFileSize))
        //            {
        //                ViewBag.Message = "File Size should be less than 10mb";
        //            }
        //            else if (!supportedPdfTypes.Contains(System.IO.Path.GetExtension(file.ElementAt(1).FileName).Substring(1)))
        //            {
        //                ViewBag.Message = "File Extension is not valid";
        //            }
        //            else
        //            {
        //                using (MyDbContext db = new MyDbContext())
        //                {


        //                    var produc = db.products.Where(x => x.ProductId == id).FirstOrDefault();
        //                    if (produc != null)
        //                    {
        //                        ViewBag.Message = "Record Already Exist!";
        //                        string Upath = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(file.ElementAt(0).FileName));
        //                        file.ElementAt(0).SaveAs(Upath);

        //                        string Upth = Path.Combine(Server.MapPath("~/PdfFiles"), Path.GetFileName(file.ElementAt(1).FileName));
        //                        file.ElementAt(1).SaveAs(Upth);

        //                        Product p = new Product
        //                        {
        //                            ProductId = (int)id,
        //                            ProductName = product.ProductName,
        //                            Image = "~/Images/" + file.ElementAt(0).FileName,
        //                            Pdf = "~/PdfFiles/" + file.ElementAt(1).FileName
        //                        };
        //                        db.Entry(produc).CurrentValues.SetValues(p);
        //                        db.SaveChanges();
        //                        ViewBag.Message = "Record Already Exist!";

        //                    }
        //                    else
        //                    {
        //                        string path = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(file.ElementAt(0).FileName));
        //                        file.ElementAt(0).SaveAs(path);

        //                        string pth = Path.Combine(Server.MapPath("~/PdfFiles"), Path.GetFileName(file.ElementAt(1).FileName));
        //                        file.ElementAt(1).SaveAs(pth);

        //                        db.products.Add(new Product
        //                        {
        //                            ProductId = product.ProductId,
        //                            ProductName = product.ProductName,
        //                            Image = "~/Images/" + file.ElementAt(0).FileName,
        //                            Pdf = "~/PdfFiles/" + file.ElementAt(1).FileName
        //                        });
        //                        db.SaveChanges();
        //                        ViewBag.Message = "Uploaded Successfully";
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            ViewBag.Message = "File Not Found";
        //        }
        //    }
        //    return View();
        //}

    }
}
