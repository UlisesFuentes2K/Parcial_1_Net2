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
    public class VehiculoController : Controller
    {
        private readonly IVehiculoRepository _vehiculo;
        private readonly IMarcaRepository _marca;
        private readonly ILogger<VehiculoController> _logger;

        public VehiculoController(ILogger<VehiculoController> logger, IVehiculoRepository vehiculo, IMarcaRepository marca)
        {
            _vehiculo = vehiculo;
            _marca = marca;
            _logger = logger;
        }

        // GET: Vehiculo
        public IActionResult Index()
        {
            ViewBag.Vehiculo = _vehiculo.GetVehiculo();
            return View();
        }

        // GET: Vehiculo/Create
        public IActionResult Create()
        {
            var marca = _marca.GetMarca();
            ViewBag.Marca = new SelectList(marca, "Id", "nombre");

            return View();
        }

        // POST: Vehiculo/Save
        [HttpPost]
        public IActionResult Save(Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                _vehiculo.AddVehiculo(vehiculo);
                return RedirectToAction(nameof(Index));
            }
            return View(vehiculo);
        }

        //GET: Vehiculo/Edit/
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var vehiculo = _vehiculo.EditVehiculo(id);

            var marcas = _marca.GetMarca(); 
            ViewBag.Marca = new SelectList(marcas, "Id", "nombre");

            if (vehiculo == null)
            {
                return NotFound();
            }
            return View(vehiculo);
        }

        //// POST: Vehiculo/Update/
        [HttpPost]
        public ActionResult Update(int id, Vehiculo vehiculo)
        {
            if (id != vehiculo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _vehiculo.UpdateVehiculo(vehiculo);
                return RedirectToAction(nameof(Index));
            }
            return View(vehiculo);
        }

        // GET: Vehiculo/Delete/
        [HttpDelete]
        public IActionResult Delete(int id)
        {
             _vehiculo.DeleteVehiculo(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
