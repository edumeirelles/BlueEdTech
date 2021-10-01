using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSucessoEventos.Data;
using TesteSucessoEventos.Models;

namespace TesteSucessoEventos.Services
{
    public class ParticipanteService : IParticipanteService
    {
        Context _context;

        public ParticipanteService(Context context)
        {
            _context = context;
        }
        public List<Participante> GetAll()
        {
            return _context.Participantes.ToList();
        }
        public Participante Get(int id)
        {
            return _context.Participantes.ToList().FirstOrDefault(p => p.Id == id);
        }
        public bool Create(Participante participante)
        {
            try
            {
                _context.Participantes.Add(participante);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(Participante participante)
        {
            try
            {
                _context.Participantes.Update(participante);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int? id)
        {
            try
            {
                _context.Participantes.Remove(_context.Participantes.ToList().FirstOrDefault(p => p.Id == id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
