using Calculadora.Server.Protos;
using Calculadora.Server.Protos.Message;
using Ma9DevPack.Grpc.Helpers;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;


namespace Calculadora.Client.Anticorruption.Server
{
    public class ServerService : IServerService
    {
        private readonly IGrpcCaller grpcCaller;
        private string urlGrpc;

        public ServerService()
        {

        }

        public ServerService(IGrpcCaller grpcCaller, IConfiguration configuration)
        {
            this.grpcCaller = grpcCaller;
            urlGrpc = configuration["Server:Url"];
        }

        public async Task<string> Somar(double valor1, double valor2)
        {
            return await grpcCaller.CallService(urlGrpc, async channel =>
            {
                var server = new OperacaoService.OperacaoServiceClient(channel);

                var requestParameter = new ValoresRequest();
                requestParameter.Valor1 = valor1;
                requestParameter.Valor2 = valor2;

                var resultado = await server.SomarAsync(requestParameter);

                return resultado.Valor;
            });
        }

        public async Task<string> Subtrair(double valor1, double valor2)
        {
            return await grpcCaller.CallService(urlGrpc, async channel =>
            {
                var server = new OperacaoService.OperacaoServiceClient(channel);

                var requestParameter = new ValoresRequest();
                requestParameter.Valor1 = valor1;
                requestParameter.Valor2 = valor2;

                var resultado = await server.SubtrairAsync(requestParameter);

                return resultado.Valor;
            });
        }

        public async Task<string> Multiplicar(double valor1, double valor2)
        {
            return await grpcCaller.CallService(urlGrpc, async channel =>
            {
                var server = new OperacaoService.OperacaoServiceClient(channel);

                var requestParameter = new ValoresRequest();
                requestParameter.Valor1 = valor1;
                requestParameter.Valor2 = valor2;

                var resultado = await server.MultiplicarAsync(requestParameter);

                return resultado.Valor;
            });
        }

        public async Task<string> Dividir(double valor1, double valor2)
        {
            return await grpcCaller.CallService(urlGrpc, async channel =>
            {
                var server = new OperacaoService.OperacaoServiceClient(channel);

                var requestParameter = new ValoresRequest();
                requestParameter.Valor1 = valor1;
                requestParameter.Valor2 = valor2;

                var resultado = await server.DividirAsync(requestParameter);

                return resultado.Valor;
            });
        }
    }
}
