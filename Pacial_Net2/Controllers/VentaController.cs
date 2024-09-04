using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pacial_Net2.Models;
using Pacial_Net2.Repository.Interface;

namespace Pacial_Net2.Controllers
{
    public class VentaController : Controller
    {
        private readonly IVentaRepository _venta;
        private readonly IVehiculoRepository _vehiculo;
        private readonly IMarcaRepository _marca;
        private readonly ILogger<VentaController> _logger;

        public VentaController(ILogger<VentaController> logger, IVentaRepository venta, IVehiculoRepository vehiculo, IMarcaRepository marca)
        {
            _venta = venta;
            _vehiculo = vehiculo;
            _logger = logger;
            _marca = marca;
        }

        // GET: Venta
        public IActionResult Index()
        {
            ViewBag.Venta = _venta.GetVenta();
            return View();
        }

        // GET: Venta/Create
        [HttpGet]
        public IActionResult Create()
        {
            var vehiculo = _vehiculo.GetVehiculo();
            ViewBag.Vehiculo = new SelectList(vehiculo, "Id", "modelo");

            var marca = _marca.GetMarca();
            ViewBag.Marca = new SelectList(marca, "Id", "nombre");

            return View();
        }

        // POST: Venta/Save
        [HttpPost]
        public IActionResult Save(Venta venta)
        {
            if (ModelState.IsValid)
            {
                _venta.AddVenta(venta);
                return RedirectToAction(nameof(Index));
            }
            return View(venta);
        }

        // GET: filtrar modelos
        [HttpGet]
        public JsonResult GetModelos(int marcaId)
        {
            var modelos = _venta.FiltroModelos(marcaId);
            return Json(modelos);
        }

        //GET: Venta/Detalle/
        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var venta = _venta.DetalleVenta(id);
            ViewBag.Venta = venta;

            if (venta == null)
            {
                return NotFound();
            }

            return View();
        }
    }
}
