using SalesWeb.Data;
using System.Linq;
using System.Collections.Generic;
using SalesWeb.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWeb.Services
{
    public class DepartmentService
    {
        private readonly SalesWebContext _context;

        public DepartmentService(SalesWebContext context)
        {
            _context = context;
        }

        public async Task<List<Departments>> FindAllAsync()
        {
            return await _context.Departments.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
