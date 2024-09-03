using Microsoft.AspNetCore.Mvc;
using Pacial_Net2.Models;
using Pacial_Net2.Repository.Interface;

namespace Pacial_Net2.Controllers
{
    public class MarcaController : Controller
    {
        private readonly IMarcaRepository _marca;
        private readonly ILogger<MarcaController> _logger;

        public MarcaController(ILogger<MarcaController> logger, IMarcaRepository marca)
        {
            _marca = marca;
            _logger = logger;
        }

        // GET: Marca
        public IActionResult Index()
        {
            ViewBag.Marca = _marca.GetMarca();
            return View();
        }

        // GET: Marca/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Marca/Save
        [HttpPost]
        public IActionResult Save(Marca marca)
        {
            if (ModelState.IsValid)
            {
                _marca.AddMarca(marca);
                return RedirectToAction(nameof(Index));
            }
            return View(marca);
        }

        //GET: Marca/Edit/
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var marca = _marca.EditMarca(id);

            if (marca == null)
            {
                return NotFound();
            }
            return View(marca);
        }

        //// POST: Marca/Update/
        [HttpPost]
        public ActionResult Update(int id, Marca marca)
        {
            if (id != marca.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _marca.UpdateMarca(marca);
                return RedirectToAction(nameof(Index));
            }
            return View(marca);
        }

        // GET: Marca/Delete/
        [HttpDelete]
        public IActionResult Delete(int id)
        {
             _marca.DeleteMarca(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
