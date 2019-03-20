using AutoMapper;
using Opima.CPJ.Application.Interfaces;
using Opima.CPJ.Application.ViewModel;
using OpimaCPJ.Domain;
using OpimaCPJ.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opima.CPJ.Application.Services
{
    public class PessoaAppService : IPessoaFisicaAppService
    {

        private readonly IRepository<PessoaFisica> _pessoaService;


        public PessoaAppService(IRepository<PessoaFisica> service)
        {
            _pessoaService = service;

        }

        public PessoaFisicaViewModel Adicionar(PessoaFisicaViewModel pessoaViewModel)
        {

            var entidade = Mapper.Map<PessoaFisica>(pessoaViewModel);

            var pessoa = _pessoaService.Adicionar(entidade);

            var viewModel = Mapper.Map<PessoaFisicaViewModel>(pessoa);

            return viewModel;
        }

        public PessoaFisicaViewModel Atualizar(PessoaFisicaViewModel pessoa)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public PessoaFisicaViewModel ObterPorCPF(string cpf)
        {
            throw new NotImplementedException();
        }

        public PessoaFisicaViewModel ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PessoaFisicaViewModel> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
