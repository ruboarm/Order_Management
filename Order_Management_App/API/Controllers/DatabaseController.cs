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
    public class DatabaseController : ControllerBase
    {
        //public readonly ApplicationDbContext _context;
        public readonly DatabaseProviderService _getdate;

        //public DatabaseController(ApplicationDbContext context, GetDatabaseDataService getdate)
        public DatabaseController(DatabaseProviderService getdate)
        {
            //_context = context;
            _getdate = getdate;
        }

        // GET: api/<DatabaseController>
        [HttpGet]
        public async Task<List<Supplier>> Get()
        {
            //var suppliers = await _context.Suppliers.ToListAsync();
            var suppliers = await _getdate.GetSuppliersAsync();

            return suppliers;
        }

        // GET api/<DatabaseController>/5
        [HttpGet("{id}")]
        public async Task<Supplier> Get(int id)
        {
            //var supplier = await _context.Suppliers.FirstOrDefaultAsync(s => s.ID == id);
            var supplier = await _getdate.GetSupplierByIdAsync(id);

            return supplier;
        }

        // POST api/<DatabaseController>
        [HttpPost]
        public void Post([FromBody] Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                //_context.Suppliers.Add(supplier);
                //await _context.SaveChangesAsync();
                _getdate.CreateSupplierAsync(supplier);
            }
        }

        // PUT api/<DatabaseController>/5
        [HttpPut("{id}")]
        //public async void Put(int id, [FromBody] Supplier supplier)
        public void Put([FromBody] Supplier supplier)
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

                //_context.Suppliers.Update(supplier);
                //await _context.SaveChangesAsync();

                _getdate.UpdateSupplierAsync(supplier);
            }

        }

        // DELETE api/<DatabaseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //var supplier = await _context.Suppliers.FirstOrDefaultAsync(s => s.ID == id);

            //_context.Suppliers.Remove(supplier);
            //await _context.SaveChangesAsync();

            _getdate.DeleteSupplierByIdAsync(id);
        }
    }
}
