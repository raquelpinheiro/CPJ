using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OpimaCPJ.Domain;
using OpimaCpj.Data.Context;
using Opima.CPJ.Application.Interfaces;

namespace OpimaCPJ.Web.Controllers
{
    public class PessoaFisicaController : Controller
    {
        private readonly IPessoaFisicaAppService _context;

        public PessoaFisicaController(IPessoaFisicaAppService context)
        {
            _context = context;
        }

        // GET: PessoaFisica
        public async Task<IActionResult> Index()
        {
            // return View(await _context.PessoaFisica.ToListAsync());

            var task = Task.Run(() => { return _context.ObterTodos(); });

            return View(await task);
        }

        // GET: PessoaFisica/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pessoaFisica = await _context.PessoaFisica
        //        .FirstOrDefaultAsync(m => m.Codigo == id);
        //    if (pessoaFisica == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(pessoaFisica);
        //}

        // GET: PessoaFisica/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PessoaFisica/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("TelefoneResidencial,TelefoneCelular,Nome,DataNascimento,Sexo,Profissao,Nacionalidade,Email,NomePai,NomeMae,DataCadastro,Cpf,NumeroOAB,Codigo")] PessoaFisica pessoaFisica)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(pessoaFisica);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(pessoaFisica);
        //}

        //// GET: PessoaFisica/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pessoaFisica = await _context.PessoaFisica.FindAsync(id);
        //    if (pessoaFisica == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(pessoaFisica);
        //}

        //// POST: PessoaFisica/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("TelefoneResidencial,TelefoneCelular,Nome,DataNascimento,Sexo,Profissao,Nacionalidade,Email,NomePai,NomeMae,DataCadastro,Cpf,NumeroOAB,Codigo")] PessoaFisica pessoaFisica)
        //{
        //    if (id != pessoaFisica.Codigo)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(pessoaFisica);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PessoaFisicaExists(pessoaFisica.Codigo))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(pessoaFisica);
        //}

        //// GET: PessoaFisica/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pessoaFisica = await _context.PessoaFisica
        //        .FirstOrDefaultAsync(m => m.Codigo == id);
        //    if (pessoaFisica == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(pessoaFisica);
        //}

        //// POST: PessoaFisica/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var pessoaFisica = await _context.PessoaFisica.FindAsync(id);
        //    _context.PessoaFisica.Remove(pessoaFisica);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool PessoaFisicaExists(int id)
        //{
        //    return _context.PessoaFisica.Any(e => e.Codigo == id);
        //}
    }
}
