using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Diagnostics.Metrics;
using System.Linq.Dynamic.Core;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly Contexto _context;

        public SellerService(Contexto context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            var lastSellerId = _context.Seller.OrderByDescending(x => x.Id).FirstOrDefault();

            if (lastSellerId != null)
                obj.Id = lastSellerId.Id + 1;

            obj.BirthDate = DateTime.SpecifyKind(obj.BirthDate, DateTimeKind.Utc);

            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
