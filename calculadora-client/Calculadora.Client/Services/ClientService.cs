using AutoMapper;
using Calculadora.Client.Domain.Entities;
using Calculadora.Client.Domain.Interfaces;
using Calculadora.Client.Protos.Message;
using Grpc.Core;
using System.Threading.Tasks;

namespace Calculadora.Client.Services
{
    public class ClientService : Protos.ClientService.ClientServiceBase
    {
        public readonly IClientDomainService clientDomainService;
        public readonly IMapper mapper;

        public ClientService(IClientDomainService clientDomainService, IMapper mapper)
        {
            this.clientDomainService = clientDomainService;
            this.mapper = mapper;
        }

        public override Task<ResultadoResponse> Somar(ValoresRequest request, ServerCallContext context)
        {
            var dados = mapper.Map<Dados>(request);
            var resultado = clientDomainService.Somar(dados);
            return Task.FromResult(mapper.Map<ResultadoResponse>(new Resultado(resultado.Result)));
        }

        public override Task<ResultadoResponse> Subtrair(ValoresRequest request, ServerCallContext context)
        {
            var dados = mapper.Map<Dados>(request);
            var resultado = clientDomainService.Subtrair(dados);

            return Task.FromResult(mapper.Map<ResultadoResponse>(new Resultado(resultado.Result)));
        }

        public override Task<ResultadoResponse> Multiplicar(ValoresRequest request, ServerCallContext context)
        {
            var dados = mapper.Map<Dados>(request);
            var resultado = clientDomainService.Multiplicar(dados);

            return Task.FromResult(mapper.Map<ResultadoResponse>(new Resultado(resultado.Result)));
        }

        public override Task<ResultadoResponse> Dividir(ValoresRequest request, ServerCallContext context)
        {
            var dados = mapper.Map<Dados>(request);
            var resultado = clientDomainService.Dividir(dados);

            return Task.FromResult(mapper.Map<ResultadoResponse>(new Resultado(resultado.Result)));
        }
    }
}
