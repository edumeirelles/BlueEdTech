using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSucessoEventos.Models;

namespace TesteSucessoEventos.Services
{
    public interface IParticipanteService
    {
        bool Create(Participante participante);
        bool Delete(int? id);
        Participante Get(int id);
        List<Participante> GetAll();
        bool Update(Participante participante);
    }
}
