using Calculadora.Client.Domain.Entities;
using System.Threading.Tasks;

namespace Calculadora.Client.Domain.Interfaces
{
    public interface IClientDomainService
    {
        public Task<string> Somar(Dados dados);
        public Task<string> Subtrair(Dados dados);
        public Task<string> Multiplicar(Dados dados);
        public Task<string> Dividir(Dados dados);
    }
}
