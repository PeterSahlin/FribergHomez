using AutoMapper;
using FribergHomez.Data;
using FribergHomez.Models;
using Microsoft.AspNetCore.Mvc;

namespace FribergHomez.Controllers
{
    /// <summary>
    /// Den här funkar inte som den ska alls..... :(
    /// </summary>


    [Route("api/[controller]")]
    [ApiController]
    public class SalesObjectController : ControllerBase
    {
        private readonly ISaleObject saleObjectRepo;
        private readonly IRealEstateAgent agentRepo;
        private readonly IMapper mapper;
        public SalesObjectController(ISaleObject saleObjectRepo, IRealEstateAgent agentRepo, IMapper mapper)
        {
            this.saleObjectRepo = saleObjectRepo;
            this.agentRepo = agentRepo;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var salesObjects = await saleObjectRepo.GetAllSalesObjectsAsync();
                return Ok(salesObjects);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var saleObject = await saleObjectRepo.GetSalesObjectByIdAsync(id);
                return Ok(saleObject);
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
                await saleObjectRepo.DeleteSalesObjectAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] SalesObjectDto objectDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var saleObject = mapper.Map<SaleObject>(objectDto);
                    /*await saleObjectRepo.GetSalesObjectByIdAsync(id);*/
                if (saleObject == null)
                {
                    return NotFound("No sale object found");
                }
                //saleObject.Address = objectDto.Address;
                //saleObject.StartingPrice = objectDto.StartingPrice;
                //saleObject.LivingArea = objectDto.LivingArea;
                //saleObject.AncillaryArea = objectDto.AncillaryArea;
                //saleObject.PlotArea = objectDto.PlotArea;
                //saleObject.Description = objectDto.Description;
                //saleObject.NumberOfRooms = objectDto.NumberOfRooms;
                //saleObject.MonthlyFee = objectDto.MonthlyFee;
                //saleObject.OperatingCostPerYear = objectDto.AnnualOperatingCost;
                //saleObject.YearOfConstruction = objectDto.ConstructionYear;
                //saleObject.CategoryId = objectDto.CategoryId;
                //saleObject.MunicipalityId = objectDto.MunicipalityId;
                //saleObject.RealEstateAgentId = objectDto.RealEstateAgentId;
                await saleObjectRepo.UpdateSalesObjectAsync(saleObject);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SalesObjectDto objectDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var saleObject = mapper.Map<SaleObject>(objectDto);
                    //new SaleObject
                //{
                //    Address = objectDto.Address,
                //    StartingPrice = objectDto.StartingPrice,
                //    LivingArea = objectDto.LivingArea,
                //    AncillaryArea = objectDto.AncillaryArea,
                //    PlotArea = objectDto.PlotArea,
                //    Description = objectDto.Description,
                //    NumberOfRooms = objectDto.NumberOfRooms,
                //    MonthlyFee = objectDto.MonthlyFee,
                //    OperatingCostPerYear = objectDto.AnnualOperatingCost,
                //    YearOfConstruction = objectDto.ConstructionYear,
                //    CategoryId = objectDto.CategoryId,
                //    MunicipalityId = objectDto.MunicipalityId

                //};
                if (objectDto.RealEstateAgentId.HasValue)
                {
                    var agent = await agentRepo.GetRealEstateAgentByIdAsync(objectDto.RealEstateAgentId.Value);
                    if (agent == null)
                    {
                        return BadRequest("Invalid agentId");
                    }
                    saleObject.RealEstateAgent = agent;
                }
                await saleObjectRepo.AddSalesObjectAsync(saleObject);
                return StatusCode(201, saleObject);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
    public class SalesObjectDto
    {
        public string Address { get; set; }
        public int StartingPrice { get; set; }
        public int LivingArea { get; set; }
        public int AncillaryArea { get; set; }
        public int PlotArea { get; set; }
        public string Description { get; set; }
        public int NumberOfRooms { get; set; }
        public int MonthlyFee { get; set; }
        public int AnnualOperatingCost { get; set; }
        public int ConstructionYear { get; set; }
        public int CategoryId { get; set; }
        public Guid? RealEstateAgentId { get; set; }
        public int MunicipalityId { get; set; }
    }
}
