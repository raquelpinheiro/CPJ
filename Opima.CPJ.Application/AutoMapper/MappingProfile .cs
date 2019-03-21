using AutoMapper;
using Opima.CPJ.Application.ViewModel;
using OpimaCPJ.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Opima.CPJ.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PessoaFisica, PessoaFisicaViewModel>().ReverseMap();
          
        }
    }
}
