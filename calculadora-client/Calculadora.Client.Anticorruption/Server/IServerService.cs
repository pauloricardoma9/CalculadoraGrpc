using System.Threading.Tasks;

namespace Calculadora.Client.Anticorruption.Server
{
    public interface IServerService
    {
        public Task<string> Somar(double valor1, double valor2);
        public Task<string> Subtrair(double valor1, double valor2);
        public Task<string> Multiplicar(double valor1, double valor2);
        public Task<string> Dividir(double valor1, double valor2);
    }
}
