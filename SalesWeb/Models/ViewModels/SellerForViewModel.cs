using System.Collections.Generic;

namespace SalesWeb.Models.ViewModels
{
    public class SellerForViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Departments> Departments { get; set; }
    }
}
