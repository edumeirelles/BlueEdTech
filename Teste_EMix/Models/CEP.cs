using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_EMix.Models
{
    public class CEP
    {
        public int Id { get; set; }
        [Display(Name = "CEP")]
        public string cep { get; set; }
        [Display(Name = "Logradouro")]
        public string logradouro { get; set; }
        [Display(Name = "Complemento")]
        public string complemento{ get; set; }
        [Display(Name = "Bairro")]
        public string bairro { get; set; }
        [Display(Name = "Localidade")]
        public string localidade { get; set; }
        [Display(Name = "UF")]
        public string uf { get; set; }
        public int unidade { get; set; }
        public int ibge { get; set; }
        public string gia { get; set; }

    }
}
