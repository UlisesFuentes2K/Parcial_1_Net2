using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using Pacial_Net2.Data;
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
        [HttpPut]
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
            var marca = _marca.DeleteMarca(id);

            return View(marca);

        }
        // POST: Marca/Delete/
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var marca = _marca.DeleteMarca(id);
            if (marca != null)
            {
                _marca.ConfirmedDeleteMarca(marca);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
