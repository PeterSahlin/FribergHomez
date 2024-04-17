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
        private readonly IFirm firmRepo;
        public RealEstateAgentController(IRealEstateAgent agentRepo, IFirm firmRepo)
        {
            this.agentRepo = agentRepo;
            this.firmRepo = firmRepo;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var agents = await agentRepo.GetAllRealEstateAgentsAsync();
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
                await agentRepo.DeleteRealEstateAgentAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AgentDto agentDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var agent = new RealEstateAgent
                {
                    FirstName = agentDto.FirstName,
                    LastName = agentDto.LastName,
                    Email = agentDto.Email,
                    PhoneNumber = agentDto.PhoneNumber,
                    ImageUrl = agentDto.ImageUrl,
                };
                if (agentDto.FirmId.HasValue)
                {
                    var firm = await firmRepo.GetFirmByIdAsync(agentDto.FirmId.Value);
                    if(firm == null)
                    {
                        return BadRequest("Invalid FirmId");
                    }
                    agent.Firm = firm;
                }
                await agentRepo.AddRealEstateAgentAsync(agent);
                return StatusCode(201, agent);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] AgentDto agentDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var agent = await agentRepo.GetRealEstateAgentByIdAsync(id);
                if(agent == null)
                {
                    return NotFound("No agent found with that Id");
                }
                agent.FirstName = agentDto.FirstName;
                agent.LastName = agentDto.LastName;
                agent.Email = agentDto.Email;
                agent.PhoneNumber = agentDto.PhoneNumber;
                agent.ImageUrl = agentDto.ImageUrl;
                agent.FirmId = agentDto.FirmId;
                await agentRepo.UpdateRealEstateAgentAsync(agent);
                return NoContent();
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
    public class AgentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public int? FirmId { get; set; }
    }
}
