using DesafioDio.Enum;

namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(TipoSuite tipoSuite, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = (int) tipoSuite;
            ValorDiaria = valorDiaria;
        }

        public TipoSuite TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}