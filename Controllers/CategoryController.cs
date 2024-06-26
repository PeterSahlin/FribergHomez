﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FribergHomez.Data;
using FribergHomez.Models;
using FribergHomez.Const;
using Microsoft.AspNetCore.Authorization;

namespace FribergHomez.Controllers
{
    //Thomas

    [Authorize(Roles = APIRoles.AdminAndUser)]
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
        public async Task<ActionResult<IEnumerable<Category>>> Get()
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
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetById(int id)
        {
            try
            {
                var category = await categoryRep.GetCategoryByIdAsync(id);
                return Ok(category);
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
                return BadRequest(ex.Message);
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
                await categoryRep.CreateCategoryAsync(category);
                return StatusCode(201, category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] Category category)
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
                await categoryRep.UpdateCategoryAsync(category);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
