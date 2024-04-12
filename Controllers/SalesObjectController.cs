using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FribergHomez.Data;

namespace FribergHomez.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesObjectController : ControllerBase
    {
        private readonly ISaleObject saleObjectRepo;
        public SalesObjectController(ISaleObject saleObjectRepo)
        {
            this.saleObjectRepo = saleObjectRepo;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var salesObjects = await saleObjectRepo.GetAllSalesObjectsAsync();
                return Ok(salesObjects);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
