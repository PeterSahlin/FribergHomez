using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FribergHomez.Data;
using FribergHomez.Models;
using AutoMapper;

namespace FribergHomez.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealEstateAgentController : ControllerBase
    {
        private readonly IRealEstateAgent agentRepo;
        private readonly IFirm firmRepo;
        private readonly IMapper mapper;

        public RealEstateAgentController(IRealEstateAgent agentRepo, IFirm firmRepo, IMapper mapper)
        {
            this.agentRepo = agentRepo;
            this.firmRepo = firmRepo;
            this.mapper = mapper;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var agent = await agentRepo.GetRealEstateAgentByIdAsync(id);
                return Ok(agent);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
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

        
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeletePermanently(string id)
        {
            try
            {
                await agentRepo.RealEstateAgentDeletePermanently(id);
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
                    return BadRequest("Modelstate is invalid");
                }

                var realEstateAgent = mapper.Map<RealEstateAgent>(agentDto);


                //new RealEstateAgent

                //{
                //    FirstName = agentDto.FirstName,
                //    LastName = agentDto.LastName,
                //    Email = agentDto.Email,
                //    PhoneNumber = agentDto.PhoneNumber,
                //    ImageUrl = agentDto.ImageUrl,
                //};
                if (agentDto.FirmId.HasValue)
                {
                    var firm = await firmRepo.GetFirmByIdAsync(agentDto.FirmId.Value);
                    if (firm == null)
                    {
                        return BadRequest("Invalid FirmId");
                    }
                    realEstateAgent.Firm = firm;
                }

                await agentRepo.AddRealEstateAgentAsync(realEstateAgent);
                return StatusCode(201, realEstateAgent);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] AgentDto agentDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Modelstate is invalid");
                }
                var updatedagent = mapper.Map<RealEstateAgent>(agentDto);
                await agentRepo.UpdateRealEstateAgentAsync(updatedagent);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            //var agent = await agentRepo.GetRealEstateAgentByIdAsync(id);
            //if(agent == null)
            //{
            //    return NotFound("No agent found with that Id");
            //}
            //agent.FirstName = agentDto.FirstName;
            //agent.LastName = agentDto.LastName;
            //agent.Email = agentDto.Email;
            //agent.PhoneNumber = agentDto.PhoneNumber;
            //agent.ImageUrl = agentDto.ImageUrl;
            //agent.FirmId = agentDto.FirmId;
        }
    }
    public class AgentDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public int? FirmId { get; set; }
        public bool IsActive { get; set; } = true;

        //Navigation Properties
        public Firm Firm { get; set; }
    }
}
