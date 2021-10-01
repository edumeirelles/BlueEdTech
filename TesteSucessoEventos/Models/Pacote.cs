using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TesteSucessoEventos.Models
{
    public class Pacote
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string DescPkg { get; set; }       
        public List<Participante> Participantes { get; set; }
    }
}
