using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSoftplan.Models
{
    public class calculaJuros
    {
        [Required(ErrorMessage = "Insira a quantidade de meses")]
        [Display(Name = "Período (meses)")]
        public int Tempo { get; set; }
        [Required(ErrorMessage = "Insira valor inicial")]
        [Display(Name = "Valor inicial (R$)")]
        public decimal ValorInicial { get; set; }
        public decimal ValorFinal { get; set; }
    }
}
