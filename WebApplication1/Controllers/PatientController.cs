using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PatientController : ControllerBase
{
    [HttpGet("homeaddress")]
    public IActionResult GetHomeAddress()
    {
        return Ok(Address.HomeAddress);
    }

    [HttpPost("homeaddress")]
    public IActionResult UpdateHomeAddress([FromBody] string newAddress)
    {
        Address.HomeAddress = newAddress;
        return Ok();
    }
}
