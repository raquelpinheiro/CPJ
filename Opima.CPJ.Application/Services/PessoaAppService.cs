using AutoMapper;
using Opima.CPJ.Application.Interfaces;
using OpimaCpj.Data.Repository;
using Opima.CPJ.Application.ViewModel;
using OpimaCPJ.Domain;
using OpimaCPJ.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using  OpimaCpj.Data.Context;

namespace Opima.CPJ.Application.Services
{
    public class PessoaAppService : IPessoaFisicaAppService
    {

        private readonly IRepositoryPessoaFisica _pessoaService;
        private readonly IMapper _mapper;

        public PessoaAppService(OpimaCpjContext context, IMapper mapper)
        {
            _pessoaService = new RepositoryPessoaFisica(context);
            _mapper = mapper;
        }

        public PessoaFisicaViewModel Adicionar(PessoaFisicaViewModel pessoaViewModel)
        {

            var entidade = _mapper.Map<PessoaFisica>(pessoaViewModel);

            var pessoa = _pessoaService.Adicionar(entidade);

            var viewModel = _mapper.Map<PessoaFisicaViewModel>(pessoa);

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
             return _mapper.Map<IEnumerable<PessoaFisicaViewModel>>(_pessoaService.ObterTodos());
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
