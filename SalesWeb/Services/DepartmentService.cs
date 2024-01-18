using SalesWeb.Data;
using System.Linq;
using System.Collections.Generic;
using SalesWeb.Models;

namespace SalesWeb.Services
{
    public class DepartmentService
    {
        private readonly SalesWebContext _context;

        public DepartmentService(SalesWebContext context)
        {
            _context = context;
        }

        public List<Departments> FindAll()
        {
            return _context.Departments.OrderBy(x => x.Name).ToList();
        }
    }
}
