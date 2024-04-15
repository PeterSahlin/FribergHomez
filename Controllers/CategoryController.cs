using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FribergHomez.Data;
using FribergHomez.Models;

namespace FribergHomez.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory categoryRep;
        public CategoryController(ICategory categoryRep)
        {
            this.categoryRep = categoryRep;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var categories = await categoryRep.GetAllCategoriesAsync();
                return Ok(categories);
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
                await categoryRep.DeleteCategoryAsync(id);
                return NoContent();
            }catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Category category)
        {
            if (category == null)
            {
                return BadRequest("Category object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            try
            {
                await categoryRep.AddCategoryAsync(category);
                return StatusCode(201, category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Category category)
        {
            if (category == null)
            {
                return BadRequest("Category object is null");
            }

            if (id != category.Id)
            {
                return BadRequest("ID mismatch between route parameter and request body");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            try
            {
                var existingCategory = await categoryRep.GetCategoryByIdAsync(id);
                if (existingCategory == null)
                {
                    return NotFound("Category not found");
                }

                existingCategory.Name = category.Name;

                await categoryRep.UpdateCategoryAsync(existingCategory);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }
    }
}
