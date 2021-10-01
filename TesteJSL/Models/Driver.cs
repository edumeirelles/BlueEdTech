using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteJSL.Models
{
    public class Driver
    {
        public int Id { get; set; }
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Nome Obrigatório")]
        public string FullName { get; set; }
        [Display(Name = "Marca")]
        public string Brand { get; set; }
        [Display(Name = "Modelo")]
        public string Model { get; set; }
        [Display(Name = "Placa")]
        public string LicencePlate { get; set; }
        [Display(Name = "Número de Eixos")]
        public int? Axes { get; set; }
        [Display(Name = "Logradouro")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Complemento")]
        public string AddressLine2 { get; set; }
        [Display(Name = "CEP")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string AddressZip { get; set; }
        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string AddressCity { get; set; }
        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string AddressState { get; set; }
    }
}
