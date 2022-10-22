using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Customer_Registration.Models;
using System.Net;
namespace API_Customer_Registration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerContext _context;

        public CustomersController(CustomerContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        // GET: api/Customers
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // PUT: api/Customers
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            try
            {
                if (!CustomerExists(id))
                {
                    throw new Exception("No customer found for specified ID");
                }
                if (id != customer.Id)
                {
                    throw new Exception("Provided ID does not match customer ID");
                }

                _context.Entry(customer).State = EntityState.Modified;


                await _context.SaveChangesAsync();
                return Ok("Customer updated successfully");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // POST: api/Customers
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Customer>>> PostCustomer(Customer customer)
        {
            try
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
            }catch(Exception e)
            {
                throw e;
            }

            return await GetCustomers();
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> DeleteCustomer(int id)
        {
            try
            {
                var customer = await _context.Customers.FindAsync(id);
                if (customer == null)
                {
                    return NotFound();
                }

                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }catch(Exception e)
            {
                throw e;
            }
            return Ok("Customer deleted successfully");
        }

        private bool CustomerExists(int id)
        {

            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
