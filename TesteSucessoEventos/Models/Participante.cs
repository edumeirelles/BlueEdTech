using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TesteSucessoEventos.Models
{
    public class Participante
    {
        [Display(Name = "#")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Telefone")]
        public string Phone { get; set; }
        [Display(Name = "Pacote")]
        public int PacoteId { get; set; }
        public List<Pacote> Pacote { get; set; }
        public List<Atividade> Atividades { get; set; }

    }
}
