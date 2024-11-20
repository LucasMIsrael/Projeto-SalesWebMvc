using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Services.Exceptions;
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

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller obj)
        {
            var lastSellerId = _context.Seller.OrderByDescending(x => x.Id).FirstOrDefault();

            if (lastSellerId != null)
                obj.Id = lastSellerId.Id + 1;

            obj.BirthDate = DateTime.SpecifyKind(obj.BirthDate, DateTimeKind.Utc);

            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(x => x.Departament).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new IntegrityExceptions(ex.Message);
            }            
        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }

            try
            {
                obj.BirthDate = DateTime.SpecifyKind(obj.BirthDate, DateTimeKind.Utc);
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbConcurrencyException(ex.Message);
            }            
        }
    }
}
