using System.Collections.Generic;
using System.Linq;
using TesteJSL.Data;
using TesteJSL.Models;

namespace TesteJSL.Services
{
    public class DriverService : IDriverService
    {
        Context _context;
        public DriverService(Context context)
        {
            _context = context;
        }
        public List<Driver> GetAll()
        {
            return _context.Drivers.ToList();
        }
        public Driver Get(int id)
        {
            return _context.Drivers.ToList().FirstOrDefault(d => d.Id == id);
        }
        public bool Create(Driver driver)
        {
            try
            {
                _context.Drivers.Add(driver);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(Driver driver)
        {
            _context.Drivers.Update(driver);
            _context.SaveChanges();
            return true;
        }
        public bool Delete(int? id)
        {
            _context.Drivers.Remove(_context.Drivers.ToList().FirstOrDefault(d => d.Id == id));
            _context.SaveChanges();
            return true;
        }                     
    }
}
