using AutoMapper;
using Calculadora.Client.Domain.Entities;
using Calculadora.Client.Protos.Message;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Claps.Produto.AutoMapper
{
    public class EntityToProtoProfile : Profile
    {
        public EntityToProtoProfile()
        {
            CreateMap<Dados, ValoresRequest>();
            CreateMap<Resultado, ResultadoResponse>();
        }
    }
}