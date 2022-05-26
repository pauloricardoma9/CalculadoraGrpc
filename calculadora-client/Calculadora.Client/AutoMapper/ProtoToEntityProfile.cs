using AutoMapper;
using Calculadora.Client.Domain.Entities;
using Calculadora.Client.Protos.Message;

namespace Claps.Produto.AutoMapper
{
    public class ProtoToEntityProfile : Profile
    {
        public ProtoToEntityProfile()
        {
            CreateMap<ValoresRequest, Dados>();
            CreateMap<ResultadoResponse, Resultado>();
        }
    }
}