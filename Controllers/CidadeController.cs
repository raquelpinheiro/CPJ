using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OpimaCPJ.Web.Models;
using OpimaCpj.Data.Context;
using OpimaCPJ.Domain;
using OpimaCPJ.Domain.Interfaces;

namespace OpimaCPJ.Web.Controllers
{
    public class CidadeController : Controller
    {

        //private IDataBaseService _context;

        //public CidadeController(IDataBaseService context)
        //{
        //    _context = context;
        //}


        /*
        private readonly OpimaCpjContext _context;

        public CidadeController(OpimaCpjContext context)
        {
            _context = context;
        }

        // GET: Cidade
      
        public async Task<IActionResult> Index()
        {
            var cidade = _context.Cidade.Include(c => c.Estado);
            return View(await cidade.ToListAsync());

        }

        // GET: Cidade/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidade
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // GET: Cidade/Create
        public IActionResult Create()
        {
            ViewBag.codigo_estado = new SelectList(_context.Estado, "codigo", "descricao");
            return View();
        }

        // POST: Cidade/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("codigo,descricao,codigo_estado")] Cidade cidade)
        {
            ViewData["Title"] = "Cadastro de Cidades"; 
            if (ModelState.IsValid)
            {
                _context.Add(cidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.codigo_estado = new SelectList(_context.Estado, "codigo", "descricao", cidade.CodigoEstado);
            return View(cidade);
        }

        // GET: Cidade/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidade.FindAsync(id);
            if (cidade == null)
            {
                return NotFound();
            }
            ViewBag.codigo_estado = new SelectList(_context.Estado, "codigo", "descricao", cidade.CodigoEstado);
            return View(cidade);
        }

        // POST: Cidade/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("codigo,descricao,codigo_estado")] Cidade cidade)
        {
            if (id != cidade.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cidade);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CidadeExists(cidade.Codigo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
               // return RedirectToAction(nameof(Index));
            }
            ViewBag.codigo_estado = new SelectList(_context.Estado, "codigo", "descricao", cidade.CodigoEstado);
            return View(cidade);
        }

        // GET: Cidade/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidade
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // POST: Cidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cidade = await _context.Cidade.FindAsync(id);
            _context.Cidade.Remove(cidade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CidadeExists(int id)
        {
            return _context.Cidade.Any(e => e.Codigo == id);
        }

        */
    }
}
