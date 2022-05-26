using AutoMapper;
using Claps.Produto.AutoMapper;

namespace Calculadora.Client.AutoMapper
{
    public class AutoMapperSetup
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(autoMapperConfig =>
            {
                autoMapperConfig.AddProfile(new EntityToProtoProfile());
                autoMapperConfig.AddProfile(new ProtoToEntityProfile());
            });
        }
    }
}
