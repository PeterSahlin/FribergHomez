using AutoMapper;
using FribergHomez.Data;
using FribergHomez.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using FribergHomez.Const;
using Microsoft.AspNetCore.Authorization;

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
        private readonly IMunicipality municipalityrepo;
        private readonly ICategory categoryrepo;
        private readonly IMapper mapper;
        public SalesObjectController(ISaleObject saleObjectRepo, IRealEstateAgent agentRepo, IMapper mapper, IMunicipality municipalityrepo, ICategory categoryrepo)
        {
            this.saleObjectRepo = saleObjectRepo;
            this.agentRepo = agentRepo;
            this.mapper = mapper;
            this.municipalityrepo = municipalityrepo;
            this.categoryrepo = categoryrepo;
        }

        //get all salesobjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaleObject>>> Get()
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


        //get active sales objects
        [HttpGet ("GetAllActiveSalesObjects")]
        public async Task<ActionResult<IEnumerable<SaleObject>>> GetActiveSalesObjects()
        {
            try
            {
                var activeSalesObjects = await saleObjectRepo.GetActiveSalesObjectsAsync();
                return Ok(activeSalesObjects);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SaleObject>> Get(int id)
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
        [Authorize(Roles = APIRoles.AdminAndUser)]
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
        [Authorize(Roles = APIRoles.AdminAndUser)]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] SalesObjectDto objectDto)
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
        [Authorize(Roles = APIRoles.AdminAndUser)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SalesObjectDto objectDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                //var saleObject = mapper.Map<SaleObject>(objectDto);
                var saleObject = new SaleObject 
                {
                    Address = objectDto.Address,
                    StartingPrice = objectDto.StartingPrice,
                    LivingArea = objectDto.LivingArea,
                    AncillaryArea = objectDto.AncillaryArea,
                    PlotArea = objectDto.PlotArea,
                    Description = objectDto.Description,
                    NumberOfRooms = objectDto.NumberOfRooms,
                    MonthlyFee = objectDto.MonthlyFee,
                    OperatingCostPerYear = objectDto.OperatingCostPerYear,
                    YearOfConstruction = objectDto.YearOfConstruction,
                    CategoryId = objectDto.CategoryId,
                    MunicipalityId = objectDto.MunicipalityId,
                    RealEstateAgentId = objectDto.RealEstateAgentId

                };
                if (!objectDto.RealEstateAgentId.IsNullOrEmpty())
                {
                    var agent = await agentRepo.GetRealEstateAgentByIdAsync(objectDto.RealEstateAgentId);
                    if (agent == null)
                    {
                        return BadRequest("Invalid agentId");
                    }
                    var municipality = await municipalityrepo.GetMunicipalityByIdAsync(objectDto.MunicipalityId.Value);
                    if (municipality == null)
                    {
                        return BadRequest("Invalid municipalityId");
                    }
                    var category = await categoryrepo.GetCategoryByIdAsync(objectDto.CategoryId.Value);
                    if(category == null)
                    {
                        return BadRequest("Invalid categoryId");
                    }
                    saleObject.RealEstateAgent = agent;
                    saleObject.Municipality = municipality;
                    saleObject.Category = category;
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
        public int Id { get; set; }
        public string Address { get; set; } = "";
        public int StartingPrice { get; set; }
        public int LivingArea { get; set; }
        public int AncillaryArea { get; set; }
        public int PlotArea { get; set; }
        public string Description { get; set; } = "";
        public int NumberOfRooms { get; set; }
        public int MonthlyFee { get; set; }
        public int OperatingCostPerYear { get; set; }
        public int YearOfConstruction { get; set; }
        public int? CategoryId { get; set; }
        public string? RealEstateAgentId { get; set; }
        public int? MunicipalityId { get; set; }
        public List<string> ImageUrl { get; set; } = new List<string>();
        public bool IsActive { get; set; } = true;
    }
}
