namespace Calculadora.Server.Domain.Entities
{
    public class Calculador
    {
        public string Somar(double valor1, double valor2)
        {
            return (valor1 + valor2).ToString();
        }

        public string Subtrair(double valor1, double valor2)
        {
            return (valor1 - valor2).ToString();
        }

        public string Multiplicar(double valor1, double valor2)
        {
            return (valor1 * valor2).ToString();
        }

        public string Dividir(double valor1, double valor2)
        {
            if (valor2 == 0) return "Não é possível dividir por 0";
            return (valor1 / valor2).ToString();
        }
    }
}
