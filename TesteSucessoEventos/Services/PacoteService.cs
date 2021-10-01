using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSucessoEventos.Data;
using TesteSucessoEventos.Models;

namespace TesteSucessoEventos.Services
{
    public class PacoteService : IPacoteService
    {
        Context _context;

        public PacoteService(Context context)
        {
            _context = context;
        }
        public List<Pacote> GetAll()
        {
            return _context.Pacotes.ToList();
        }
        public Pacote Get(int id)
        {
            return _context.Pacotes.ToList().FirstOrDefault(p => p.Id == id);
        }
        public bool Create(Pacote pacote)
        {
            try
            {
                _context.Pacotes.Add(pacote);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(Pacote pacote)
        {
            try
            {
                _context.Pacotes.Update(pacote);
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
                _context.Pacotes.Remove(_context.Pacotes.ToList().FirstOrDefault(p => p.Id == id));
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
