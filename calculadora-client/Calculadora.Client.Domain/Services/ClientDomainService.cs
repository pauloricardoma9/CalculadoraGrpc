using Calculadora.Client.Anticorruption.Server;
using Calculadora.Client.Domain.Entities;
using Calculadora.Client.Domain.Interfaces;
using System.Threading.Tasks;

namespace Calculadora.Client.Domain.Services
{
    public class ClientDomainService : IClientDomainService
    {
        private readonly IServerService serverService;

        public ClientDomainService()
        {

        }

        public ClientDomainService(IServerService serverService)
        {
            this.serverService = serverService;
        }

        public async Task<string> Somar(Dados dados)
        {
            var resultado = await serverService.Somar(dados.Valor1, dados.Valor2);
            return resultado;
        }

        public async Task<string> Subtrair(Dados dados)
        {
            var resultado = await serverService.Subtrair(dados.Valor1, dados.Valor2);
            return resultado;
        }

        public async Task<string> Multiplicar(Dados dados)
        {
            var resultado = await serverService.Multiplicar(dados.Valor1, dados.Valor2);
            return resultado;
        }

        public async Task<string> Dividir(Dados dados)
        {
            if(dados.Valor2 == 0)
            {
                return "Não é possível dividir por 0";
            }

            var resultado = await serverService.Dividir(dados.Valor1, dados.Valor2);
            return resultado;
        }
    }
}
