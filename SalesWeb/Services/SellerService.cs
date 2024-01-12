using SalesWeb.Data;
using SalesWeb.Models;

namespace SalesWeb.Services
{
    public class SellerService
    {
        private readonly SalesWebContext _context;

        public SellerService(SalesWebContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert (Seller obj)
        {
            obj.Departments = _context.Departments.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
