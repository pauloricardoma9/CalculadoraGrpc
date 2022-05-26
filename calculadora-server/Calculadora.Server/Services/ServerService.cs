using Calculadora.Server.Domain.Entities;
using Calculadora.Server.Protos.Message;
using Grpc.Core;
using System.Threading.Tasks;

namespace Calculadora.Server.Services
{
    public class ServerService : Protos.OperacaoService.OperacaoServiceBase
    {
        public override Task<ResultadoResponse> Somar(ValoresRequest request, ServerCallContext context)
        {
            var resultado = new Calculador().Somar(request.Valor1, request.Valor2);
            var response = new ResultadoResponse() { Valor = resultado.ToString() };

            return Task.FromResult(response);
        }

        public override Task<ResultadoResponse> Subtrair(ValoresRequest request, ServerCallContext context)
        {
            var resultado = new Calculador().Subtrair(request.Valor1, request.Valor2);
            var response = new ResultadoResponse() { Valor = resultado.ToString() };

            return Task.FromResult(response);
        }

        public override Task<ResultadoResponse> Multiplicar(ValoresRequest request, ServerCallContext context)
        {
            var resultado = new Calculador().Multiplicar(request.Valor1, request.Valor2);
            var response = new ResultadoResponse() { Valor = resultado.ToString() };

            return Task.FromResult(response);
        }

        public override Task<ResultadoResponse> Dividir(ValoresRequest request, ServerCallContext context)
        {
            var resultado = new Calculador().Dividir(request.Valor1, request.Valor2);
            var response = new ResultadoResponse() { Valor = resultado.ToString() };

            return Task.FromResult(response);
        }
    }
}
