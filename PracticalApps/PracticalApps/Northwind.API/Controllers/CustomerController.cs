using Microsoft.AspNetCore.Mvc;

namespace Northwind.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository repository;

        public CustomerController(ICustomerRepository repository)
        {
            this.repository = repository;
        }
        // GET customer
        // GET customer/country=[country]
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Customer>))]
        public async Task<IEnumerable<Customer>> GetCustomers(string? country)
        {
            if (string.IsNullOrEmpty(country))
            {
                return await repository.RetrieveAllAsync();
            }
            return (await repository.RetrieveAllAsync()).Where(x => x.Country == country);
        }

        [HttpGet("{id}", Name = nameof(GetCustomer))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(Customer))]
        public async Task<IActionResult> GetCustomer(string id)
        {
            //if (string.IsNullOrEmpty(id))
            //{
            //    return BadRequest("id cannot be empty");
            //}
            var customer = await this.repository.RetrieveAsync(id);

            if (customer == null)
            {
                return NotFound($"customer not found for id {id}");
            }
            return Ok(customer);
        }

        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(201, Type = typeof(Customer))]
        public async Task<IActionResult> CreateCustomer([FromBody] Customer customer)
        {
            //if (customer == null)
            //    return BadRequest("Customer cannot be empty");

            Customer addedCustomer = await repository.CreateAsync(customer);
            if (addedCustomer == null)
            {
                return BadRequest("failed to create new customer");
            }
            return CreatedAtRoute(nameof(GetCustomer), routeValues: new { id = addedCustomer.CustomerId.ToLower() }, customer);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(204)] //NO Content
        public async Task<IActionResult> UpdateCustomer(string id, [FromBody] Customer customer)
        {
            id = id.ToUpper();
            if (customer == null || customer.CustomerId.ToUpper() != id)
            {
                return BadRequest("Inavalid customer");
            }
            var existingCustomer = await repository.RetrieveAsync(id);
            if (existingCustomer == null)
            {
                return NotFound("given customer not found");
            }
            existingCustomer = customer;
            await repository.UpdateAsync(id, existingCustomer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(204)] //NO Content
        public async Task<IActionResult> DeleteCustomer(string id)
        {
            //if(string.IsNullOrEmpty(id))
            //{
            //    return BadRequest("customer id is required");
            //}
            var existingCustomer = await repository.RetrieveAsync(id);
            if(existingCustomer==null)
            {
                return NotFound($"customer with id {id} not found");
            }
            var isDeleted = await repository.DeleteAsync(id);
            if(isDeleted.HasValue && isDeleted==true)
            {
                return NoContent();
            }
            else
            {
                return BadRequest($"customer with id {id} is found but not deleted");
            }
        }


    }
}
