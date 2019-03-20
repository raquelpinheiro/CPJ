using AutoMapper;
using Opima.CPJ.Application.ViewModel;
using OpimaCPJ.Domain;

namespace Opima.CPJ.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PessoaFisicaViewModel, PessoaFisica>();
     
        }
    }
}
