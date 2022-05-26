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
            var valorResultante = clientDomainService.Somar(dados);
            var resultado = new Resultado(valorResultante.Result);

            return Task.FromResult(mapper.Map<ResultadoResponse>(resultado));
        }

        public override Task<ResultadoResponse> Subtrair(ValoresRequest request, ServerCallContext context)
        {
            var dados = mapper.Map<Dados>(request);
            var valorResultante = clientDomainService.Subtrair(dados);
            var resultado = new Resultado(valorResultante.Result);

            return Task.FromResult(mapper.Map<ResultadoResponse>(resultado));
        }

        public override Task<ResultadoResponse> Multiplicar(ValoresRequest request, ServerCallContext context)
        {
            var dados = mapper.Map<Dados>(request);
            var valorResultante = clientDomainService.Multiplicar(dados);
            var resultado = new Resultado(valorResultante.Result);

            return Task.FromResult(mapper.Map<ResultadoResponse>(resultado));
        }

        public override Task<ResultadoResponse> Dividir(ValoresRequest request, ServerCallContext context)
        {
            var dados = mapper.Map<Dados>(request);
            var valorResultante = clientDomainService.Dividir(dados);
            var resultado = new Resultado(valorResultante.Result);

            return Task.FromResult(mapper.Map<ResultadoResponse>(resultado));
        }
    }
}
