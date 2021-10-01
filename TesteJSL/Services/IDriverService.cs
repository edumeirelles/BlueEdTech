using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteJSL.Models;

namespace TesteJSL.Services
{
    public interface IDriverService
    {
        bool Create(Driver driver);
        bool Delete(int? id);
        Driver Get(int id);
        List<Driver> GetAll();
        bool Update(Driver driver);
    }
}
