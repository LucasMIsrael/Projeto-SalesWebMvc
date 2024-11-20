using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SalesRecordsService
    {
        private readonly Contexto _context;

        public SalesRecordsService(Contexto context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                minDate = DateTime.SpecifyKind((DateTime)minDate, DateTimeKind.Utc);
                result = result.Where(x => x.Date >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                maxDate = DateTime.SpecifyKind((DateTime)maxDate, DateTimeKind.Utc);
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result
                        .Include(x => x.Seller)
                        .ThenInclude(x => x.Departament)
                        .OrderByDescending(x => x.Date)
                        .ToListAsync();
        }

        public async Task<List<IGrouping<Departament, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var query = _context.SalesRecord.AsQueryable();

            if (minDate.HasValue)
            {
                minDate = DateTime.SpecifyKind((DateTime)minDate, DateTimeKind.Utc);
                query = query.Where(x => x.Date >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                maxDate = DateTime.SpecifyKind((DateTime)maxDate, DateTimeKind.Utc);
                query = query.Where(x => x.Date <= maxDate.Value);
            }

            var salesRecords = await query
                .Include(x => x.Seller)
                .Include(x => x.Seller.Departament)
                .OrderByDescending(x => x.Date)
                .ToListAsync();

            var groupedResult = salesRecords
                .GroupBy(x => x.Seller.Departament)
                .ToList();

            return groupedResult;
        }
    }
}
