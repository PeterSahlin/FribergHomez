﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FribergHomez.Data;
using FribergHomez.Models;

namespace FribergHomez.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmController : ControllerBase
    {
        private readonly IFirm firmRep;
        public FirmController(IFirm firmRep)
        {
            this.firmRep = firmRep;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var firms = await firmRep.GetAllFirmsAsync();
                return Ok(firms);
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
                await firmRep.DeleteFirmAsync(id);
                return NoContent();
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Firm firm)
        {
            if(firm == null)
            {
                return BadRequest("Firm object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            try
            {
                await firmRep.AddFirmAsync(firm);
                return StatusCode(201, firm);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Firm firm)
        {
            if (firm == null)
            {
                return BadRequest("Firm object is null");
            }

            if (id != firm.Id)
            {
                return BadRequest("ID mismatch between route parameter and request body");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            try
            {
                var existingFirm = await firmRep.GetFirmByIdAsync(id);
                if(existingFirm == null)
                {
                    return NotFound("Firm not found");
                }
                existingFirm.Name = firm.Name;
                existingFirm.Presentation = firm.Presentation;
                existingFirm.ImageLocation = firm.ImageLocation;
                await firmRep.UpdateFirmAsync(existingFirm);
                return NoContent();
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
