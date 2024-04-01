using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers; 

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _service;

    public CustomerController(ICustomerService service)
    {
        _service = service;
    }

    [HttpGet("get-all-customers")]
    public async Task<ActionResult<List<Customer>>> GetCustomers()
    {
        var res = await _service.GetCustomers();
        return Ok(res.ToList());
    }

    [HttpPost("add-customer")]
    public  async Task<IActionResult> AddCustomer([FromForm] Customer customer)
        {
            await _service.AddCustomer(customer);
            return Ok();
        }

        [HttpPut("update-customer")]
        public  async Task<IActionResult> UpdateCustomer([FromForm] Customer customer)
        {
            await _service.UpdateCustomer(customer);
            return Ok();
        }  

        [HttpDelete("delete-customer")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            await _service.DeleteCustomer(id);
            return Ok();
        }
}
