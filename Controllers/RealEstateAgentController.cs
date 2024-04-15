using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FribergHomez.Data;
using FribergHomez.Models;

namespace FribergHomez.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealEstateAgentController : ControllerBase
    {
        private readonly IRealEstateAgent agentRepo;
        public RealEstateAgentController(IRealEstateAgent agentRepo)
        {
            this.agentRepo = agentRepo;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var agents = await agentRepo.GetAllAgentsAsync();
                return Ok(agents);
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
                await agentRepo.DeleteAgentAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RealEstateAgent agent)
        {
            if (agent == null)
            {
                return BadRequest("Agent object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            try
            {
                await agentRepo.AddAgentAsync(agent);
                return StatusCode(201, agent);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] RealEstateAgent agent)
        {
            if (agent == null)
            {
                return BadRequest("Agent object is null");
            }

            if (id != agent.Id)
            {
                return BadRequest("ID mismatch between route parameter and request body");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            try
            {
                var existingAgent = await agentRepo.GetAgentByIdAsync(id);
                if (existingAgent == null)
                {
                    return NotFound("Category not found");
                }

                existingAgent.FirstName = agent.FirstName;
                existingAgent.LastName = agent.LastName;
                existingAgent.Email = agent.Email;
                existingAgent.PhoneNumber = agent.PhoneNumber;
                existingAgent.ImageUrl = agent.ImageUrl;
                existingAgent.FirmId = agent.FirmId;

                await agentRepo.UpdateAgentAsync(existingAgent);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
