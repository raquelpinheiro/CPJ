﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OpimaCpj.Data.Context;
using OpimaCPJ.Web.Models;
using OpimaCPJ.Domain;
using OpimaCPJ.Domain.Interfaces;

namespace OpimaCPJ.Web.Controllers
{
    public class BairroController : Controller
    {
        //private readonly OpimaCpjContext _context;

        /*
        public BairroController(OpimaCpjContext context)
        {
            _context = context;
        }
        */
             
/*
        // GET: Bairro
        public async Task<IActionResult> Index()
        {
           
            var bairro = _context.Bairro.Include(b => b.Cidade);
            return View(await bairro.ToListAsync());
        }

        // GET: Bairro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bairro = await _context.Bairro
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (bairro == null)
            {
                return NotFound();
            }

            return View(bairro);
        }

        // GET: Bairro/Create
        public IActionResult Create()
        {
            ViewBag.codigo_cidade = new SelectList(_context.Cidade, "codigo", "descricao");

            return View();
        }

        // POST: Bairro/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("codigo,descricao,codigo_cidade")] Bairro bairro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bairro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           ViewBag.codigo_cidade = new SelectList(_context.Cidade, "codigo", "descricao", bairro.CodigoCidade);

            return View(bairro);
        }

        // GET: Bairro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bairro = await _context.Bairro.FindAsync(id);
            if (bairro == null)
            {
                return NotFound();
            }
            ViewBag.codigo_cidade = new SelectList(_context.Cidade, "codigo", "descricao", bairro.CodigoCidade);


            return View(bairro);
        }

        // POST: Bairro/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("codigo,descricao,codigo_cidade")] Bairro bairro)
        {
            if (id != bairro.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bairro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BairroExists(bairro.Codigo))
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
            ViewBag.codigo_cidade = new SelectList(_context.Cidade, "codigo", "descricao", bairro.CodigoCidade);


            return View(bairro);
        }

        // GET: Bairro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bairro = await _context.Bairro
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (bairro == null)
            {
                return NotFound();
            }

            return View(bairro);
        }

        // POST: Bairro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bairro = await _context.Bairro.FindAsync(id);
            _context.Bairro.Remove(bairro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BairroExists(int id)
        {
            return _context.Bairro.Any(e => e.Codigo == id);
        }

         */
    }
}
