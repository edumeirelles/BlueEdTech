using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSucessoEventos.Data;
using TesteSucessoEventos.Models;

namespace TesteSucessoEventos.Services
{
    public class AtividadeService : IAtividadeService
    {
        Context _context;

        public AtividadeService(Context context)
        {
            _context = context;
        }
        public List<Atividade> GetAll()
        {
            return _context.Atividades.ToList();
        }
        public Atividade Get(int id)
        {
            return _context.Atividades.ToList().FirstOrDefault(p => p.Id == id);
        }
        public bool Create(Atividade atividade)
        {
            try
            {
                _context.Atividades.Add(atividade);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(Atividade atividade)
        {
            try
            {
                _context.Atividades.Update(atividade);
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
                _context.Atividades.Remove(_context.Atividades.ToList().FirstOrDefault(a => a.Id == id));
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
