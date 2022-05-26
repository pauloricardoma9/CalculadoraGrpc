namespace Calculadora.Client.Domain.Entities
{
    public class Resultado
    {
        public Resultado(string valor)
        {
            Valor = valor;
        }

        public string Valor { get; private set; }
    }
}
