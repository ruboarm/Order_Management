using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        public readonly ApplicationDbContext _context;
        //public readonly DatabaseProviderService _getdate;

        public SuppliersController(ApplicationDbContext context)
        //public SuppliersController(ApplicationDbContext context, DatabaseProviderService getdate)
        //public SuppliersController(DatabaseProviderService getdate)
        {
            _context = context;
            //_getdate = getdate;
        }

        // GET: api/<SuppliersController>
        [HttpGet]
        public async Task<List<Supplier>> Get()
        {
            List<Supplier> suppliers = null;
            try
            {
                suppliers = await _context.Suppliers.ToListAsync();
                //var suppliers = await _getdate.GetSuppliersAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

            return suppliers;
        }

        // GET api/<SuppliersController>/5
        [HttpGet("{id}")]
        public async Task<Supplier> Get(int id)
        {
            var supplier = await _context.Suppliers.FirstOrDefaultAsync(s => s.Id == id);
            //var supplier = await _getdate.GetSupplierByIdAsync(id);

            return supplier;
        }

        // POST api/<SuppliersController>
        [HttpPost]
        public async Task<List<Supplier>> Post([FromBody] Supplier supplier)
        {
            List<Supplier> list = null;
            if (ModelState.IsValid)
            {
                _context.Suppliers.Add(supplier);
                await _context.SaveChangesAsync();
                //_getdate.CreateSupplierAsync(supplier);

                list = await _context.Suppliers.ToListAsync();
            }

            return list;
        }

        // PUT api/<SuppliersController>/5
        [HttpPut("{id}")]
        //public async void Put(int id, [FromBody] Supplier supplier)
        public async void Put(int id, [FromBody] Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                //var existingSupplier = await _context.Suppliers.FirstOrDefaultAsync(s => s.ID == id);

                //existingSupplier.SupplierName = supplier.SupplierName;
                //existingSupplier.AddressLine1 = supplier.AddressLine1;
                //existingSupplier.AddressLine2 = supplier.AddressLine2;
                //existingSupplier.City = supplier.City;
                //existingSupplier.PostalCode = supplier.PostalCode;
                //existingSupplier.State = supplier.State;

                _context.Suppliers.Update(supplier);
                await _context.SaveChangesAsync();

                //_getdate.UpdateSupplierAsync(supplier);
            }

        }

        // DELETE api/<SuppliersController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            var supplier = await _context.Suppliers.FirstOrDefaultAsync(s => s.Id == id);

            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();

            //_getdate.DeleteSupplierByIdAsync(id);
        }
    }
}
