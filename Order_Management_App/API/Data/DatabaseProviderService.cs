using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class DatabaseProviderService
    {
        private readonly ApplicationDbContext _context;

        public async Task<List<Supplier>> GetSuppliersAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }

        public async Task<Supplier> GetSupplierByIdAsync(int id)
        {
            return await _context.Suppliers.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async void CreateSupplierAsync(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();
        }

        public async void UpdateSupplierByIdAsync(int id)
        {
            var supplier = await _context.Suppliers.FirstOrDefaultAsync(s =>s.Id == id);
            _context.Suppliers.Update(supplier);
            await _context.SaveChangesAsync();
        }

        public async void UpdateSupplierAsync(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            await _context.SaveChangesAsync();
        }

        public async void DeleteSupplierByIdAsync(int id)
        {
            var supplier = await _context.Suppliers.FirstOrDefaultAsync(s => s.Id == id);
            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();
        }

        public async void DeleteSupplierAsync(Supplier supplier)
        {
            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();
        }
    }
}
