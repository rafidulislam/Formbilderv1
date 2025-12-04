using Formbilderv1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Formbilderv1.Controllers
{
    public class FormBuilderController : Controller
    {
        private readonly AppDbContext _db;

        public FormBuilderController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var forms = await _db.Forms
                                      .Include(f => f.Fields)
                                          .ThenInclude(ff => ff.Options)
                                      .ToListAsync();

            return View(forms);
        }


        public IActionResult Create()
        {
            return View(new FormModel());
        }

        [HttpPost]
        public IActionResult Create(FormModel model)
        {
            if (ModelState.IsValid)
            {
                _db.Forms.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Preview", new { id = model.Id });
            }
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                                .Where(x => x.Value.Errors.Any())
                                .Select(x => new {
                                    Field = x.Key,
                                    Error = x.Value.Errors.Select(e => e.ErrorMessage).ToList()
                                });

                return Json(errors);
            }

            return View(model);
        }

        public IActionResult Preview(int id)
        {
            var form = _db.Forms
                .Include(f => f.Fields)
                .ThenInclude(f => f.Options)
                .FirstOrDefault(f => f.Id == id);

            return View(form);
        }
    }

}
