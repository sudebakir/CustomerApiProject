using Microsoft.AspNetCore.Mvc;
using CustomerApi.Models;
using System.Collections.Generic;
using System.Linq;
namespace CustomerApi.Controllers

{
    [Route("api/[controller]")]
    [ApiController] 
    public class CustomerController : ControllerBase
    {
    
        private static List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "xxxxxxxx", Country = "Turkey", Status = CustomerStatus.Qualified },
            new Customer { Id = 2, Name = "yyyyyyy", Country = "England", Status = CustomerStatus.TakenForProcessing }
        };

       
        [HttpPost]
        public IActionResult CreateCustomer([FromBody] Customer customer)
        {
            customer.Id = customers.Count + 1;
            customers.Add(customer);
            return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound(); 

            return Ok(customer);
        }

       
        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, [FromBody] Customer updatedCustomer)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound(); 

            customer.Name = updatedCustomer.Name;
            customer.Country = updatedCustomer.Country;
            customer.Status = updatedCustomer.Status;
            return Ok(customer); 
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound(); 

            customers.Remove(customer);
            return NoContent(); 
        }
    }
}
