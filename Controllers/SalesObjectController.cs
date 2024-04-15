using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FribergHomez.Data;
using FribergHomez.Models;
using Microsoft.EntityFrameworkCore;

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
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await saleObjectRepo.DeleteSalesObjectAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
