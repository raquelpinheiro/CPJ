using Opima.CPJ.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opima.CPJ.Application.Interfaces
{
    public interface IPessoaFisicaAppService : IDisposable
    {
        PessoaFisicaViewModel Adicionar(PessoaFisicaViewModel pessoa);
        PessoaFisicaViewModel ObterPorId(int id);
        IEnumerable<PessoaFisicaViewModel> ObterTodos();
        PessoaFisicaViewModel ObterPorCPF(string cpf);
        PessoaFisicaViewModel Atualizar(PessoaFisicaViewModel pessoa);
        void Remover(int id);
                
    }
}
