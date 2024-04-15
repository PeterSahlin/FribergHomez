using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FribergHomez.Data;
using FribergHomez.Models;

namespace FribergHomez.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipalitiesController : ControllerBase
    {
        private readonly IMunicipality municipalityRepo;
        public MunicipalitiesController(IMunicipality municipalityRepo)
        {
            this.municipalityRepo = municipalityRepo;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var municipalities = await municipalityRepo.GetAllMunicipalitiesAsync();
                return Ok(municipalities);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await municipalityRepo.DeleteMunicipalityAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Municipality municipality)
        {
            if (municipality == null)
            {
                return BadRequest("Category object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            try
            {
                await municipalityRepo.AddMunicipalityAsync(municipality);
                return StatusCode(201, municipality);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Municipality municipality)
        {
            if (municipality == null)
            {
                return BadRequest("Municipality object is null");
            }

            if (id != municipality.Id)
            {
                return BadRequest("ID mismatch between route parameter and request body");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            try
            {
                var existingMunicipality = await municipalityRepo.GetMunicipalityByIdAsync(id);
                if (existingMunicipality == null)
                {
                    return NotFound("Category not found");
                }

                existingMunicipality.Name = existingMunicipality.Name;

                await municipalityRepo.UpdateMunicipalityAsync(existingMunicipality);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
