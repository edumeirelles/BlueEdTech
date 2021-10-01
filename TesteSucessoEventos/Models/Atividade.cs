using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TesteSucessoEventos.Models
{
    public class Atividade
    {
        
        public int Id { get; set; }
        public string DescAtv { get; set; }
        public int Vacancies { get; set; }
        public double Price { get; set; }
        public List<Participante> Participantes { get; set; }

    }
}
