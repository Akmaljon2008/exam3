using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class ManagementController : ControllerBase
{
    private readonly ManagementService _service;

    public ManagementController(ManagementService service)
    {
        _service = service;
    }

    [HttpGet("get-management")]
    public async Task<ActionResult<List<Management>>> GetManagement()
    {
        var res = await _service.GetManagement();
        return Ok(res.ToList());
    }

    [HttpPost("add-management")]
    public async Task<IActionResult> AddManagement(Management management)
    {
        await _service.AddManagement(management);
        return Ok();
    }

    [HttpPut(("update-management"))]
    public async Task<IActionResult> UpdateManagement(Management management)
    {
        await _service.UpdateManagement(management);
        return Ok();
    }

    [HttpDelete("delete-management")]
    public async Task<IActionResult> DeleteManagement(int id)
    {
        await _service.DeleteManagement(id);
        return Ok();
    } 
}