   using Microsoft.AspNetCore.Mvc;

   namespace MyWebApi.Controllers
   {
       [Route("api/[controller]")]
       [ApiController]
       public class ProviderController : ControllerBase
       {
           [HttpGet("homeaddress")]
           public ActionResult<string> GetHomeAddress()
           {
               return Ok(Address.HomeAddress);
           }

           [HttpPost("homeaddress")]
           public ActionResult UpdateHomeAddress([FromBody] string homeAddress)
           {
               Address.HomeAddress = homeAddress;
               return Ok();
           }
       }
   }
   