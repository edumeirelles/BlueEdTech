using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Teste_EMix.Models;

namespace Teste_EMix.Services
{
    public class WebCepService : IWebCepService
    {
        public CEP GetWebCep(string search)
        {
            var json = new WebClient().DownloadString("https://viacep.com.br/ws/" + search + "/json/");

            dynamic result = JObject.Parse(json);

            CEP cep = new()
            {
                cep = result.cep,
                logradouro = result.logradouro,
                complemento = result.complemento,
                bairro = result.bairro,
                localidade = result.localidade,
                uf = result.uf,
                    
            };

            return cep; 
        }
    }
}
