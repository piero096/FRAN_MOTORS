using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FranMotors.Models
{
    public class Motocicleta
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string NumSerie { get; set; }
        public string Cilindrada { get; set; }
        public string EstadoMoto { get; set; }
        public DateTime Año { get; set; }
    }
}
