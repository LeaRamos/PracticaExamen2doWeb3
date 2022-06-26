using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PracticaWeb.Data.Modelos;
using PracticaWeb.Servicio.Servicios;

namespace PracticaWeb.Web.Controllers
{
    public class TipoAnimalsController : Controller
    {

        ITipoAnimalServicio _tipoAnimalServicio;
        public TipoAnimalsController(ITipoAnimalServicio tipoAnimalServicio)
        {
            _tipoAnimalServicio = tipoAnimalServicio;
        }

        // GET: TipoAnimals
        public ActionResult Index()
        {
            return View(_tipoAnimalServicio.ObtenerTodosLosTipos());
        }

        // GET: TipoAnimals/Details/5
        /*public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAnimal = await _context.TipoAnimals
                .FirstOrDefaultAsync(m => m.IdTipoAnimal == id);
            if (tipoAnimal == null)
            {
                return NotFound();
            }

            return View(tipoAnimal);
        }

        // GET: TipoAnimals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoAnimals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoAnimal,Nombre")] TipoAnimal tipoAnimal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoAnimal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoAnimal);
        }

        // GET: TipoAnimals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAnimal = await _context.TipoAnimals.FindAsync(id);
            if (tipoAnimal == null)
            {
                return NotFound();
            }
            return View(tipoAnimal);
        }

        // POST: TipoAnimals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoAnimal,Nombre")] TipoAnimal tipoAnimal)
        {
            if (id != tipoAnimal.IdTipoAnimal)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoAnimal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoAnimalExists(tipoAnimal.IdTipoAnimal))
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
            return View(tipoAnimal);
        }

        // GET: TipoAnimals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAnimal = await _context.TipoAnimals
                .FirstOrDefaultAsync(m => m.IdTipoAnimal == id);
            if (tipoAnimal == null)
            {
                return NotFound();
            }

            return View(tipoAnimal);
        }

        // POST: TipoAnimals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoAnimal = await _context.TipoAnimals.FindAsync(id);
            _context.TipoAnimals.Remove(tipoAnimal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoAnimalExists(int id)
        {
            return _context.TipoAnimals.Any(e => e.IdTipoAnimal == id);
        }*/
    }
}
